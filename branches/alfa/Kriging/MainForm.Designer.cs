namespace Kriging
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bLoadImage = new System.Windows.Forms.Button();
            this.bSaveImage = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lImageFormat = new System.Windows.Forms.Label();
            this.lComment = new System.Windows.Forms.Label();
            this.lWidth = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.lBpp = new System.Windows.Forms.Label();
            this.lColors = new System.Windows.Forms.Label();
            this.lMetadataCount = new System.Windows.Forms.Label();
            this.HistGraph = new componentXtra.XYGraph();
            this.bKriking = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 300);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // bLoadImage
            // 
            this.bLoadImage.Location = new System.Drawing.Point(443, 12);
            this.bLoadImage.Name = "bLoadImage";
            this.bLoadImage.Size = new System.Drawing.Size(96, 23);
            this.bLoadImage.TabIndex = 1;
            this.bLoadImage.Text = "Otwórz zdjęcie";
            this.bLoadImage.UseVisualStyleBackColor = true;
            this.bLoadImage.Click += new System.EventHandler(this.bLoadImage_Click);
            // 
            // bSaveImage
            // 
            this.bSaveImage.Enabled = false;
            this.bSaveImage.Location = new System.Drawing.Point(443, 70);
            this.bSaveImage.Name = "bSaveImage";
            this.bSaveImage.Size = new System.Drawing.Size(96, 23);
            this.bSaveImage.TabIndex = 2;
            this.bSaveImage.Text = "Zapisz zdjęcie";
            this.bSaveImage.UseVisualStyleBackColor = true;
            this.bSaveImage.Click += new System.EventHandler(this.bSaveImage_Click);
            // 
            // ofd
            // 
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // lImageFormat
            // 
            this.lImageFormat.AutoSize = true;
            this.lImageFormat.Location = new System.Drawing.Point(440, 347);
            this.lImageFormat.Name = "lImageFormat";
            this.lImageFormat.Size = new System.Drawing.Size(78, 13);
            this.lImageFormat.TabIndex = 3;
            this.lImageFormat.Text = "Format zdjęcia:";
            // 
            // lComment
            // 
            this.lComment.AutoSize = true;
            this.lComment.Location = new System.Drawing.Point(440, 360);
            this.lComment.Name = "lComment";
            this.lComment.Size = new System.Drawing.Size(111, 13);
            this.lComment.TabIndex = 4;
            this.lComment.Text = "Komentarz do zdjęcia:";
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(440, 292);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(60, 13);
            this.lWidth.TabIndex = 5;
            this.lWidth.Text = "Szerokość:";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(440, 305);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(60, 13);
            this.lHeight.TabIndex = 6;
            this.lHeight.Text = "Wysokość:";
            // 
            // lBpp
            // 
            this.lBpp.AutoSize = true;
            this.lBpp.Location = new System.Drawing.Point(554, 292);
            this.lBpp.Name = "lBpp";
            this.lBpp.Size = new System.Drawing.Size(29, 13);
            this.lBpp.TabIndex = 7;
            this.lBpp.Text = "Bpp:";
            // 
            // lColors
            // 
            this.lColors.AutoSize = true;
            this.lColors.Location = new System.Drawing.Point(554, 305);
            this.lColors.Name = "lColors";
            this.lColors.Size = new System.Drawing.Size(39, 13);
            this.lColors.TabIndex = 8;
            this.lColors.Text = "Kolory:";
            // 
            // lMetadataCount
            // 
            this.lMetadataCount.AutoSize = true;
            this.lMetadataCount.Location = new System.Drawing.Point(554, 318);
            this.lMetadataCount.Name = "lMetadataCount";
            this.lMetadataCount.Size = new System.Drawing.Size(58, 13);
            this.lMetadataCount.TabIndex = 9;
            this.lMetadataCount.Text = "Metadane:";
            // 
            // HistGraph
            // 
            this.HistGraph.BackColor = System.Drawing.Color.Transparent;
            this.HistGraph.Enabled = false;
            this.HistGraph.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.HistGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HistGraph.Location = new System.Drawing.Point(443, 155);
            this.HistGraph.Name = "HistGraph";
            this.HistGraph.Size = new System.Drawing.Size(196, 99);
            this.HistGraph.TabIndex = 10;
            this.HistGraph.Visible = false;
            this.HistGraph.XtraAutoScale = true;
            this.HistGraph.XtraClassicLabels = false;
            this.HistGraph.XtraFrame = false;
            this.HistGraph.XtraLabelX = "";
            this.HistGraph.XtraLabelY = "";
            this.HistGraph.XtraLogX = false;
            this.HistGraph.XtraLogY = false;
            this.HistGraph.XtraMinLeftMargin = 0;
            this.HistGraph.XtraSelectPoint = false;
            this.HistGraph.XtraShowGrid = false;
            this.HistGraph.XtraShowLegend = false;
            this.HistGraph.XtraTitle = "";
            this.HistGraph.XtraUpdateCursor = true;
            this.HistGraph.XtraXdigits = 0;
            this.HistGraph.XtraXmax = 260F;
            this.HistGraph.XtraXmin = 0F;
            this.HistGraph.XtraXstep = 65F;
            this.HistGraph.XtraYdigits = 0;
            this.HistGraph.XtraYmax = 0F;
            this.HistGraph.XtraYmin = 0F;
            this.HistGraph.XtraYstep = 0F;
            this.HistGraph.Load += new System.EventHandler(this.HistGraph_Load);
            // 
            // bKriking
            // 
            this.bKriking.Enabled = false;
            this.bKriking.Location = new System.Drawing.Point(443, 41);
            this.bKriking.Name = "bKriking";
            this.bKriking.Size = new System.Drawing.Size(96, 23);
            this.bKriking.TabIndex = 11;
            this.bKriking.Text = "Kriging";
            this.bKriking.UseVisualStyleBackColor = true;
            this.bKriking.Click += new System.EventHandler(this.bKriking_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 397);
            this.Controls.Add(this.bKriking);
            this.Controls.Add(this.HistGraph);
            this.Controls.Add(this.lMetadataCount);
            this.Controls.Add(this.lColors);
            this.Controls.Add(this.lBpp);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.lWidth);
            this.Controls.Add(this.lComment);
            this.Controls.Add(this.lImageFormat);
            this.Controls.Add(this.bSaveImage);
            this.Controls.Add(this.bLoadImage);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "MainFrom";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button bLoadImage;
        private System.Windows.Forms.Button bSaveImage;
        public System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lImageFormat;
        private System.Windows.Forms.Label lComment;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.Label lBpp;
        private System.Windows.Forms.Label lColors;
        private System.Windows.Forms.Label lMetadataCount;
        private componentXtra.XYGraph HistGraph;
        private System.Windows.Forms.Button bKriking;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

