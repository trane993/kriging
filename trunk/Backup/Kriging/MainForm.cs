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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
  

        // The FreeImageBitmap this sample will work with.
        public FreeImageBitmap bitmap = null;
        public FreeImageBitmap smallbitmap = null;

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
            // Dispose the picturebox's bitmap in case it exists.
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }

            // Set the new bitmap.
            bitmap = newBitmap;
            smallbitmap = bitmap;
            smallbitmap.Rescale(pictureBox.Width, pictureBox.Height, FREE_IMAGE_FILTER.FILTER_BICUBIC);
            pictureBox.Image = (Bitmap)(smallbitmap);

            // Update gui.
            UpdateBitmapInformations();
        }

        // Get bitmap properties and display them in the gui.
        private void UpdateBitmapInformations()
        {
            if (Bitmap)
            {
                // Get width
                lWidth.Text = String.Format("Szerokość: {0}", bitmap.Width);
                // Get Height
                lHeight.Text = String.Format("Wysokość: {0}", bitmap.Height);
                // Get color depth
                lBpp.Text = String.Format("Bpp: {0}", bitmap.ColorDepth);
                // Get number of metadata
                ImageMetadata mData = bitmap.Metadata;
                mData.HideEmptyModels = true;
                int mCnt = 0;
                foreach (MetadataModel model in mData.List)
                {
                    mCnt += model.Count;
                }
                lMetadataCount.Text = String.Format("Metadane: {0}", mCnt);
                // Get image comment
                lComment.Text = String.Format("Komentarz do zdjęcia: {0}", bitmap.Comment != null ? bitmap.Comment : String.Empty);
                // Get the number of real colors in the image
                lColors.Text = String.Format("Kolory: {0}", bitmap.UniqueColors);
                // Histogram
                HistGraph.ClearGraphs();
                                int[] histo = new int[256];
                bitmap.GetHistogram(FREE_IMAGE_COLOR_CHANNEL.FICC_RGB, out histo);
                HistGraph.AddGraph("RGB", DashStyle.Solid, Color.Black, 1, false);
                for (int i = 0; i < histo.Length; i++)
                    HistGraph.AddValue(0, (float)i, (float)histo[i]);
                HistGraph.DrawAll();                
            }
            else
            {
                // Reset all values
                lWidth.Text = String.Format("Szerokość: {0}", 0);
                lHeight.Text = String.Format("Wysokość: {0}", 0);
                lBpp.Text = String.Format("Bpp: {0}", 0);
                lMetadataCount.Text = String.Format("Metadane: {0}", 0);
                lComment.Text = String.Format("Komentarz do zdjęcia: {0}", String.Empty);
                lColors.Text = String.Format("Kolory: {0}", 0);
            }
        }

        // Returns true in case the variable 'bitmap'
        // is set and not disposed.
        private bool Bitmap
        {
            get { return ((bitmap != null) && (!bitmap.IsDisposed)); }
        }

        private void bLoadImage_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.UseWaitCursor = true;
                    // Load the file using autodetection
                    FreeImageBitmap fib;
                    fib = new FreeImageBitmap(ofd.FileName);
                    // Rescale the image so that it fits the picturebox
                    // Get the plugin that was used to load the bitmap
                    FreeImagePlugin plug = PluginRepository.Plugin(fib.ImageFormat);
                    lImageFormat.Text = String.Format("Format zdjęcia: {0}", plug.Format);
                    // Replace the existing bitmap with the new one
                    
                    ReplaceBitmap(fib);
                    HistGraph.Visible = true;
                    bSaveImage.Enabled = true;
                    bKriking.Enabled = true;
                    this.UseWaitCursor = false;
                }
                catch
                {
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bKriking_Click(object sender, EventArgs e)
        {
            KrikingFrame kFrame = new KrikingFrame(this);
            
            kFrame.ShowDialog();
            //kFrame.Location.X = 100;
        }

        private void HistGraph_Load(object sender, EventArgs e)
        {

        }

        public void pictureBoxRefresh()
        {
            pictureBox.Image = (Bitmap)(smallbitmap);
        }
    }
}
