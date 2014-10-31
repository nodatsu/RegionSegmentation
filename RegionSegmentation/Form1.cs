﻿using System;
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
        // 画像データ
        OpenCvSharp.CPlusPlus.Mat matOrg;
        OpenCvSharp.CPlusPlus.Mat matL;
        OpenCvSharp.CPlusPlus.Mat matR;
        
        // 表示用
        Bitmap outputImageL;
        Bitmap outputImageR;
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
            // データ読み込み
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.matOrg = new OpenCvSharp.CPlusPlus.Mat(dialog.FileName);
                this.matL = this.matOrg.Clone();
                this.matR = this.matOrg.Clone();

                this.outputImageL = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matL);
                this.outputImageR = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matR);

                this.outputZoom = 1.0;
                this.outputShift = new Point(0, 0);
                this.isMouseDrag = false;
                this.mousePre = new Point(0, 0);

                this.comboBoxProcL.SelectedIndex = 0;
                this.comboBoxProcR.SelectedIndex = 0;

                this.pictureBoxL.Invalidate();
                this.pictureBoxR.Invalidate();
            }
        }

        // 左側処理切り替え
        private void comboBoxProcL_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxProcLR_SelectedIndexChanged(this.comboBoxProcL, this.labelParamL1, this.textBoxParamL1, this.labelParamL2, this.textBoxParamL2, this.labelParamL3, this.textBoxParamL3);
        }

        // 右側処理切り替え
        private void comboBoxProcR_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxProcLR_SelectedIndexChanged(this.comboBoxProcR, this.labelParamR1, this.textBoxParamR1, this.labelParamR2, this.textBoxParamR2, this.labelParamR3, this.textBoxParamR3);
        }

        // 左右処理切り替え本体
        private void comboBoxProcLR_SelectedIndexChanged(ComboBox cb, Label lb1, TextBox tb1, Label lb2, TextBox tb2, Label lb3, TextBox tb3)
        {
            if (cb.Text.Equals("PyrSegmentation"))
            {
                // 画像ピラミッドを用いた画像の領域分割
                // パラメータ: ピラミッドレベル, ピクセルを接続する閾値, クラスタリングの範囲の閾値
                lb1.Text = "ピラミッドレベル";
                tb1.Text = "9";
                lb2.Text = "ピクセルを接続する閾値";
                tb2.Text = "16.0";
                lb3.Text = "クラスタリングの範囲の閾値";
                tb3.Text = "50.0";
            }
            else if (cb.Text.Equals("PyrMeanShiftFiltering"))
            {
                // 平均値シフト法による画像のセグメント化
                lb1.Text = "空間窓の半径";
                tb1.Text = "30.0";
                lb2.Text = "色空間窓の半径";
                tb2.Text = "10.0";
                lb3.Text = "最大ピラミッドレベル";
                tb3.Text = "4";
            }
            else if (cb.Text.Equals("Watershed"))
            {
                // Watershedアルゴリズムによる画像の領域分割
                lb1.Text = "マーカ数(横)";
                tb1.Text = "10";
                lb2.Text = "マーカ数(縦)";
                tb2.Text = "10";
                lb3.Text = "マーカサイズ";
                tb3.Text = "5";
            }
            else if (cb.Text.Equals("Canny"))
            {
                // エッジ抽出(Canny)
                lb1.Text = "閾値1(接続)";
                tb1.Text = "100";
                lb2.Text = "閾値2(始点)";
                tb2.Text = "200";
                lb3.Text = "Sobel演算サイズ";
                tb3.Text = "3";
            }
            else
            {
                // 何もしない
                lb1.Text = "Param1";
                tb1.Text = "";
                lb2.Text = "Param2";
                tb2.Text = "";
                lb3.Text = "Param3";
                tb3.Text = "";
            }
        }

        // 左側処理
        private void buttonProcL_Click(object sender, EventArgs e)
        {
            this.buttonProcLR_Click(this.comboBoxProcL, ref this.matL, ref this.outputImageL, this.textBoxParamL1, this.textBoxParamL2, this.textBoxParamL3);

            this.pictureBoxL.Invalidate();
        }

        // 右側処理
        private void buttonProcR_Click(object sender, EventArgs e)
        {
            this.buttonProcLR_Click(this.comboBoxProcR, ref this.matR, ref this.outputImageR, this.textBoxParamR1, this.textBoxParamR2, this.textBoxParamR3);

            this.pictureBoxR.Invalidate();
        }

        // 左右側処理本体
        private void buttonProcLR_Click(ComboBox cb, ref OpenCvSharp.CPlusPlus.Mat mat, ref Bitmap bm, TextBox tb1, TextBox tb2, TextBox tb3)
        {
            if (mat == null) return;

            OpenCvSharp.CPlusPlus.Mat matDst;

            if (cb.Text.Equals("none (reset)"))
            {
                mat = this.matOrg.Clone();
                bm = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
            }
            else if (cb.Text.Equals("PyrSegmentation"))
            {
                // 画像ピラミッドを用いた画像の領域分割
                matDst = this.procPyrSegmentation(mat, int.Parse(tb1.Text), double.Parse(tb2.Text), double.Parse(tb3.Text));
                mat = matDst;
                bm = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
            }
            else if (cb.Text.Equals("PyrMeanShiftFiltering"))
            {
                // 平均値シフト法による画像のセグメント化
                matDst = this.procPyrMeanShiftFiltering(mat, double.Parse(tb1.Text), double.Parse(tb2.Text), int.Parse(tb3.Text));
                mat = matDst;
                bm = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
            }
            else if (cb.Text.Equals("Watershed"))
            {
                // Watershedアルゴリズムによる画像の領域分割 
                matDst = this.procWatershed(mat, int.Parse(tb1.Text), int.Parse(tb2.Text), int.Parse(tb3.Text));
                bm = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matDst);
            }
            else if (cb.Text.Equals("GrayScale"))
            {
                // グレースケール化 
                matDst = this.procGrayScale(mat);
                mat = matDst;
                bm = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
            }
            else if (cb.Text.Equals("Canny"))
            {
                // エッジ抽出(Canny) 
                matDst = this.procCanny(mat, double.Parse(tb1.Text), double.Parse(tb2.Text), int.Parse(tb3.Text));
                mat = matDst;
                bm = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
            }
            else if (cb.Text.Equals("Binary"))
            {
                // 2値化(グレースケール化 + 2値化)
                matDst = this.procBinary(mat);
                mat = matDst;
                bm = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
            }
        }

        // 2値化(グレースケール化 + 2値化)
        private OpenCvSharp.CPlusPlus.Mat procBinary(OpenCvSharp.CPlusPlus.Mat matSrc)
        {
            // Matの準備
            //OpenCvSharp.CPlusPlus.Mat matDst = matSrc.Clone();
            OpenCvSharp.CPlusPlus.Mat matDst = new OpenCvSharp.CPlusPlus.Mat(matSrc.Rows, matSrc.Cols, OpenCvSharp.CPlusPlus.MatType.CV_8UC1);
            OpenCvSharp.CPlusPlus.Mat matGray = new OpenCvSharp.CPlusPlus.Mat(matSrc.Rows, matSrc.Cols, OpenCvSharp.CPlusPlus.MatType.CV_8UC1);

            OpenCvSharp.CPlusPlus.Cv2.CvtColor(matSrc, matGray, OpenCvSharp.ColorConversion.BgraToGray, 1);

            OpenCvSharp.CPlusPlus.Cv2.Threshold(matGray, matDst, 0, 255, OpenCvSharp.ThresholdType.Binary | OpenCvSharp.ThresholdType.Otsu);

            return matDst;
        }

        // エッジ抽出(Canny)
        private OpenCvSharp.CPlusPlus.Mat procCanny(OpenCvSharp.CPlusPlus.Mat matSrc, double threshold1, double threshold2, int apertureSize)
        {
            // Matの準備
            OpenCvSharp.CPlusPlus.Mat matDst = matSrc.Clone();

            OpenCvSharp.CPlusPlus.Cv2.Canny(matSrc, matDst, threshold1, threshold2, apertureSize);

            return matDst;
        }

        // グレースケール化
        private OpenCvSharp.CPlusPlus.Mat procGrayScale(OpenCvSharp.CPlusPlus.Mat matSrc)
        {
            // Matの準備
            //OpenCvSharp.CPlusPlus.Mat matDst = matSrc.Clone();
            OpenCvSharp.CPlusPlus.Mat matDst = new OpenCvSharp.CPlusPlus.Mat(matSrc.Rows, matSrc.Cols, OpenCvSharp.CPlusPlus.MatType.CV_8UC1);

            OpenCvSharp.CPlusPlus.Cv2.CvtColor(matSrc, matDst, OpenCvSharp.ColorConversion.BgraToGray, 1);

            return matDst;
        }

        // 画像ピラミッドを用いた画像の領域分割
        // パラメータ: ピラミッドレベル, ピクセルを接続する閾値, クラスタリングの範囲の閾値
        private OpenCvSharp.CPlusPlus.Mat procPyrSegmentation(OpenCvSharp.CPlusPlus.Mat matSrc, int level, double threshold1, double threshold2)
        {
            // Matの準備
            OpenCvSharp.CPlusPlus.Mat matDst = matSrc.Clone();

            // IplImageの準備(C API用)
            OpenCvSharp.IplImage iplSrc = matSrc.ToIplImage();
            OpenCvSharp.IplImage iplDst = iplSrc.Clone();

            // ピラミッド画像作成のためのROI設定(2^levelで割り切れるサイズ)
            OpenCvSharp.CvRect roi;
            roi.X = 0;
            roi.Y = 0;
            roi.Width = iplSrc.Width & -(1 << level);
            roi.Height = iplSrc.Height & -(1 << level);
            iplSrc.SetROI(roi);
            iplDst.SetROI(roi);

            OpenCvSharp.Cv.PyrSegmentation(iplSrc, iplDst, level, threshold1, threshold2);

            // IplImage -> Matに戻す
            matDst = new OpenCvSharp.CPlusPlus.Mat(iplDst);

            return matDst;
        }

        // 平均値シフト法による画像のセグメント化
        // パラメータ: 空間窓の半径, 色空間窓の半径, セグメンテーションに用いるピラミッドの最大レベル
        private OpenCvSharp.CPlusPlus.Mat procPyrMeanShiftFiltering(OpenCvSharp.CPlusPlus.Mat matSrc, double sp, double sr, int level)
        {
            // 終了パラメータ
            OpenCvSharp.CPlusPlus.TermCriteria term = new OpenCvSharp.CPlusPlus.TermCriteria(OpenCvSharp.CriteriaType.Iteration, 5, 1);
            //OpenCvSharp.CPlusPlus.TermCriteria term = new OpenCvSharp.CPlusPlus.TermCriteria(OpenCvSharp.CriteriaType.Epsilon, 5, 1);

            // Matの準備
            OpenCvSharp.CPlusPlus.Mat matDst = matSrc.Clone();

            OpenCvSharp.CPlusPlus.Cv2.PyrMeanShiftFiltering(matSrc, matDst, sp, sr, level, term);

            return matDst;
        }

        // Watershedアルゴリズムによる画像の領域分割 
        // パラメータ: 分割数(横), 分割数(縦), マーカサイズ
        private OpenCvSharp.CPlusPlus.Mat procWatershed(OpenCvSharp.CPlusPlus.Mat matSrc, int wdiv, int hdiv, int msize)
        {            
            // Matの準備
            OpenCvSharp.CPlusPlus.Mat matDst = matSrc.Clone();

            // IplImageの準備(C API用)
            OpenCvSharp.IplImage iplSrc = matSrc.ToIplImage();
            OpenCvSharp.IplImage iplDst = iplSrc.Clone();

            // マーカ画像の準備
            OpenCvSharp.IplImage iplMarker = new OpenCvSharp.IplImage(iplSrc.Size, OpenCvSharp.BitDepth.S32, 1);
            iplMarker.Zero();

            // マーカ設置(等分割)
            OpenCvSharp.CvPoint[,] mpt = new OpenCvSharp.CvPoint[wdiv, hdiv];
            for (int i = 0; i < wdiv; i++)
            {
                for (int j = 0; j < hdiv; j++)
                {
                    mpt[i, j] = new OpenCvSharp.CvPoint((int)(iplSrc.Width / wdiv * (i + 0.5)), (int)(iplSrc.Height / hdiv * (j + 0.5)));
                    iplMarker.Circle(mpt[i, j], msize, OpenCvSharp.CvScalar.ScalarAll(i * wdiv + j), OpenCvSharp.Cv.FILLED, OpenCvSharp.LineType.Link8, 0);
                }
            }

            // 分割実行
            OpenCvSharp.Cv.Watershed(iplSrc, iplMarker);

            // マーカの描画
            for (int i = 0; i < wdiv; i++)
            {
                for (int j = 0; j < hdiv; j++)
                {
                    iplDst.Circle(mpt[i, j], msize, OpenCvSharp.CvColor.White, 3, OpenCvSharp.LineType.Link8, 0);
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

            return matDst;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
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

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
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
            this.pictureBoxL.Invalidate();
            this.pictureBoxR.Invalidate();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
      		// ボタン識別
		    if (!(e.Button == MouseButtons.Left))
            {
                return;
            }

		    // マウス移動状態解除
		    this.isMouseDrag = false;
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            // マウスカーソルが来たらフォーカス(これをしないとホイールイベントが拾えない)
            ((System.Windows.Forms.PictureBox)sender).Focus();
        }

        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
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
            this.pictureBoxL.Invalidate();
            this.pictureBoxR.Invalidate();
        }

        private void pictureBoxL_Paint(object sender, PaintEventArgs e)
        {
            if (this.outputImageL != null)
            {
                // アスペクトとスケール
                double aspect = (double)this.outputImageL.Width / this.outputImageL.Height;
                double scale = Math.Min((double)((PictureBox)sender).Height, ((PictureBox)sender).Width / aspect) * this.outputZoom;

                // 描画
                e.Graphics.DrawImage(this.outputImageL, this.outputShift.X, this.outputShift.Y, (int)(scale * aspect), (int)scale);
            }
        }

        private void pictureBoxR_Paint(object sender, PaintEventArgs e)
        {
            if (this.outputImageR != null)
            {
                // アスペクトとスケール
                double aspect = (double)this.outputImageR.Width / this.outputImageR.Height;
                double scale = Math.Min((double)((PictureBox)sender).Height, ((PictureBox)sender).Width / aspect) * this.outputZoom;

                // 描画
                e.Graphics.DrawImage(this.outputImageR, this.outputShift.X, this.outputShift.Y, (int)(scale * aspect), (int)scale);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.pictureBoxL.Invalidate();
            this.pictureBoxR.Invalidate();
        }
    }
}
