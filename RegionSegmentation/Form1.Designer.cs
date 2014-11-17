namespace RegionSegmentation
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.読み込みToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxL = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMenuR = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelParamR4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxParamR3 = new System.Windows.Forms.TextBox();
            this.labelParamR3 = new System.Windows.Forms.Label();
            this.tableLayoutPanelParamR2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxParamR2 = new System.Windows.Forms.TextBox();
            this.labelParamR2 = new System.Windows.Forms.Label();
            this.comboBoxProcR = new System.Windows.Forms.ComboBox();
            this.buttonProcR = new System.Windows.Forms.Button();
            this.tableLayoutPanelParamR1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxParamR1 = new System.Windows.Forms.TextBox();
            this.labelParamR1 = new System.Windows.Forms.Label();
            this.pictureBoxR = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMenuL = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelParamL3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxParamL3 = new System.Windows.Forms.TextBox();
            this.labelParamL3 = new System.Windows.Forms.Label();
            this.tableLayoutPanelParamL2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxParamL2 = new System.Windows.Forms.TextBox();
            this.labelParamL2 = new System.Windows.Forms.Label();
            this.comboBoxProcL = new System.Windows.Forms.ComboBox();
            this.buttonProcL = new System.Windows.Forms.Button();
            this.tableLayoutPanelParamL1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxParamL1 = new System.Windows.Forms.TextBox();
            this.labelParamL1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).BeginInit();
            this.tableLayoutPanelBase.SuspendLayout();
            this.tableLayoutPanelMenuR.SuspendLayout();
            this.tableLayoutPanelParamR4.SuspendLayout();
            this.tableLayoutPanelParamR2.SuspendLayout();
            this.tableLayoutPanelParamR1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR)).BeginInit();
            this.tableLayoutPanelMenuL.SuspendLayout();
            this.tableLayoutPanelParamL3.SuspendLayout();
            this.tableLayoutPanelParamL2.SuspendLayout();
            this.tableLayoutPanelParamL1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.読み込みToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 読み込みToolStripMenuItem
            // 
            this.読み込みToolStripMenuItem.Name = "読み込みToolStripMenuItem";
            this.読み込みToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.読み込みToolStripMenuItem.Text = "読み込み";
            this.読み込みToolStripMenuItem.Click += new System.EventHandler(this.読み込みToolStripMenuItem_Click);
            // 
            // pictureBoxL
            // 
            this.pictureBoxL.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBoxL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxL.Location = new System.Drawing.Point(4, 43);
            this.pictureBoxL.Name = "pictureBoxL";
            this.pictureBoxL.Size = new System.Drawing.Size(496, 363);
            this.pictureBoxL.TabIndex = 1;
            this.pictureBoxL.TabStop = false;
            this.pictureBoxL.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxL_Paint);
            this.pictureBoxL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBoxL.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBoxL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            this.pictureBoxL.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseWheel);
            // 
            // tableLayoutPanelBase
            // 
            this.tableLayoutPanelBase.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelBase.ColumnCount = 2;
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.Controls.Add(this.tableLayoutPanelMenuR, 1, 0);
            this.tableLayoutPanelBase.Controls.Add(this.pictureBoxL, 0, 1);
            this.tableLayoutPanelBase.Controls.Add(this.pictureBoxR, 1, 1);
            this.tableLayoutPanelBase.Controls.Add(this.tableLayoutPanelMenuL, 0, 0);
            this.tableLayoutPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBase.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelBase.Name = "tableLayoutPanelBase";
            this.tableLayoutPanelBase.RowCount = 2;
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBase.Size = new System.Drawing.Size(1007, 410);
            this.tableLayoutPanelBase.TabIndex = 2;
            // 
            // tableLayoutPanelMenuR
            // 
            this.tableLayoutPanelMenuR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanelMenuR.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelMenuR.ColumnCount = 5;
            this.tableLayoutPanelMenuR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuR.Controls.Add(this.tableLayoutPanelParamR4, 3, 0);
            this.tableLayoutPanelMenuR.Controls.Add(this.tableLayoutPanelParamR2, 2, 0);
            this.tableLayoutPanelMenuR.Controls.Add(this.comboBoxProcR, 0, 0);
            this.tableLayoutPanelMenuR.Controls.Add(this.buttonProcR, 4, 0);
            this.tableLayoutPanelMenuR.Controls.Add(this.tableLayoutPanelParamR1, 1, 0);
            this.tableLayoutPanelMenuR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenuR.Location = new System.Drawing.Point(507, 4);
            this.tableLayoutPanelMenuR.Name = "tableLayoutPanelMenuR";
            this.tableLayoutPanelMenuR.RowCount = 1;
            this.tableLayoutPanelMenuR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenuR.Size = new System.Drawing.Size(496, 32);
            this.tableLayoutPanelMenuR.TabIndex = 4;
            // 
            // tableLayoutPanelParamR4
            // 
            this.tableLayoutPanelParamR4.ColumnCount = 2;
            this.tableLayoutPanelParamR4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelParamR4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelParamR4.Controls.Add(this.textBoxParamR3, 1, 0);
            this.tableLayoutPanelParamR4.Controls.Add(this.labelParamR3, 0, 0);
            this.tableLayoutPanelParamR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelParamR4.Location = new System.Drawing.Point(301, 4);
            this.tableLayoutPanelParamR4.Name = "tableLayoutPanelParamR4";
            this.tableLayoutPanelParamR4.RowCount = 1;
            this.tableLayoutPanelParamR4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelParamR4.Size = new System.Drawing.Size(92, 24);
            this.tableLayoutPanelParamR4.TabIndex = 5;
            // 
            // textBoxParamR3
            // 
            this.textBoxParamR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxParamR3.Location = new System.Drawing.Point(67, 3);
            this.textBoxParamR3.Name = "textBoxParamR3";
            this.textBoxParamR3.Size = new System.Drawing.Size(22, 19);
            this.textBoxParamR3.TabIndex = 2;
            // 
            // labelParamR3
            // 
            this.labelParamR3.AutoSize = true;
            this.labelParamR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParamR3.Location = new System.Drawing.Point(3, 0);
            this.labelParamR3.Name = "labelParamR3";
            this.labelParamR3.Size = new System.Drawing.Size(58, 24);
            this.labelParamR3.TabIndex = 3;
            this.labelParamR3.Text = "param3";
            this.labelParamR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelParamR2
            // 
            this.tableLayoutPanelParamR2.ColumnCount = 2;
            this.tableLayoutPanelParamR2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelParamR2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelParamR2.Controls.Add(this.textBoxParamR2, 1, 0);
            this.tableLayoutPanelParamR2.Controls.Add(this.labelParamR2, 0, 0);
            this.tableLayoutPanelParamR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelParamR2.Location = new System.Drawing.Point(202, 4);
            this.tableLayoutPanelParamR2.Name = "tableLayoutPanelParamR2";
            this.tableLayoutPanelParamR2.RowCount = 1;
            this.tableLayoutPanelParamR2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelParamR2.Size = new System.Drawing.Size(92, 24);
            this.tableLayoutPanelParamR2.TabIndex = 4;
            // 
            // textBoxParamR2
            // 
            this.textBoxParamR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxParamR2.Location = new System.Drawing.Point(67, 3);
            this.textBoxParamR2.Name = "textBoxParamR2";
            this.textBoxParamR2.Size = new System.Drawing.Size(22, 19);
            this.textBoxParamR2.TabIndex = 2;
            // 
            // labelParamR2
            // 
            this.labelParamR2.AutoSize = true;
            this.labelParamR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParamR2.Location = new System.Drawing.Point(3, 0);
            this.labelParamR2.Name = "labelParamR2";
            this.labelParamR2.Size = new System.Drawing.Size(58, 24);
            this.labelParamR2.TabIndex = 3;
            this.labelParamR2.Text = "param2";
            this.labelParamR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxProcR
            // 
            this.comboBoxProcR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProcR.FormattingEnabled = true;
            this.comboBoxProcR.Items.AddRange(new object[] {
            "none (reset)",
            "PyrSegmentation",
            "PyrMeanShiftFiltering",
            "Watershed",
            "GrayScale",
            "Canny",
            "Binary",
            "Hough",
            "HoughStat",
            "HoughStat2",
            "Contour",
            "ContourOnly",
            "ContourOnly2"});
            this.comboBoxProcR.Location = new System.Drawing.Point(4, 4);
            this.comboBoxProcR.Name = "comboBoxProcR";
            this.comboBoxProcR.Size = new System.Drawing.Size(92, 20);
            this.comboBoxProcR.TabIndex = 0;
            this.comboBoxProcR.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcR_SelectedIndexChanged);
            // 
            // buttonProcR
            // 
            this.buttonProcR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProcR.Location = new System.Drawing.Point(400, 4);
            this.buttonProcR.Name = "buttonProcR";
            this.buttonProcR.Size = new System.Drawing.Size(92, 24);
            this.buttonProcR.TabIndex = 1;
            this.buttonProcR.Text = "Process!";
            this.buttonProcR.UseVisualStyleBackColor = true;
            this.buttonProcR.Click += new System.EventHandler(this.buttonProcR_Click);
            // 
            // tableLayoutPanelParamR1
            // 
            this.tableLayoutPanelParamR1.ColumnCount = 2;
            this.tableLayoutPanelParamR1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelParamR1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelParamR1.Controls.Add(this.textBoxParamR1, 1, 0);
            this.tableLayoutPanelParamR1.Controls.Add(this.labelParamR1, 0, 0);
            this.tableLayoutPanelParamR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelParamR1.Location = new System.Drawing.Point(103, 4);
            this.tableLayoutPanelParamR1.Name = "tableLayoutPanelParamR1";
            this.tableLayoutPanelParamR1.RowCount = 1;
            this.tableLayoutPanelParamR1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelParamR1.Size = new System.Drawing.Size(92, 24);
            this.tableLayoutPanelParamR1.TabIndex = 3;
            // 
            // textBoxParamR1
            // 
            this.textBoxParamR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxParamR1.Location = new System.Drawing.Point(67, 3);
            this.textBoxParamR1.Name = "textBoxParamR1";
            this.textBoxParamR1.Size = new System.Drawing.Size(22, 19);
            this.textBoxParamR1.TabIndex = 2;
            // 
            // labelParamR1
            // 
            this.labelParamR1.AutoSize = true;
            this.labelParamR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParamR1.Location = new System.Drawing.Point(3, 0);
            this.labelParamR1.Name = "labelParamR1";
            this.labelParamR1.Size = new System.Drawing.Size(58, 24);
            this.labelParamR1.TabIndex = 3;
            this.labelParamR1.Text = "param1";
            this.labelParamR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxR
            // 
            this.pictureBoxR.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBoxR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxR.Location = new System.Drawing.Point(507, 43);
            this.pictureBoxR.Name = "pictureBoxR";
            this.pictureBoxR.Size = new System.Drawing.Size(496, 363);
            this.pictureBoxR.TabIndex = 2;
            this.pictureBoxR.TabStop = false;
            this.pictureBoxR.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxR_Paint);
            this.pictureBoxR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBoxR.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBoxR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            this.pictureBoxR.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseWheel);
            // 
            // tableLayoutPanelMenuL
            // 
            this.tableLayoutPanelMenuL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanelMenuL.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelMenuL.ColumnCount = 5;
            this.tableLayoutPanelMenuL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenuL.Controls.Add(this.tableLayoutPanelParamL3, 3, 0);
            this.tableLayoutPanelMenuL.Controls.Add(this.tableLayoutPanelParamL2, 2, 0);
            this.tableLayoutPanelMenuL.Controls.Add(this.comboBoxProcL, 0, 0);
            this.tableLayoutPanelMenuL.Controls.Add(this.buttonProcL, 4, 0);
            this.tableLayoutPanelMenuL.Controls.Add(this.tableLayoutPanelParamL1, 1, 0);
            this.tableLayoutPanelMenuL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenuL.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanelMenuL.Name = "tableLayoutPanelMenuL";
            this.tableLayoutPanelMenuL.RowCount = 1;
            this.tableLayoutPanelMenuL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenuL.Size = new System.Drawing.Size(496, 32);
            this.tableLayoutPanelMenuL.TabIndex = 3;
            // 
            // tableLayoutPanelParamL3
            // 
            this.tableLayoutPanelParamL3.ColumnCount = 2;
            this.tableLayoutPanelParamL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelParamL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelParamL3.Controls.Add(this.textBoxParamL3, 1, 0);
            this.tableLayoutPanelParamL3.Controls.Add(this.labelParamL3, 0, 0);
            this.tableLayoutPanelParamL3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelParamL3.Location = new System.Drawing.Point(301, 4);
            this.tableLayoutPanelParamL3.Name = "tableLayoutPanelParamL3";
            this.tableLayoutPanelParamL3.RowCount = 1;
            this.tableLayoutPanelParamL3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelParamL3.Size = new System.Drawing.Size(92, 24);
            this.tableLayoutPanelParamL3.TabIndex = 5;
            // 
            // textBoxParamL3
            // 
            this.textBoxParamL3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxParamL3.Location = new System.Drawing.Point(67, 3);
            this.textBoxParamL3.Name = "textBoxParamL3";
            this.textBoxParamL3.Size = new System.Drawing.Size(22, 19);
            this.textBoxParamL3.TabIndex = 2;
            // 
            // labelParamL3
            // 
            this.labelParamL3.AutoSize = true;
            this.labelParamL3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParamL3.Location = new System.Drawing.Point(3, 0);
            this.labelParamL3.Name = "labelParamL3";
            this.labelParamL3.Size = new System.Drawing.Size(58, 24);
            this.labelParamL3.TabIndex = 3;
            this.labelParamL3.Text = "param3";
            this.labelParamL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelParamL2
            // 
            this.tableLayoutPanelParamL2.ColumnCount = 2;
            this.tableLayoutPanelParamL2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelParamL2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelParamL2.Controls.Add(this.textBoxParamL2, 1, 0);
            this.tableLayoutPanelParamL2.Controls.Add(this.labelParamL2, 0, 0);
            this.tableLayoutPanelParamL2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelParamL2.Location = new System.Drawing.Point(202, 4);
            this.tableLayoutPanelParamL2.Name = "tableLayoutPanelParamL2";
            this.tableLayoutPanelParamL2.RowCount = 1;
            this.tableLayoutPanelParamL2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelParamL2.Size = new System.Drawing.Size(92, 24);
            this.tableLayoutPanelParamL2.TabIndex = 4;
            // 
            // textBoxParamL2
            // 
            this.textBoxParamL2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxParamL2.Location = new System.Drawing.Point(67, 3);
            this.textBoxParamL2.Name = "textBoxParamL2";
            this.textBoxParamL2.Size = new System.Drawing.Size(22, 19);
            this.textBoxParamL2.TabIndex = 2;
            // 
            // labelParamL2
            // 
            this.labelParamL2.AutoSize = true;
            this.labelParamL2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParamL2.Location = new System.Drawing.Point(3, 0);
            this.labelParamL2.Name = "labelParamL2";
            this.labelParamL2.Size = new System.Drawing.Size(58, 24);
            this.labelParamL2.TabIndex = 3;
            this.labelParamL2.Text = "param2";
            this.labelParamL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxProcL
            // 
            this.comboBoxProcL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProcL.FormattingEnabled = true;
            this.comboBoxProcL.Items.AddRange(new object[] {
            "none (reset)",
            "PyrSegmentation",
            "PyrMeanShiftFiltering",
            "Watershed",
            "GrayScale",
            "Canny",
            "Binary",
            "Hough",
            "HoughStat",
            "HoughStat2",
            "Contour",
            "ContourOnly",
            "ContourOnly2"});
            this.comboBoxProcL.Location = new System.Drawing.Point(4, 4);
            this.comboBoxProcL.Name = "comboBoxProcL";
            this.comboBoxProcL.Size = new System.Drawing.Size(92, 20);
            this.comboBoxProcL.TabIndex = 0;
            this.comboBoxProcL.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcL_SelectedIndexChanged);
            // 
            // buttonProcL
            // 
            this.buttonProcL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProcL.Location = new System.Drawing.Point(400, 4);
            this.buttonProcL.Name = "buttonProcL";
            this.buttonProcL.Size = new System.Drawing.Size(92, 24);
            this.buttonProcL.TabIndex = 1;
            this.buttonProcL.Text = "Process!";
            this.buttonProcL.UseVisualStyleBackColor = true;
            this.buttonProcL.Click += new System.EventHandler(this.buttonProcL_Click);
            // 
            // tableLayoutPanelParamL1
            // 
            this.tableLayoutPanelParamL1.ColumnCount = 2;
            this.tableLayoutPanelParamL1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelParamL1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelParamL1.Controls.Add(this.textBoxParamL1, 1, 0);
            this.tableLayoutPanelParamL1.Controls.Add(this.labelParamL1, 0, 0);
            this.tableLayoutPanelParamL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelParamL1.Location = new System.Drawing.Point(103, 4);
            this.tableLayoutPanelParamL1.Name = "tableLayoutPanelParamL1";
            this.tableLayoutPanelParamL1.RowCount = 1;
            this.tableLayoutPanelParamL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelParamL1.Size = new System.Drawing.Size(92, 24);
            this.tableLayoutPanelParamL1.TabIndex = 3;
            // 
            // textBoxParamL1
            // 
            this.textBoxParamL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxParamL1.Location = new System.Drawing.Point(67, 3);
            this.textBoxParamL1.Name = "textBoxParamL1";
            this.textBoxParamL1.Size = new System.Drawing.Size(22, 19);
            this.textBoxParamL1.TabIndex = 2;
            // 
            // labelParamL1
            // 
            this.labelParamL1.AutoSize = true;
            this.labelParamL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParamL1.Location = new System.Drawing.Point(3, 0);
            this.labelParamL1.Name = "labelParamL1";
            this.labelParamL1.Size = new System.Drawing.Size(58, 24);
            this.labelParamL1.TabIndex = 3;
            this.labelParamL1.Text = "param1";
            this.labelParamL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1007, 434);
            this.Controls.Add(this.tableLayoutPanelBase);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).EndInit();
            this.tableLayoutPanelBase.ResumeLayout(false);
            this.tableLayoutPanelMenuR.ResumeLayout(false);
            this.tableLayoutPanelParamR4.ResumeLayout(false);
            this.tableLayoutPanelParamR4.PerformLayout();
            this.tableLayoutPanelParamR2.ResumeLayout(false);
            this.tableLayoutPanelParamR2.PerformLayout();
            this.tableLayoutPanelParamR1.ResumeLayout(false);
            this.tableLayoutPanelParamR1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR)).EndInit();
            this.tableLayoutPanelMenuL.ResumeLayout(false);
            this.tableLayoutPanelParamL3.ResumeLayout(false);
            this.tableLayoutPanelParamL3.PerformLayout();
            this.tableLayoutPanelParamL2.ResumeLayout(false);
            this.tableLayoutPanelParamL2.PerformLayout();
            this.tableLayoutPanelParamL1.ResumeLayout(false);
            this.tableLayoutPanelParamL1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 読み込みToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBase;
        private System.Windows.Forms.PictureBox pictureBoxR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenuL;
        private System.Windows.Forms.ComboBox comboBoxProcL;
        private System.Windows.Forms.Button buttonProcL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParamL1;
        private System.Windows.Forms.TextBox textBoxParamL1;
        private System.Windows.Forms.Label labelParamL1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParamL2;
        private System.Windows.Forms.TextBox textBoxParamL2;
        private System.Windows.Forms.Label labelParamL2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenuR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParamR4;
        private System.Windows.Forms.TextBox textBoxParamR3;
        private System.Windows.Forms.Label labelParamR3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParamR2;
        private System.Windows.Forms.TextBox textBoxParamR2;
        private System.Windows.Forms.Label labelParamR2;
        private System.Windows.Forms.ComboBox comboBoxProcR;
        private System.Windows.Forms.Button buttonProcR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParamR1;
        private System.Windows.Forms.TextBox textBoxParamR1;
        private System.Windows.Forms.Label labelParamR1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParamL3;
        private System.Windows.Forms.TextBox textBoxParamL3;
        private System.Windows.Forms.Label labelParamL3;
    }
}

