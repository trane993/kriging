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
using System.Drawing.Drawing2D;

namespace Kriging
{
    public partial class KrikingFrame : Form
    {
        MainForm mForm = null;
        
        public KrikingFrame()
        {
            InitializeComponent();
        }

        public KrikingFrame(MainForm mainForm)
        {
            InitializeComponent();
            mForm = mainForm;
        }

        // The FreeImageBitmap this sample will work with.
        FreeImageBitmap bitmap = null;
        FreeImageBitmap smallbitmap = null;

        // Replaces the current bitmap with the given one.
        private void ReplaceBitmap(FreeImageBitmap newBitmap)
        {
            // Checks whether the bitmap is usable
            if (newBitmap == null || newBitmap.IsDisposed)
            {
                MessageBox.Show(
                    "Nispodziewany błąd.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // Check whether the image type of the new bitmap is 'FIT_BITMAP'.
            // If not convert to 'FIT_BITMAP'.
            if (newBitmap.ImageType != FREE_IMAGE_TYPE.FIT_BITMAP)
            {
                if (!newBitmap.ConvertType(FREE_IMAGE_TYPE.FIT_BITMAP, true))
                {
                    MessageBox.Show(
                        "Błąd konwersji bitmapy do standardowego typu.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            // Dispose the old bitmap only in case it exists and
            // the old instance is another than the new one.
            if ((bitmap != null) && !object.ReferenceEquals(bitmap, newBitmap))
            {
                bitmap.Dispose();
            }

            if ((smallbitmap != null) && !object.ReferenceEquals(smallbitmap, bitmap))
            {
                smallbitmap.Dispose();
            }

            bitmap = newBitmap;
            smallbitmap = bitmap;
            smallbitmap.Rescale(mForm.smallbitmap.Width, mForm.smallbitmap.Height, FREE_IMAGE_FILTER.FILTER_BICUBIC);
            
            UpdateBitmapInformations();
        }

        // Get bitmap properties and display them in the gui.
        private void UpdateBitmapInformations()
        {
            if (Bitmap)
            {                
                // Histograms
                HistGraphR.ClearGraphs();
                int[] histR = new int[256];
                bitmap.GetHistogram(FREE_IMAGE_COLOR_CHANNEL.FICC_RED, out histR);
                HistGraphR.AddGraph("R", DashStyle.Solid, Color.Red, 1, false);
                for (int i = 0; i < histR.Length; i++)
                    HistGraphR.AddValue(0, (float)i, (float)histR[i]);
                HistGraphR.DrawAll();

                HistGraphG.ClearGraphs();
                int[] histG = new int[256];
                bitmap.GetHistogram(FREE_IMAGE_COLOR_CHANNEL.FICC_GREEN, out histG);
                HistGraphG.AddGraph("G", DashStyle.Solid, Color.Green, 1, false);
                for (int i = 0; i < histG.Length; i++)
                    HistGraphG.AddValue(0, (float)i, (float)histG[i]);
                HistGraphG.DrawAll();

                HistGraphB.ClearGraphs();
                int[] histB = new int[256];
                bitmap.GetHistogram(FREE_IMAGE_COLOR_CHANNEL.FICC_BLUE, out histB);
                HistGraphB.AddGraph("B", DashStyle.Solid, Color.Blue, 1, false);
                for (int i = 0; i < histR.Length; i++)
                    HistGraphB.AddValue(0, (float)i, (float)histB[i]);
                HistGraphB.DrawAll();
            }
            else
            {
                // Reset all values
                
            }
        }

        // Returns true in case the variable 'bitmap'
        // is set and not disposed.
        private bool Bitmap
        {
            get { return ((bitmap != null) && (!bitmap.IsDisposed)); }
        }

        private void bDarkFrame_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.UseWaitCursor = true;
                    FreeImageBitmap fib;
                    // Load the file using autodetection
                    fib = new FreeImageBitmap(ofd.FileName);
                    // Rescale the image so that it fits the picturebox
                    // Get the plugin that was used to load the bitmap
                    FreeImagePlugin plug = PluginRepository.Plugin(fib.ImageFormat);
                    // Replace the existing bitmap with the new one
                    ReplaceBitmap(fib);
                    bNoise.Enabled = true;
                    bExecute.Enabled = true;
                    this.UseWaitCursor = false;
                }
                catch
                {
                }
            }
        }

        private void KrikingFrame_Load(object sender, EventArgs e)
        {
            

        }

        private void bxecute_Click(object sender, EventArgs e)
        {
            MessageBox.Show("W trakcie budowy :)");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (cBlockBar.Checked)
            {
                trackBarG.Value = trackBarR.Value;
                lGvalue.Text = trackBarG.Value.ToString();
                trackBarB.Value = trackBarR.Value;
                lBvalue.Text = trackBarB.Value.ToString();
            }
            lRvalue.Text = trackBarR.Value.ToString();

        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            if (cBlockBar.Checked)
            {
                trackBarR.Value = trackBarG.Value;
                lRvalue.Text = trackBarR.Value.ToString();
                trackBarB.Value = trackBarG.Value;
                lBvalue.Text = trackBarB.Value.ToString();
            }
            lGvalue.Text = trackBarG.Value.ToString();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            if (cBlockBar.Checked)
            {
                trackBarR.Value = trackBarB.Value;
                lRvalue.Text = trackBarR.Value.ToString();
                trackBarG.Value = trackBarB.Value;
                lGvalue.Text = trackBarG.Value.ToString();
            }
            lBvalue.Text = trackBarB.Value.ToString();
        }

        private void HistGraphB_Load(object sender, EventArgs e)
        {
            
        }

        private void bNoise_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < smallbitmap.Width; i++)
            {
                for (int j = 0; j < smallbitmap.Height; j++)
                {
                    if (smallbitmap.GetPixel(i, j).R > trackBarR.Value)
                        mForm.smallbitmap.SetPixel(i, j, Color.Red);
                    if (smallbitmap.GetPixel(i, j).G > trackBarG.Value)
                        mForm.smallbitmap.SetPixel(i, j, Color.Red);
                    if (smallbitmap.GetPixel(i, j).B > trackBarB.Value)
                        mForm.smallbitmap.SetPixel(i, j, Color.Red);
                }
            }

              

            mForm.pictureBoxRefresh();
        }

        
    }
}
