using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionSegmentation
{
    public partial class Form1 : Form
    {
        // 表示用
        Bitmap outputImage;
        double outputZoom;
        Point outputShift;
        bool isMouseDrag;
        Point mousePre;

        public Form1()
        {
            InitializeComponent();
        }

        private void 読み込みToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Matの準備
                OpenCvSharp.CPlusPlus.Mat matSrc = new OpenCvSharp.CPlusPlus.Mat(dialog.FileName);
                OpenCvSharp.CPlusPlus.Mat matDst = matSrc.Clone();

                //// 画像ピラミッドを用いた画像の領域分割 
                //int level = 4;              // ピラミッドレベル
                //double threshold1 = 128;    // ピクセルを接続する閾値
                //double threshold2 = 50;     // クラスタリングの範囲の閾値

                //// IplImageの準備(C API用)
                //OpenCvSharp.IplImage iplSrc = matSrc.ToIplImage();
                //OpenCvSharp.IplImage iplDst = iplSrc.Clone();

                //// ピラミッド画像作成のためのROI設定(2^levelで割り切れるサイズ)
                //OpenCvSharp.CvRect roi;
                //roi.X = 0;
                //roi.Y = 0;
                //roi.Width = iplSrc.Width & -(1 << level);
                //roi.Height = iplSrc.Height & -(1 << level);
                //iplSrc.SetROI(roi);
                //iplDst.SetROI(roi);

                //OpenCvSharp.Cv.PyrSegmentation(iplSrc, iplDst, level, threshold1, threshold2);

                //// IplImage -> Matに戻す
                //matDst = new OpenCvSharp.CPlusPlus.Mat(iplDst);

                //// 平均値シフト法による画像のセグメント化
                //double sp = 30; // 空間窓の半径
                //double sr = 30; // 色空間窓の半径
                //int level = 4;  // セグメンテーションに用いるピラミッドの最大レベル
                //OpenCvSharp.CPlusPlus.TermCriteria term = new OpenCvSharp.CPlusPlus.TermCriteria(OpenCvSharp.CriteriaType.Iteration, 5, 1);
                ////OpenCvSharp.CPlusPlus.TermCriteria term = new OpenCvSharp.CPlusPlus.TermCriteria(OpenCvSharp.CriteriaType.Epsilon, 5, 1);

                //OpenCvSharp.CPlusPlus.Cv2.PyrMeanShiftFiltering(matSrc, matDst, sp, sr, level, term);

                // Watershedアルゴリズムによる画像の領域分割 

                // IplImageの準備(C API用)
                OpenCvSharp.IplImage iplSrc = matSrc.ToIplImage();
                OpenCvSharp.IplImage iplDst = iplSrc.Clone();

                // マーカ画像の準備
                OpenCvSharp.IplImage iplMarker = new OpenCvSharp.IplImage(iplSrc.Size, OpenCvSharp.BitDepth.S32, 1);
                iplMarker.Zero();

                // マーカ設置(等分割)
                int wdiv = 10;   // 分割数(横)
                int hdiv = 10;   // 分割数(縦)
                OpenCvSharp.CvPoint[,] mpt = new OpenCvSharp.CvPoint[wdiv, hdiv];
                for (int i = 0; i < wdiv; i++)
                {
                    for (int j = 0; j < hdiv; j++)
                    {
                        mpt[i, j] = new OpenCvSharp.CvPoint((int)(iplSrc.Width / wdiv * (i + 0.5)), (int)(iplSrc.Height / hdiv * (j + 0.5)));
                        iplMarker.Circle(mpt[i, j], 5, OpenCvSharp.CvScalar.ScalarAll(i * wdiv + j), OpenCvSharp.Cv.FILLED, OpenCvSharp.LineType.Link8, 0);
                    }
                }

                // 分割実行
                OpenCvSharp.Cv.Watershed(iplSrc, iplMarker);

                // マーカの描画
                for (int i = 0; i < wdiv; i++)
                {
                    for (int j = 0; j < hdiv; j++)
                    {
                        iplDst.Circle(mpt[i, j], 20, OpenCvSharp.CvColor.White, 3, OpenCvSharp.LineType.Link8, 0);
                    }
                }

                // 領域境界の描画
                for (int i = 0; i < iplMarker.Height; i++)
                {
                    for (int j = 0; j < iplMarker.Width; j++)
                    {
                        int idx = (int)(iplMarker.Get2D(i, j).Val0);
                        if (idx == -1)
                        {
                            iplDst.Set2D(i, j, OpenCvSharp.CvColor.Red);
                        }
                    }
                }

                // IplImage -> Matに戻す
                matDst = new OpenCvSharp.CPlusPlus.Mat(iplDst);

                this.outputImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matDst);

                this.outputZoom = 1.0;
                this.outputShift = new Point(0, 0);
                this.isMouseDrag = false;
                this.mousePre = new Point(0, 0);

                this.pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // ボタン識別
		    if (!(e.Button == MouseButtons.Left))
            {
                return;
            }

            // マウスの元位置設定
            this.mousePre.X = e.X;
            this.mousePre.Y = e.Y;

            // マウス移動状態設定
            this.isMouseDrag = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.isMouseDrag)
            {
                return;
            }

            // シフト量
            this.outputShift.X += (e.X - this.mousePre.X);
            this.outputShift.Y += (e.Y - this.mousePre.Y);

            // マウスの元位置更新
            this.mousePre.X = e.X;
            this.mousePre.Y = e.Y;

            // 再描画
            this.pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
      		// ボタン識別
		    if (!(e.Button == MouseButtons.Left))
            {
                return;
            }

		    // マウス移動状態解除
		    this.isMouseDrag = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // マウスカーソルが来たらフォーカス(これをしないとホイールイベントが拾えない)
            pictureBox1.Focus();
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            // 現在のズーム値を記録
            double zoomPre = this.outputZoom;

            // 1カウントで10%増減、最小100%、最大1000%
            this.outputZoom += 0.1 * this.outputZoom * e.Delta / 120;   // マウスホイールの1カウント(Delta)は120
            this.outputZoom = Math.Min(10.0, Math.Max(1.0, this.outputZoom));

            // シフト値の更新
            this.outputShift.X = (int)((this.outputShift.X - e.X) * this.outputZoom / zoomPre + e.X);
            this.outputShift.Y = (int)((this.outputShift.Y - e.Y) * this.outputZoom / zoomPre + e.Y);

            // ズームが1.0ならシフト値リセット
            if (Math.Abs(this.outputZoom - 1.0) < 0.001)
            {
                this.outputShift.X = 0;
                this.outputShift.Y = 0;
            }

            // 再描画
            this.pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (this.outputImage != null)
            {
                // アスペクトとスケール
                double aspect = (double)this.outputImage.Width / this.outputImage.Height;
                double scale = Math.Min((double)((PictureBox)sender).Height, ((PictureBox)sender).Width / aspect) * this.outputZoom;

                // 描画
                e.Graphics.DrawImage(this.outputImage, this.outputShift.X, this.outputShift.Y, (int)(scale * aspect), (int)scale);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Invalidate();
        }
    }
}
