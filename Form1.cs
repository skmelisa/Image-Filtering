using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalGoruntuIsleme
{
    public partial class Form1 : Form
    {
        private int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                displayImageInfo();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
       
            GenerateHistogram((Bitmap)pictureBox1.Image);
        }

        private void GenerateHistogram(Bitmap bmap)
        {
            int[] histogram = new int[256]; //her bir eleman, piksel yoğunluğunu(0 ile 255 arasında) temsil eder.

            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    Color c = bmap.GetPixel(i, j);
                    int gray = (c.R + c.G + c.B) / 3; 
                    histogram[gray]++; 
                }
            }

            int histHeight = 256;  //histogram görselleştirmesi
            Bitmap histImage = new Bitmap(256, histHeight);
            int max = histogram.Max();

            for (int i = 0; i < histogram.Length; i++)
            {
                int histValue = histogram[i] * histHeight / max;
                for (int j = 0; j < histValue; j++)
                {
                    histImage.SetPixel(i, histHeight - 1 - j, Color.Black); 
                }
            }

            pictureBox2.Image = histImage; 
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            ApplyThreshold((Bitmap)pictureBox1.Image, trackBar1.Value);
        }

        private void ApplyThreshold(Bitmap image, int threshold) //eşikleme işlemi
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int brightness = (int)(pixelColor.R * 0.299 + pixelColor.G * 0.587 + pixelColor.B * 0.114);
                    Color newColor = (brightness >= threshold) ? Color.White : Color.Black;
                    newImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = newImage;
        }

        private void displayImageInfo()
        {
            var temp = (Bitmap)pictureBox1.Image;
            int width = temp.Width;
            int height = temp.Height;
            int pixelCount = width * height;

            özellikler.Text = $"Width: {width}, Height: {height}, Pixel Count: {pixelCount}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConvertToBinary(((Bitmap)pictureBox1.Image));
        }

        private void ConvertToBinary(Bitmap original)
        {
            var temp = (Bitmap)pictureBox1.Image;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                    byte binaryColor = (gray > 128) ? (byte)255 : (byte)0; // 128 eşik değeri olarak kullanılıyor
                    bmap.SetPixel(i, j, Color.FromArgb(binaryColor, binaryColor, binaryColor));
                }
            }
            pictureBox2.Image = (Bitmap)bmap.Clone();

        }
        private void button5_Click(object sender, EventArgs e)
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                Bitmap embossed = emboss(image);
                pictureBox2.Image = embossed;
            }
            private Bitmap emboss(Bitmap image)
            {
                Bitmap embossed = new Bitmap(image.Width, image.Height);

                int[,] embossKernel = {
        { -2, -1, 0 },
        { -1, 1, 1 },
        { 0, 1, 2 }
    };

                int kernelSize = 3;
                int offset = kernelSize / 2;

                for (int x = offset; x < image.Width - offset; x++)
                {
                    for (int y = offset; y < image.Height - offset; y++)
                    {
                        int r = 0, g = 0, b = 0;

                        for (int i = 0; i < kernelSize; i++)
                        {
                            for (int j = 0; j < kernelSize; j++)
                            {
                                int pixelX = x + i - offset;
                                int pixelY = y + j - offset;

                                Color pixelColor = image.GetPixel(pixelX, pixelY);

                                r += pixelColor.R * embossKernel[i, j];
                                g += pixelColor.G * embossKernel[i, j];
                                b += pixelColor.B * embossKernel[i, j];
                            }
                        }

                        // Normalize the color values
                        r = Math.Min(255, Math.Max(0, r + 128));
                        g = Math.Min(255, Math.Max(0, g + 128));
                        b = Math.Min(255, Math.Max(0, b + 128));

                        embossed.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }

                return embossed;
            }

        private void button6_Click(object sender, EventArgs e)
        {
            sobel();
        }

        public void sobel()
        {
            var temp = (Bitmap)pictureBox1.Image;
            Bitmap bmap = (Bitmap)temp.Clone();

            int width = bmap.Width;
            int height = bmap.Height;

            int[,] gx = new int[,]
            {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };

            int[,] gy = new int[,]
            {
                { -1, -2, -1 },
                { 0, 0, 0 },
                { 1, 2, 1 }
            };

            Bitmap result = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int pixelX = (
                        (gx[0, 0] * bmap.GetPixel(x - 1, y - 1).R) + (gx[0, 1] * bmap.GetPixel(x, y - 1).R) + (gx[0, 2] * bmap.GetPixel(x + 1, y - 1).R) +
                        (gx[1, 0] * bmap.GetPixel(x - 1, y).R) + (gx[1, 1] * bmap.GetPixel(x, y).R) + (gx[1, 2] * bmap.GetPixel(x + 1, y).R) +
                        (gx[2, 0] * bmap.GetPixel(x - 1, y + 1).R) + (gx[2, 1] * bmap.GetPixel(x, y + 1).R) + (gx[2, 2] * bmap.GetPixel(x + 1, y + 1).R)
                    );

                    int pixelY = (
                        (gy[0, 0] * bmap.GetPixel(x - 1, y - 1).R) + (gy[0, 1] * bmap.GetPixel(x, y - 1).R) + (gy[0, 2] * bmap.GetPixel(x + 1, y - 1).R) +
                        (gy[1, 0] * bmap.GetPixel(x - 1, y).R) + (gy[1, 1] * bmap.GetPixel(x, y).R) + (gy[1, 2] * bmap.GetPixel(x + 1, y).R) +
                        (gy[2, 0] * bmap.GetPixel(x - 1, y + 1).R) + (gy[2, 1] * bmap.GetPixel(x, y + 1).R) + (gy[2, 2] * bmap.GetPixel(x + 1, y + 1).R)
                    );

                    int magnitude = (int)Math.Sqrt((pixelX * pixelX) + (pixelY * pixelY));
                    if (magnitude > 255) magnitude = 255;
                    if (magnitude < 0) magnitude = 0;

                    result.SetPixel(x, y, Color.FromArgb(magnitude, magnitude, magnitude));
                }
            }
            pictureBox2.Image = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                int redValue = int.Parse(textBoxRed.Text);
                int greenValue = int.Parse(textBoxGreen.Text);
                int blueValue = int.Parse(textBoxBlue.Text);

                
                Bitmap image = new Bitmap(pictureBox1.Image);
                Bitmap transformedImage = RGBDonustur(image, redValue, greenValue, blueValue);
                pictureBox2.Image = transformedImage;
            }

            private Bitmap RGBDonustur(Bitmap bmp, int redValue, int greenValue, int blueValue)
            {
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        Color pixel = bmp.GetPixel(j, i);

                        int newRed = Math.Min(255, Math.Max(0, pixel.R + redValue));
                        int newGreen = Math.Min(255, Math.Max(0, pixel.G + greenValue));
                        int newBlue = Math.Min(255, Math.Max(0, pixel.B + blueValue));

                        Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
                        bmp.SetPixel(j, i, newColor);
                    }
                }

                return bmp;
            }

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {

        }
        private Bitmap binaryYap(Bitmap image)
        {
            Bitmap gri = griYap(image);
            int temp = 0;
            int esik = 100; 
            Color renk;

            for (int i = 0; i < gri.Height - 1; i++)
            {
                for (int j = 0; j < gri.Width - 1; j++)
                {
                    temp = gri.GetPixel(j, i).R;

                    if (temp < esik)
                    {
                        renk = Color.FromArgb(0, 0, 0);
                        gri.SetPixel(j, i, renk);
                    }
                    else
                    {
                        renk = Color.FromArgb(255, 255, 255);
                        gri.SetPixel(j, i, renk);
                    }



                }
            }

            return gri;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap binaryImage = binaryYap(image); // İkili formata dönüştür
            Bitmap erodedImage = Erosion(binaryImage);
            pictureBox2.Image = erodedImage;
        }

        private Bitmap Erosion(Bitmap image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            int[,] structureElement =
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };

            int offset = structureElement.GetLength(0) / 2;

            for (int y = offset; y < image.Height - offset; y++)
            {
                for (int x = offset; x < image.Width - offset; x++)
                {
                    bool erode = false;
                    for (int i = -offset; i <= offset; i++)
                    {
                        for (int j = -offset; j <= offset; j++)
                        {
                            if (structureElement[i + offset, j + offset] == 1 &&
                                image.GetPixel(x + j, y + i).R == 0)
                            {
                                erode = true;
                                break;
                            }
                        }

                        if (erode) break;
                    }

                    result.SetPixel(x, y, erode ? Color.Black : Color.White);
                }
            }

            return result;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap binaryImage = binaryYap(image); // İkili formata dönüştür
            Bitmap dilatedImage = Dilation(binaryImage);
            pictureBox2.Image = dilatedImage;
        }
        private Bitmap griYap(Bitmap bmp)
        {

            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = (bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B) / 3;

                    Color renk;

                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j, i, renk);

                }
            }

            return bmp;
        }
        private Bitmap Dilation(Bitmap image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            int[,] structureElement =
            {
         { 1, 1, 1 },
         { 1, 1, 1 },
         { 1, 1, 1 }
     };

            int offset = structureElement.GetLength(0) / 2;

            for (int y = offset; y < image.Height - offset; y++)
            {
                for (int x = offset; x < image.Width - offset; x++)
                {
                    bool dilate = false;
                    for (int i = -offset; i <= offset; i++)
                    {
                        for (int j = -offset; j <= offset; j++)
                        {
                            if (structureElement[i + offset, j + offset] == 1 &&
                                image.GetPixel(x + j, y + i).R == 255)
                            {
                                dilate = true;
                                break;
                            }
                        }

                        if (dilate) break;
                    }

                    result.SetPixel(x, y, dilate ? Color.White : Color.Black);
                }
            }

            return result;

        }
    }
    }
    

    






    