namespace ImageProcessorLab3
{
    partial class Form1
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
            loadButton = new Button();
            filterButton = new Button();
            originalBox = new PictureBox();
            grayscaleBox = new PictureBox();
            negativeBox = new PictureBox();
            thresholdBox = new PictureBox();
            mirrorBox = new PictureBox();
            grayscaleLabel = new Label();
            negativeLabel = new Label();
            thresholdLabel = new Label();
            mirroLabel = new Label();
            originalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)originalBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grayscaleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negativeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thresholdBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mirrorBox).BeginInit();
            SuspendLayout();
            // 
            // loadButton
            // 
            loadButton.Location = new Point(152, 462);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(150, 50);
            loadButton.TabIndex = 0;
            loadButton.Text = "Wczytaj obraz";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(152, 518);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(150, 50);
            filterButton.TabIndex = 1;
            filterButton.Text = "Zastosuj filtry";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // originalBox
            // 
            originalBox.BorderStyle = BorderStyle.FixedSingle;
            originalBox.Location = new Point(90, 123);
            originalBox.Name = "originalBox";
            originalBox.Size = new Size(280, 280);
            originalBox.TabIndex = 2;
            originalBox.TabStop = false;
            // 
            // grayscaleBox
            // 
            grayscaleBox.BorderStyle = BorderStyle.FixedSingle;
            grayscaleBox.Location = new Point(493, 49);
            grayscaleBox.Name = "grayscaleBox";
            grayscaleBox.Size = new Size(280, 280);
            grayscaleBox.TabIndex = 3;
            grayscaleBox.TabStop = false;
            // 
            // negativeBox
            // 
            negativeBox.BorderStyle = BorderStyle.FixedSingle;
            negativeBox.Location = new Point(802, 49);
            negativeBox.Name = "negativeBox";
            negativeBox.Size = new Size(280, 280);
            negativeBox.TabIndex = 4;
            negativeBox.TabStop = false;
            // 
            // thresholdBox
            // 
            thresholdBox.BorderStyle = BorderStyle.FixedSingle;
            thresholdBox.Location = new Point(493, 369);
            thresholdBox.Name = "thresholdBox";
            thresholdBox.Size = new Size(280, 280);
            thresholdBox.TabIndex = 5;
            thresholdBox.TabStop = false;
            // 
            // mirrorBox
            // 
            mirrorBox.BorderStyle = BorderStyle.FixedSingle;
            mirrorBox.Location = new Point(802, 369);
            mirrorBox.Name = "mirrorBox";
            mirrorBox.Size = new Size(280, 280);
            mirrorBox.TabIndex = 6;
            mirrorBox.TabStop = false;
            // 
            // grayscaleLabel
            // 
            grayscaleLabel.AutoSize = true;
            grayscaleLabel.Location = new Point(606, 31);
            grayscaleLabel.Name = "grayscaleLabel";
            grayscaleLabel.Size = new Size(57, 15);
            grayscaleLabel.TabIndex = 7;
            grayscaleLabel.Text = "Grayscale";
            // 
            // negativeLabel
            // 
            negativeLabel.AutoSize = true;
            negativeLabel.Location = new Point(910, 31);
            negativeLabel.Name = "negativeLabel";
            negativeLabel.Size = new Size(54, 15);
            negativeLabel.TabIndex = 8;
            negativeLabel.Text = "Negative";
            // 
            // thresholdLabel
            // 
            thresholdLabel.AutoSize = true;
            thresholdLabel.Location = new Point(606, 351);
            thresholdLabel.Name = "thresholdLabel";
            thresholdLabel.Size = new Size(60, 15);
            thresholdLabel.TabIndex = 9;
            thresholdLabel.Text = "Threshold";
            // 
            // mirroLabel
            // 
            mirroLabel.AutoSize = true;
            mirroLabel.Location = new Point(924, 351);
            mirroLabel.Name = "mirroLabel";
            mirroLabel.Size = new Size(40, 15);
            mirroLabel.TabIndex = 10;
            mirroLabel.Text = "Mirror";
            // 
            // originalLabel
            // 
            originalLabel.AutoSize = true;
            originalLabel.Location = new Point(199, 105);
            originalLabel.Name = "originalLabel";
            originalLabel.Size = new Size(46, 15);
            originalLabel.TabIndex = 11;
            originalLabel.Text = "Orginal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 686);
            Controls.Add(originalLabel);
            Controls.Add(mirroLabel);
            Controls.Add(thresholdLabel);
            Controls.Add(negativeLabel);
            Controls.Add(grayscaleLabel);
            Controls.Add(mirrorBox);
            Controls.Add(thresholdBox);
            Controls.Add(negativeBox);
            Controls.Add(grayscaleBox);
            Controls.Add(originalBox);
            Controls.Add(filterButton);
            Controls.Add(loadButton);
            Name = "Form1";
            Text = "Image Filter App";
            ((System.ComponentModel.ISupportInitialize)originalBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)grayscaleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)negativeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)thresholdBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mirrorBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadButton;
        private Button filterButton;
        private PictureBox originalBox;
        private PictureBox grayscaleBox;
        private PictureBox negativeBox;
        private PictureBox thresholdBox;
        private PictureBox mirrorBox;
        private Label grayscaleLabel;
        private Label negativeLabel;
        private Label thresholdLabel;
        private Label mirroLabel;
        private Label originalLabel;
    }
}
