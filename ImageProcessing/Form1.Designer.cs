namespace ImageProcessing
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homogenityEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderedDitheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdBinarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCbCrFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCbCrLinearCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSLFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastAdjustingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessAdjustingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturationAdjustingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueModifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelesLinearCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.textureToolStripMenuItem,
            this.jitterToolStripMenuItem,
            this.sobelEdgeDetectorToolStripMenuItem,
            this.homogenityEdgeDetectorToolStripMenuItem,
            this.differenceEdgeDetectorToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.convolutionToolStripMenuItem,
            this.orderedDitheringToolStripMenuItem,
            this.fToolStripMenuItem,
            this.thresholdBinarizationToolStripMenuItem,
            this.yCbCrFilteringToolStripMenuItem,
            this.yCbCrLinearCorrectionToolStripMenuItem,
            this.hSLFilteringToolStripMenuItem,
            this.contrastAdjustingToolStripMenuItem,
            this.brightnessAdjustingToolStripMenuItem,
            this.saturationAdjustingToolStripMenuItem,
            this.hueModifierToolStripMenuItem,
            this.levelesLinearCorrectionToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.graToolStripMenuItem.Text = "Grayscale";
            this.graToolStripMenuItem.Click += new System.EventHandler(this.graToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // textureToolStripMenuItem
            // 
            this.textureToolStripMenuItem.Name = "textureToolStripMenuItem";
            this.textureToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.textureToolStripMenuItem.Text = "Oil Painting";
            this.textureToolStripMenuItem.Click += new System.EventHandler(this.textureToolStripMenuItem_Click);
            // 
            // jitterToolStripMenuItem
            // 
            this.jitterToolStripMenuItem.Name = "jitterToolStripMenuItem";
            this.jitterToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.jitterToolStripMenuItem.Text = "Jitter";
            this.jitterToolStripMenuItem.Click += new System.EventHandler(this.jitterToolStripMenuItem_Click);
            // 
            // sobelEdgeDetectorToolStripMenuItem
            // 
            this.sobelEdgeDetectorToolStripMenuItem.Name = "sobelEdgeDetectorToolStripMenuItem";
            this.sobelEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.sobelEdgeDetectorToolStripMenuItem.Text = "Sobel Edge Detector";
            this.sobelEdgeDetectorToolStripMenuItem.Click += new System.EventHandler(this.sobelEdgeDetectorToolStripMenuItem_Click);
            // 
            // homogenityEdgeDetectorToolStripMenuItem
            // 
            this.homogenityEdgeDetectorToolStripMenuItem.Name = "homogenityEdgeDetectorToolStripMenuItem";
            this.homogenityEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.homogenityEdgeDetectorToolStripMenuItem.Text = "Homogenity Edge Detector";
            this.homogenityEdgeDetectorToolStripMenuItem.Click += new System.EventHandler(this.homogenityEdgeDetectorToolStripMenuItem_Click);
            // 
            // differenceEdgeDetectorToolStripMenuItem
            // 
            this.differenceEdgeDetectorToolStripMenuItem.Name = "differenceEdgeDetectorToolStripMenuItem";
            this.differenceEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.differenceEdgeDetectorToolStripMenuItem.Text = "Difference Edge Detector";
            this.differenceEdgeDetectorToolStripMenuItem.Click += new System.EventHandler(this.differenceEdgeDetectorToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.convolutionToolStripMenuItem.Text = "Rotate Channel";
            this.convolutionToolStripMenuItem.Click += new System.EventHandler(this.convolutionToolStripMenuItem_Click);
            // 
            // orderedDitheringToolStripMenuItem
            // 
            this.orderedDitheringToolStripMenuItem.Name = "orderedDitheringToolStripMenuItem";
            this.orderedDitheringToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.orderedDitheringToolStripMenuItem.Text = "Ordered dithering";
            this.orderedDitheringToolStripMenuItem.Click += new System.EventHandler(this.orderedDitheringToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.fToolStripMenuItem.Text = "Floyd-Steinberg dithering";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // thresholdBinarizationToolStripMenuItem
            // 
            this.thresholdBinarizationToolStripMenuItem.Name = "thresholdBinarizationToolStripMenuItem";
            this.thresholdBinarizationToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thresholdBinarizationToolStripMenuItem.Text = "Threshold binarization";
            this.thresholdBinarizationToolStripMenuItem.Click += new System.EventHandler(this.thresholdBinarizationToolStripMenuItem_Click);
            // 
            // yCbCrFilteringToolStripMenuItem
            // 
            this.yCbCrFilteringToolStripMenuItem.Name = "yCbCrFilteringToolStripMenuItem";
            this.yCbCrFilteringToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.yCbCrFilteringToolStripMenuItem.Text = "YCbCr Filtering";
            this.yCbCrFilteringToolStripMenuItem.Click += new System.EventHandler(this.yCbCrFilteringToolStripMenuItem_Click);
            // 
            // yCbCrLinearCorrectionToolStripMenuItem
            // 
            this.yCbCrLinearCorrectionToolStripMenuItem.Name = "yCbCrLinearCorrectionToolStripMenuItem";
            this.yCbCrLinearCorrectionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.yCbCrLinearCorrectionToolStripMenuItem.Text = "YCbCr linear correction";
            this.yCbCrLinearCorrectionToolStripMenuItem.Click += new System.EventHandler(this.yCbCrLinearCorrectionToolStripMenuItem_Click);
            // 
            // hSLFilteringToolStripMenuItem
            // 
            this.hSLFilteringToolStripMenuItem.Name = "hSLFilteringToolStripMenuItem";
            this.hSLFilteringToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.hSLFilteringToolStripMenuItem.Text = "HSL filtering";
            this.hSLFilteringToolStripMenuItem.Click += new System.EventHandler(this.hSLFilteringToolStripMenuItem_Click);
            // 
            // contrastAdjustingToolStripMenuItem
            // 
            this.contrastAdjustingToolStripMenuItem.Name = "contrastAdjustingToolStripMenuItem";
            this.contrastAdjustingToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.contrastAdjustingToolStripMenuItem.Text = "Contrast Adjusting";
            this.contrastAdjustingToolStripMenuItem.Click += new System.EventHandler(this.contrastAdjustingToolStripMenuItem_Click);
            // 
            // brightnessAdjustingToolStripMenuItem
            // 
            this.brightnessAdjustingToolStripMenuItem.Name = "brightnessAdjustingToolStripMenuItem";
            this.brightnessAdjustingToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.brightnessAdjustingToolStripMenuItem.Text = "Brightness Adjusting";
            this.brightnessAdjustingToolStripMenuItem.Click += new System.EventHandler(this.brightnessAdjustingToolStripMenuItem_Click);
            // 
            // saturationAdjustingToolStripMenuItem
            // 
            this.saturationAdjustingToolStripMenuItem.Name = "saturationAdjustingToolStripMenuItem";
            this.saturationAdjustingToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saturationAdjustingToolStripMenuItem.Text = "Saturation Adjusting";
            this.saturationAdjustingToolStripMenuItem.Click += new System.EventHandler(this.saturationAdjustingToolStripMenuItem_Click);
            // 
            // hueModifierToolStripMenuItem
            // 
            this.hueModifierToolStripMenuItem.Name = "hueModifierToolStripMenuItem";
            this.hueModifierToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.hueModifierToolStripMenuItem.Text = "Hue Modifier";
            this.hueModifierToolStripMenuItem.Click += new System.EventHandler(this.hueModifierToolStripMenuItem_Click);
            // 
            // levelesLinearCorrectionToolStripMenuItem
            // 
            this.levelesLinearCorrectionToolStripMenuItem.Name = "levelesLinearCorrectionToolStripMenuItem";
            this.levelesLinearCorrectionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.levelesLinearCorrectionToolStripMenuItem.Text = "Leveles linear correction";
            this.levelesLinearCorrectionToolStripMenuItem.Click += new System.EventHandler(this.levelesLinearCorrectionToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "pic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homogenityEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differenceEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderedDitheringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdBinarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yCbCrFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yCbCrLinearCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSLFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastAdjustingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessAdjustingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saturationAdjustingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hueModifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelesLinearCorrectionToolStripMenuItem;
    }
}

