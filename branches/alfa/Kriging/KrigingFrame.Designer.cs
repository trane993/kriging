namespace Kriging
{
    partial class KrigingFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KrigingFrame));
            this.bDarkFrame = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.HistGraphR = new componentXtra.XYGraph();
            this.HistGraphG = new componentXtra.XYGraph();
            this.HistGraphB = new componentXtra.XYGraph();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.bExecute = new System.Windows.Forms.Button();
            this.bNoise = new System.Windows.Forms.Button();
            this.lRvalue = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.cBlockBar = new System.Windows.Forms.CheckBox();
            this.lGvalue = new System.Windows.Forms.Label();
            this.lBvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            this.SuspendLayout();
            // 
            // bDarkFrame
            // 
            resources.ApplyResources(this.bDarkFrame, "bDarkFrame");
            this.bDarkFrame.Name = "bDarkFrame";
            this.bDarkFrame.UseVisualStyleBackColor = true;
            this.bDarkFrame.Click += new System.EventHandler(this.bDarkFrame_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // HistGraphR
            // 
            this.HistGraphR.BackColor = System.Drawing.Color.White;
            this.HistGraphR.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.HistGraphR, "HistGraphR");
            this.HistGraphR.Name = "HistGraphR";
            this.HistGraphR.XtraAutoScale = true;
            this.HistGraphR.XtraClassicLabels = false;
            this.HistGraphR.XtraFrame = false;
            this.HistGraphR.XtraLabelX = "";
            this.HistGraphR.XtraLabelY = "";
            this.HistGraphR.XtraLogX = false;
            this.HistGraphR.XtraLogY = false;
            this.HistGraphR.XtraMinLeftMargin = 0;
            this.HistGraphR.XtraSelectPoint = false;
            this.HistGraphR.XtraShowGrid = false;
            this.HistGraphR.XtraShowLegend = false;
            this.HistGraphR.XtraTitle = "";
            this.HistGraphR.XtraUpdateCursor = true;
            this.HistGraphR.XtraXdigits = 0;
            this.HistGraphR.XtraXmax = 260F;
            this.HistGraphR.XtraXmin = 0F;
            this.HistGraphR.XtraXstep = 0F;
            this.HistGraphR.XtraYdigits = 0;
            this.HistGraphR.XtraYmax = 1000F;
            this.HistGraphR.XtraYmin = 0F;
            this.HistGraphR.XtraYstep = 0F;
            // 
            // HistGraphG
            // 
            this.HistGraphG.BackColor = System.Drawing.Color.White;
            this.HistGraphG.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.HistGraphG, "HistGraphG");
            this.HistGraphG.Name = "HistGraphG";
            this.HistGraphG.XtraAutoScale = true;
            this.HistGraphG.XtraClassicLabels = false;
            this.HistGraphG.XtraFrame = false;
            this.HistGraphG.XtraLabelX = "";
            this.HistGraphG.XtraLabelY = "";
            this.HistGraphG.XtraLogX = false;
            this.HistGraphG.XtraLogY = false;
            this.HistGraphG.XtraMinLeftMargin = 0;
            this.HistGraphG.XtraSelectPoint = false;
            this.HistGraphG.XtraShowGrid = false;
            this.HistGraphG.XtraShowLegend = false;
            this.HistGraphG.XtraTitle = "";
            this.HistGraphG.XtraUpdateCursor = true;
            this.HistGraphG.XtraXdigits = 0;
            this.HistGraphG.XtraXmax = 260F;
            this.HistGraphG.XtraXmin = 0F;
            this.HistGraphG.XtraXstep = 0F;
            this.HistGraphG.XtraYdigits = 0;
            this.HistGraphG.XtraYmax = 1000F;
            this.HistGraphG.XtraYmin = 0F;
            this.HistGraphG.XtraYstep = 0F;
            // 
            // HistGraphB
            // 
            this.HistGraphB.BackColor = System.Drawing.Color.White;
            this.HistGraphB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.HistGraphB, "HistGraphB");
            this.HistGraphB.Name = "HistGraphB";
            this.HistGraphB.XtraAutoScale = true;
            this.HistGraphB.XtraClassicLabels = false;
            this.HistGraphB.XtraFrame = false;
            this.HistGraphB.XtraLabelX = "";
            this.HistGraphB.XtraLabelY = "";
            this.HistGraphB.XtraLogX = false;
            this.HistGraphB.XtraLogY = false;
            this.HistGraphB.XtraMinLeftMargin = 0;
            this.HistGraphB.XtraSelectPoint = false;
            this.HistGraphB.XtraShowGrid = false;
            this.HistGraphB.XtraShowLegend = false;
            this.HistGraphB.XtraTitle = "";
            this.HistGraphB.XtraUpdateCursor = true;
            this.HistGraphB.XtraXdigits = 0;
            this.HistGraphB.XtraXmax = 260F;
            this.HistGraphB.XtraXmin = 0F;
            this.HistGraphB.XtraXstep = 0F;
            this.HistGraphB.XtraYdigits = 0;
            this.HistGraphB.XtraYmax = 1000F;
            this.HistGraphB.XtraYmin = 0F;
            this.HistGraphB.XtraYstep = 0F;
            this.HistGraphB.Load += new System.EventHandler(this.HistGraphB_Load);
            // 
            // trackBarR
            // 
            this.trackBarR.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.trackBarR, "trackBarR");
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.TickFrequency = 10;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarG
            // 
            resources.ApplyResources(this.trackBarG, "trackBarG");
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.TickFrequency = 10;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // trackBarB
            // 
            resources.ApplyResources(this.trackBarB, "trackBarB");
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.TickFrequency = 10;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // bExecute
            // 
            resources.ApplyResources(this.bExecute, "bExecute");
            this.bExecute.Name = "bExecute";
            this.bExecute.UseVisualStyleBackColor = true;
            this.bExecute.Click += new System.EventHandler(this.bxecute_Click);
            // 
            // bNoise
            // 
            resources.ApplyResources(this.bNoise, "bNoise");
            this.bNoise.Name = "bNoise";
            this.bNoise.UseVisualStyleBackColor = true;
            this.bNoise.Click += new System.EventHandler(this.bNoise_Click);
            // 
            // lRvalue
            // 
            resources.ApplyResources(this.lRvalue, "lRvalue");
            this.lRvalue.Name = "lRvalue";
            // 
            // lTitle
            // 
            resources.ApplyResources(this.lTitle, "lTitle");
            this.lTitle.Name = "lTitle";
            // 
            // cBlockBar
            // 
            resources.ApplyResources(this.cBlockBar, "cBlockBar");
            this.cBlockBar.Checked = true;
            this.cBlockBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBlockBar.Name = "cBlockBar";
            this.cBlockBar.UseVisualStyleBackColor = true;
            // 
            // lGvalue
            // 
            resources.ApplyResources(this.lGvalue, "lGvalue");
            this.lGvalue.Name = "lGvalue";
            // 
            // lBvalue
            // 
            resources.ApplyResources(this.lBvalue, "lBvalue");
            this.lBvalue.Name = "lBvalue";
            // 
            // KrikingFrame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lBvalue);
            this.Controls.Add(this.lGvalue);
            this.Controls.Add(this.cBlockBar);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.lRvalue);
            this.Controls.Add(this.bNoise);
            this.Controls.Add(this.bExecute);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.HistGraphB);
            this.Controls.Add(this.HistGraphG);
            this.Controls.Add(this.HistGraphR);
            this.Controls.Add(this.bDarkFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KrikingFrame";
            this.Load += new System.EventHandler(this.KrikingFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDarkFrame;
        private System.Windows.Forms.OpenFileDialog ofd;
        private componentXtra.XYGraph HistGraphR;
        private componentXtra.XYGraph HistGraphG;
        private componentXtra.XYGraph HistGraphB;
        public System.Windows.Forms.TrackBar trackBarR;
        public System.Windows.Forms.TrackBar trackBarG;
        public System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.Button bExecute;
        private System.Windows.Forms.Button bNoise;
        private System.Windows.Forms.Label lRvalue;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.CheckBox cBlockBar;
        private System.Windows.Forms.Label lGvalue;
        private System.Windows.Forms.Label lBvalue;
    }
}