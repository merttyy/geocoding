namespace google_maps
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lstCoordinates = new ListBox();
            label1 = new Label();
            lblKoordinat = new Label();
            picSearch = new PictureBox();
            txtKonum = new TextBox();
            pnlTop = new Panel();
            pictureBox2 = new PictureBox();
            picMinimize = new PictureBox();
            picExit = new PictureBox();
            panel2 = new Panel();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lstCoordinates);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblKoordinat);
            panel1.Controls.Add(picSearch);
            panel1.Controls.Add(txtKonum);
            panel1.Location = new Point(5, 54);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 749);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lstCoordinates
            // 
            lstCoordinates.FormattingEnabled = true;
            lstCoordinates.ItemHeight = 32;
            lstCoordinates.Location = new Point(26, 469);
            lstCoordinates.Name = "lstCoordinates";
            lstCoordinates.Size = new Size(574, 228);
            lstCoordinates.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(26, 327);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 2;
            label1.Text = "Aranacak Konum";
            // 
            // lblKoordinat
            // 
            lblKoordinat.AutoSize = true;
            lblKoordinat.BackColor = Color.LightGray;
            lblKoordinat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKoordinat.ForeColor = Color.DimGray;
            lblKoordinat.Location = new Point(26, 431);
            lblKoordinat.Name = "lblKoordinat";
            lblKoordinat.Size = new Size(269, 32);
            lblKoordinat.TabIndex = 1;
            lblKoordinat.Text = "Konumun Koordinatları";
            // 
            // picSearch
            // 
            picSearch.Image = (Image)resources.GetObject("picSearch.Image");
            picSearch.Location = new Point(561, 365);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(39, 39);
            picSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            picSearch.TabIndex = 0;
            picSearch.TabStop = false;
            picSearch.Click += picSearch_Click;
            // 
            // txtKonum
            // 
            txtKonum.Location = new Point(26, 365);
            txtKonum.Name = "txtKonum";
            txtKonum.PlaceholderText = "Google Haritalarda Ara";
            txtKonum.Size = new Size(529, 39);
            txtKonum.TabIndex = 0;
            txtKonum.TextChanged += txtKonum_TextChanged;
            txtKonum.KeyDown += txtKonum_KeyDown;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Silver;
            pnlTop.Controls.Add(pictureBox2);
            pnlTop.Controls.Add(picMinimize);
            pnlTop.Controls.Add(picExit);
            pnlTop.Location = new Point(-7, -1);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1646, 44);
            pnlTop.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // picMinimize
            // 
            picMinimize.Image = (Image)resources.GetObject("picMinimize.Image");
            picMinimize.Location = new Point(1562, 2);
            picMinimize.Name = "picMinimize";
            picMinimize.Size = new Size(40, 40);
            picMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            picMinimize.TabIndex = 1;
            picMinimize.TabStop = false;
            picMinimize.Click += picMinimize_Click;
            // 
            // picExit
            // 
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(1603, 2);
            picExit.Name = "picExit";
            picExit.Size = new Size(40, 40);
            picExit.SizeMode = PictureBoxSizeMode.StretchImage;
            picExit.TabIndex = 0;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(gMapControl1);
            panel2.Location = new Point(632, 54);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 749);
            panel2.TabIndex = 1;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(0, 0);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(997, 749);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            gMapControl1.MouseDoubleClick += gMapControl1_MouseDoubleClick;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1641, 812);
            Controls.Add(pnlTop);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Anasayfa";
            Text = "Google Maps";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtKonum;
        private PictureBox picSearch;
        private Label lblKoordinat;
        private Label label1;
        private Panel pnlTop;
        private PictureBox picMinimize;
        private PictureBox picExit;
        private ListBox lstCoordinates;
        private PictureBox pictureBox2;
        private Panel panel2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private PictureBox pictureBox1;
    }
}