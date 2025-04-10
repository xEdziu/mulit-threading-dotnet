using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessorLab3
{
    public static class ImageProcessor
    {
        public static Bitmap Grayscale(Bitmap input)
        {
            Bitmap result = new Bitmap(input.Width, input.Height);
            for (int y = 0; y < input.Height; y++)
                for (int x = 0; x < input.Width; x++)
                {
                    Color pixel = input.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    result.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return result;
        }

        public static Bitmap Negative(Bitmap input)
        {
            Bitmap result = new Bitmap(input.Width, input.Height);
            for (int y = 0; y < input.Height; y++)
                for (int x = 0; x < input.Width; x++)
                {
                    Color pixel = input.GetPixel(x, y);
                    result.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            return result;
        }

        public static Bitmap Threshold(Bitmap input, int threshold)
        {
            Bitmap result = new Bitmap(input.Width, input.Height);
            for (int y = 0; y < input.Height; y++)
                for (int x = 0; x < input.Width; x++)
                {
                    Color pixel = input.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    result.SetPixel(x, y, gray < threshold ? Color.Black : Color.White);
                }
            return result;
        }

        public static Bitmap Mirror(Bitmap input)
        {
            Bitmap result = new Bitmap(input.Width, input.Height);
            for (int y = 0; y < input.Height; y++)
                for (int x = 0; x < input.Width; x++)
                    result.SetPixel(input.Width - 1 - x, y, input.GetPixel(x, y));
            return result;
        }
    }
}
