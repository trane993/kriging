using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FreeImageAPI;
using FreeImageAPI.Metadata;
using FreeImageAPI.Plugins;
using System.IO;

namespace Kriging
{
    public partial class KrigingXYZFrame : Form
    {
        MainForm mForm = null;
        KrigingFrame kFrame = null;

        public KrigingXYZFrame()
        {
            InitializeComponent();
        }

        public KrigingXYZFrame(MainForm mainForm, KrigingFrame krigingFrame)
        {
            InitializeComponent();
            mForm = mainForm;
            kFrame = krigingFrame;
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            StreamWriter writerR = new StreamWriter(mForm.ofd.FileName + "_R.xyz", false);
            StreamWriter writerG = new StreamWriter(mForm.ofd.FileName + "_G.xyz", false);
            StreamWriter writerB = new StreamWriter(mForm.ofd.FileName + "_B.xyz", false);

            writerR.WriteLine("\"X\"\t\"Y\"\t\"" + mForm.ofd.FileName + " - Red\"");
            writerG.WriteLine("\"X\"\t\"Y\"\t\"" + mForm.ofd.FileName + " - Green\"");
            writerB.WriteLine("\"X\"\t\"Y\"\t\"" + mForm.ofd.FileName + " - Blue\"");

            this.UseWaitCursor = true;
            for (int i = 0; i < kFrame.smallbitmap.Width; i++)
            {
                for (int j = 0; j < kFrame.smallbitmap.Height; j++)
                {
                    if (kFrame.smallbitmap.GetPixel(i, j).R <= kFrame.trackBarR.Value)
                        writerR.WriteLine(i + "\t" + j + "\t" + mForm.smallbitmap.GetPixel(i, j).R + ".0");
                    if (kFrame.smallbitmap.GetPixel(i, j).G <= kFrame.trackBarG.Value)
                        writerG.WriteLine(i + "\t" + j + "\t" + mForm.smallbitmap.GetPixel(i, j).G + ".0");
                    if (kFrame.smallbitmap.GetPixel(i, j).B <= kFrame.trackBarB.Value)
                        writerB.WriteLine(i + "\t" + j + "\t" + mForm.smallbitmap.GetPixel(i, j).B + ".0");
                }
            }
            this.UseWaitCursor = false;

            writerR.Close();
            writerG.Close();
            writerB.Close();
        }

        private void bImportR_Click(object sender, EventArgs e)
        {
            if (ofdR.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.UseWaitCursor = true;
                    tImportR.Text = ofdR.FileName;
                    this.UseWaitCursor = false;
                }
                catch
                {
                }
            }
        }

        private void bImportG_Click(object sender, EventArgs e)
        {
            if (ofdG.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.UseWaitCursor = true;
                    tImportG.Text = ofdG.FileName;
                    this.UseWaitCursor = false;
                }
                catch
                {
                }
            }
        }

        private void bImportB_Click(object sender, EventArgs e)
        {
            if (ofdB.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.UseWaitCursor = true;
                    tImportB.Text = ofdB.FileName;
                    this.UseWaitCursor = false;
                }
                catch
                {
                }
            }
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            StreamReader readerR = new StreamReader(ofdR.FileName);
            StreamReader readerG = new StreamReader(ofdG.FileName);
            StreamReader readerB = new StreamReader(ofdB.FileName);

            this.UseWaitCursor = true;
            
            readerR.ReadLine();
            readerG.ReadLine();
            readerB.ReadLine();

            int height = mForm.smallbitmap.Height;
            int width = mForm.smallbitmap.Width;

            double[,] R = new double[width, height];
            double[,] G = new double[width, height];
            double[,] B = new double[width, height];

            do
            {
                String lineR = readerR.ReadLine();
                String[] wR = lineR.Split('\t');
                String lineG = readerG.ReadLine();
                String[] wG = lineG.Split('\t');
                String lineB = readerB.ReadLine();
                String[] wB = lineB.Split('\t');
                   
                double i = Double.Parse(wR[0].Replace(".", ","));
                double j = Double.Parse(wR[1].Replace(".", ","));

                R[Convert.ToInt32(i), Convert.ToInt32(j)] = Double.Parse(wR[2].Replace(".", ","));
                G[Convert.ToInt32(i), Convert.ToInt32(j)] = Double.Parse(wG[2].Replace(".", ","));
                B[Convert.ToInt32(i), Convert.ToInt32(j)] = Double.Parse(wB[0].Replace(".", ","));    
            }
            while (readerR.Peek() != -1);

            double maxR = R[0,0];
            double minR = R[0,0];
            double maxG = G[0,0];
            double minG = G[0,0];
            double maxB = B[0,0];
            double minB = B[0,0];

            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    if (i > 0 && j > 0)
                    {
                        maxR = R[i, j] > maxR ? R[i, j] : maxR;
                        maxG = G[i, j] > maxG ? G[i, j] : maxG;
                        maxB = B[i, j] > maxB ? B[i, j] : maxB;

                        minR = R[i, j] < minR ? R[i, j] : minR;
                        minG = G[i, j] < minG ? G[i, j] : minG;
                        minB = B[i, j] < minB ? B[i, j] : minB;
                    }                    
                }
            }

            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    R[i, j] = (R[i, j] - minR) / (maxR - minR) * 255.0;
                    G[i, j] = (G[i, j] - minG) / (maxG - minG) * 255.0;
                    B[i, j] = (B[i, j] - minB) / (maxB - minB) * 255.0;

                    Color color = Color.FromArgb(Convert.ToInt32(R[i,j]), Convert.ToInt32(G[i,j]), Convert.ToInt32(B[i,j]));
                    mForm.smallbitmap.SetPixel(i, j, color);
                }
            }

                readerR.Close();
                readerG.Close();
                readerB.Close();
                
            
            //smallbitmap.Save("foto.jpg");
            MessageBox.Show("ok");
            //mForm.smallbitmap = smallbitmap;
            mForm.pictureBoxRefresh();
            this.UseWaitCursor = false;
        }

        private void bExport2_Click(object sender, EventArgs e)
        {
            StreamWriter writerR = new StreamWriter(mForm.ofd.FileName + "-grid_R.txt", false);
            StreamWriter writerG = new StreamWriter(mForm.ofd.FileName + "-grid_G.txt", false);
            StreamWriter writerB = new StreamWriter(mForm.ofd.FileName + "-grid_B.txt", false);

            int sumRowR, sumRowG, sumRowB;
            int sumColR, sumColG, sumColB;

            this.UseWaitCursor = true;
            for (int i = 0; i < kFrame.smallbitmap.Width; i++)
            {
                sumRowR = 0;
                sumRowG = 0;
                sumRowB = 0;
                for (int j = 0; j < kFrame.smallbitmap.Height; j++)
                {
                    writerR.Write(mForm.smallbitmap.GetPixel(i, j).R + "\t");
                    writerG.Write(mForm.smallbitmap.GetPixel(i, j).R + "\t");
                    writerB.Write(mForm.smallbitmap.GetPixel(i, j).B + "\t");
                    sumRowR += mForm.smallbitmap.GetPixel(i, j).R;
                    sumRowG += mForm.smallbitmap.GetPixel(i, j).G;
                    sumRowB += mForm.smallbitmap.GetPixel(i, j).B;
                }
                writerR.Write(sumRowR + "\n");
                writerG.Write(sumRowG + "\n");
                writerB.Write(sumRowB + "\n");
            }

            for (int j = 0; j < kFrame.smallbitmap.Height; j++)
            {
                sumColR = 0;
                sumColG = 0;
                sumColB = 0;
                for (int i = 0; i < kFrame.smallbitmap.Width; i++)
                {
                    sumColR += mForm.smallbitmap.GetPixel(i, j).R;
                    sumColG += mForm.smallbitmap.GetPixel(i, j).G;
                    sumColB += mForm.smallbitmap.GetPixel(i, j).B;
                }
                writerR.Write(sumColR + "\t");
                writerG.Write(sumColG + "\t");
                writerB.Write(sumColB + "\t");
            }

            this.UseWaitCursor = false;

            writerR.Close();
            writerG.Close();
            writerB.Close();
        }
    }
}
