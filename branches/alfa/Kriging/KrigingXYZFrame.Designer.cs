namespace Kriging
{
    partial class KrigingXYZFrame
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
            this.bExport = new System.Windows.Forms.Button();
            this.lExport = new System.Windows.Forms.Label();
            this.lImport = new System.Windows.Forms.Label();
            this.lImortR = new System.Windows.Forms.Label();
            this.lImortG = new System.Windows.Forms.Label();
            this.lImortB = new System.Windows.Forms.Label();
            this.tImportR = new System.Windows.Forms.TextBox();
            this.tImportG = new System.Windows.Forms.TextBox();
            this.tImportB = new System.Windows.Forms.TextBox();
            this.bImportR = new System.Windows.Forms.Button();
            this.bImportG = new System.Windows.Forms.Button();
            this.bImportB = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.ofdR = new System.Windows.Forms.OpenFileDialog();
            this.ofdG = new System.Windows.Forms.OpenFileDialog();
            this.ofdB = new System.Windows.Forms.OpenFileDialog();
            this.lExport2 = new System.Windows.Forms.Label();
            this.bExport2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(83, 58);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(75, 23);
            this.bExport.TabIndex = 0;
            this.bExport.Text = "Exportuj";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // lExport
            // 
            this.lExport.AutoSize = true;
            this.lExport.Location = new System.Drawing.Point(26, 25);
            this.lExport.Name = "lExport";
            this.lExport.Size = new System.Drawing.Size(177, 13);
            this.lExport.TabIndex = 1;
            this.lExport.Text = "Exportuj do formatu XYZ (Saga GIS)";
            // 
            // lImport
            // 
            this.lImport.AutoSize = true;
            this.lImport.Location = new System.Drawing.Point(37, 329);
            this.lImport.Name = "lImport";
            this.lImport.Size = new System.Drawing.Size(166, 13);
            this.lImport.TabIndex = 2;
            this.lImport.Text = "Imporuj z formatu XYZ (Saga GIS)";
            // 
            // lImortR
            // 
            this.lImortR.AutoSize = true;
            this.lImortR.Location = new System.Drawing.Point(12, 359);
            this.lImortR.Name = "lImortR";
            this.lImortR.Size = new System.Drawing.Size(18, 13);
            this.lImortR.TabIndex = 3;
            this.lImortR.Text = "R:";
            // 
            // lImortG
            // 
            this.lImortG.AutoSize = true;
            this.lImortG.Location = new System.Drawing.Point(12, 385);
            this.lImortG.Name = "lImortG";
            this.lImortG.Size = new System.Drawing.Size(18, 13);
            this.lImortG.TabIndex = 4;
            this.lImortG.Text = "G:";
            // 
            // lImortB
            // 
            this.lImortB.AutoSize = true;
            this.lImortB.Location = new System.Drawing.Point(13, 411);
            this.lImortB.Name = "lImortB";
            this.lImortB.Size = new System.Drawing.Size(17, 13);
            this.lImortB.TabIndex = 5;
            this.lImortB.Text = "B:";
            // 
            // tImportR
            // 
            this.tImportR.Location = new System.Drawing.Point(29, 356);
            this.tImportR.Name = "tImportR";
            this.tImportR.Size = new System.Drawing.Size(174, 20);
            this.tImportR.TabIndex = 6;
            // 
            // tImportG
            // 
            this.tImportG.Location = new System.Drawing.Point(29, 382);
            this.tImportG.Name = "tImportG";
            this.tImportG.Size = new System.Drawing.Size(174, 20);
            this.tImportG.TabIndex = 7;
            // 
            // tImportB
            // 
            this.tImportB.Location = new System.Drawing.Point(29, 408);
            this.tImportB.Name = "tImportB";
            this.tImportB.Size = new System.Drawing.Size(174, 20);
            this.tImportB.TabIndex = 8;
            // 
            // bImportR
            // 
            this.bImportR.Location = new System.Drawing.Point(198, 354);
            this.bImportR.Name = "bImportR";
            this.bImportR.Size = new System.Drawing.Size(24, 23);
            this.bImportR.TabIndex = 9;
            this.bImportR.Text = "...";
            this.bImportR.UseVisualStyleBackColor = true;
            this.bImportR.Click += new System.EventHandler(this.bImportR_Click);
            // 
            // bImportG
            // 
            this.bImportG.Location = new System.Drawing.Point(198, 380);
            this.bImportG.Name = "bImportG";
            this.bImportG.Size = new System.Drawing.Size(24, 23);
            this.bImportG.TabIndex = 10;
            this.bImportG.Text = "...";
            this.bImportG.UseVisualStyleBackColor = true;
            this.bImportG.Click += new System.EventHandler(this.bImportG_Click);
            // 
            // bImportB
            // 
            this.bImportB.Location = new System.Drawing.Point(198, 406);
            this.bImportB.Name = "bImportB";
            this.bImportB.Size = new System.Drawing.Size(24, 23);
            this.bImportB.TabIndex = 11;
            this.bImportB.Text = "...";
            this.bImportB.UseVisualStyleBackColor = true;
            this.bImportB.Click += new System.EventHandler(this.bImportB_Click);
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(83, 448);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(75, 23);
            this.bImport.TabIndex = 12;
            this.bImport.Text = "Importuj";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // ofdR
            // 
            this.ofdR.FileName = "openFileDialog1";
            // 
            // ofdG
            // 
            this.ofdG.FileName = "openFileDialog1";
            // 
            // ofdB
            // 
            this.ofdB.FileName = "openFileDialog1";
            // 
            // lExport2
            // 
            this.lExport2.AutoSize = true;
            this.lExport2.Location = new System.Drawing.Point(26, 107);
            this.lExport2.Name = "lExport2";
            this.lExport2.Size = new System.Drawing.Size(86, 13);
            this.lExport2.TabIndex = 13;
            this.lExport2.Text = "Exportuj do gridu";
            // 
            // bExport2
            // 
            this.bExport2.Location = new System.Drawing.Point(83, 139);
            this.bExport2.Name = "bExport2";
            this.bExport2.Size = new System.Drawing.Size(75, 23);
            this.bExport2.TabIndex = 14;
            this.bExport2.Text = "Exportuj";
            this.bExport2.UseVisualStyleBackColor = true;
            this.bExport2.Click += new System.EventHandler(this.bExport2_Click);
            // 
            // KrigingXYZFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 492);
            this.Controls.Add(this.bExport2);
            this.Controls.Add(this.lExport2);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.bImportB);
            this.Controls.Add(this.bImportG);
            this.Controls.Add(this.bImportR);
            this.Controls.Add(this.tImportB);
            this.Controls.Add(this.tImportG);
            this.Controls.Add(this.tImportR);
            this.Controls.Add(this.lImortB);
            this.Controls.Add(this.lImortG);
            this.Controls.Add(this.lImortR);
            this.Controls.Add(this.lImport);
            this.Controls.Add(this.lExport);
            this.Controls.Add(this.bExport);
            this.Name = "KrigingXYZFrame";
            this.Text = "KrikingXYZFrame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Label lExport;
        private System.Windows.Forms.Label lImport;
        private System.Windows.Forms.Label lImortR;
        private System.Windows.Forms.Label lImortG;
        private System.Windows.Forms.Label lImortB;
        private System.Windows.Forms.TextBox tImportR;
        private System.Windows.Forms.TextBox tImportG;
        private System.Windows.Forms.TextBox tImportB;
        private System.Windows.Forms.Button bImportR;
        private System.Windows.Forms.Button bImportG;
        private System.Windows.Forms.Button bImportB;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.OpenFileDialog ofdR;
        private System.Windows.Forms.OpenFileDialog ofdG;
        private System.Windows.Forms.OpenFileDialog ofdB;
        private System.Windows.Forms.Label lExport2;
        private System.Windows.Forms.Button bExport2;
    }
}