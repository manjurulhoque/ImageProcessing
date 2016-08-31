using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        private IFilter GrayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
        private IFilter sepiaFilter = new Sepia();
        private IFilter oilPainting = new OilPainting();
        private IFilter invertFilter = new Invert();
        IFilter jitterFilter = new Jitter();
        IFilter sobelEdgeDetector = new SobelEdgeDetector();
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(ofd.FileName);
                pictureBox1.Image = image;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        image.Save(sfd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void graToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = GrayscaleFilter.Apply(image);
            pictureBox1.Image = image;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = sepiaFilter.Apply(image);
            pictureBox1.Image = image;
        }

        private void textureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = oilPainting.Apply(image);
            pictureBox1.Image = image;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = invertFilter.Apply(image);
            pictureBox1.Image = image;
        }

        private void jitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = jitterFilter.Apply(image);
            pictureBox1.Image = image;
        }

        private void sobelEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = sobelEdgeDetector.Apply(image);
            pictureBox1.Image = image;
        }
        private IFilter homogenityEdgeDetector = new HomogenityEdgeDetector();
        private void homogenityEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = homogenityEdgeDetector.Apply(image);
            pictureBox1.Image = image;
        }
        private IFilter differenceEdgeDetector = new DifferenceEdgeDetector();
        private void differenceEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = differenceEdgeDetector.Apply(image);
            pictureBox1.Image = image;
        }
        private IFilter gaussianblur = new GaussianBlur();
        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = gaussianblur.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter sharpen = new Sharpen();
        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = sharpen.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter rotateChannel = new RotateChannels();
        private void convolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = rotateChannel.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter orderedDithering = new OrderedDithering();
        private void orderedDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = orderedDithering.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter floydsteinbergdithering = new FloydSteinbergDithering();
        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = floydsteinbergdithering.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter thresholdBinarization = new Threshold();
        private void thresholdBinarizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = thresholdBinarization.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter ycbcrFilter = new YCbCrFiltering();
        private void yCbCrFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = ycbcrFilter.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter yCbCrLinearFilter = new YCbCrLinear();
        private void yCbCrLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = yCbCrLinearFilter.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter hslFilter = new HSLFiltering();
        private void hSLFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = hslFilter.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter contrastFilter = new ContrastCorrection();
        private void contrastAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = contrastFilter.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter brightnessFilter = new BrightnessCorrection();
        private void brightnessAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = brightnessFilter.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter saturationFilter = new SaturationCorrection();
        private void saturationAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = saturationFilter.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter hueFilter = new HueModifier();
        private void hueModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = hueFilter.Apply(image);
            pictureBox1.Image = image;
        }
        IFilter levelsLinearFilter = new LevelsLinear();
        private void levelesLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = levelsLinearFilter.Apply(image);
            pictureBox1.Image = image;
        }
    }
}
