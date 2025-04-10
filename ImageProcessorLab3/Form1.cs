using System.Windows.Forms;

namespace ImageProcessorLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalBox.Image = null; // Clear the previous image
                Bitmap originalImage = new Bitmap(ofd.FileName);
                originalBox.Image = originalImage;
            }

            ofd.Dispose();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (originalBox.Image == null) { 
                MessageBox.Show("Please load an image first.");
                return;
            }

            Bitmap originalImage = (Bitmap)originalBox.Image.Clone();

            Bitmap img1 = new Bitmap(originalImage);
            Bitmap img2 = new Bitmap(originalImage);
            Bitmap img3 = new Bitmap(originalImage);
            Bitmap img4 = new Bitmap(originalImage);

            // Tymczasowe zmienne na wyniki przetwarzania
            Bitmap? grayscaleImage = null;
            Bitmap? negativeImage = null;
            Bitmap? thresholdImage = null;
            Bitmap? mirrorImage = null;

            // Przetwarzanie równoległe
            Parallel.Invoke(
                () => { grayscaleImage = ImageProcessor.Grayscale(img1); },
                () => { negativeImage = ImageProcessor.Negative(img2); },
                () => { thresholdImage = ImageProcessor.Threshold(img3, 128); },
                () => { mirrorImage = ImageProcessor.Mirror(img4); }
            );


            // Aktualizacja UI w wątku głównym

            originalBox.Image?.Dispose(); // Dispose the original image to free up resources
            grayscaleBox.Image?.Dispose();
            negativeBox.Image?.Dispose();
            thresholdBox.Image?.Dispose();
            mirrorBox.Image?.Dispose();

            originalBox.Image = originalImage;
            grayscaleBox.Image = grayscaleImage;
            negativeBox.Image = negativeImage;
            thresholdBox.Image = thresholdImage;
            mirrorBox.Image = mirrorImage;
        }
    }
}
