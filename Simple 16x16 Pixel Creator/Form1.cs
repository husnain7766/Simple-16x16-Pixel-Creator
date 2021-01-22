using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_16x16_Pixel_Creator
{
    public partial class Form1 : Form
    {
        private ImageList imageList = new ImageList();
        private Color[,] imageColors = new Color[16, 16];
        private List<Bitmap> listBitmaps = new List<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var listViewItem = ImageListView.Items.Add("");
            listViewItem.ImageKey = imageList.Images.Count.ToString();
            SaveButton.BackgroundImageLayout = ImageLayout.Stretch;
            PlaceImage();
            PlaceButtons();
            ReadFiles();
        }

        private void PlaceImage()
        {
            int startX = 10;
            int startY = 60;
            for (var i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    image[i, j] = new Button
                    {
                        Location = new System.Drawing.Point(startX, startY),
                        Size = new System.Drawing.Size(20, 20),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Purple,
                    };

                    image[i, j].Click += new EventHandler(this.ImageGridClick);
                    Controls.Add(image[i, j]);
                    startX += 20;
                }

                startX = 10;
                startY += 20;
            }
        }

        private void PlaceButtons()
        {
            int[] colors =
            {
                0, 0, 0, 128, 0, 0, 0, 128, 0, 128, 128, 0, 0, 0, 128, 128, 0, 128, 0, 128, 128, 192, 192, 192, 128,
                128, 128, 255, 0, 0, 0, 255, 0, 255, 255, 0, 0, 0, 255, 255, 0, 255, 0, 255, 255, 255, 255, 255, 0, 0,
                0, 0, 0, 95, 0, 0, 135, 0, 0, 175, 0, 0, 215, 0, 0, 255, 0, 95, 0, 0, 95, 95, 0, 95, 135, 0, 95, 175, 0,
                95, 215, 0, 95, 255, 0, 135, 0, 0, 135, 95, 0, 135, 135, 0, 135, 175, 0, 135, 215, 0, 135, 255, 0, 175,
                0, 0, 175, 95, 0, 175, 135, 0, 175, 175, 0, 175, 215, 0, 175, 255, 0, 215, 0, 0, 215, 95, 0, 215, 135,
                0, 215, 175, 0, 215, 215, 0, 215, 255, 0, 255, 0, 0, 255, 95, 0, 255, 135, 0, 255, 175, 0, 255, 215, 0,
                255, 255, 95, 0, 0, 95, 0, 95, 95, 0, 135, 95, 0, 175, 95, 0, 215, 95, 0, 255, 95, 95, 0, 95, 95, 95,
                95, 95, 135, 95, 95, 175, 95, 95, 215, 95, 95, 255, 95, 135, 0, 95, 135, 95, 95, 135, 135, 95, 135, 175,
                95, 135, 215, 95, 135, 255, 95, 175, 0, 95, 175, 95, 95, 175, 135, 95, 175, 175, 95, 175, 215, 95, 175,
                255, 95, 215, 0, 95, 215, 95, 95, 215, 135, 95, 215, 175, 95, 215, 215, 95, 215, 255, 95, 255, 0, 95,
                255, 95, 95, 255, 135, 95, 255, 175, 95, 255, 215, 95, 255, 255, 135, 0, 0, 135, 0, 95, 135, 0, 135,
                135, 0, 175, 135, 0, 215, 135, 0, 255, 135, 95, 0, 135, 95, 95, 135, 95, 135, 135, 95, 175, 135, 95,
                215, 135, 95, 255, 135, 135, 0, 135, 135, 95, 135, 135, 135, 135, 135, 175, 135, 135, 215, 135, 135,
                255, 135, 175, 0, 135, 175, 95, 135, 175, 135, 135, 175, 175, 135, 175, 215, 135, 175, 255, 135, 215, 0,
                135, 215, 95, 135, 215, 135, 135, 215, 175, 135, 215, 215, 135, 215, 255, 135, 255, 0, 135, 255, 95,
                135, 255, 135, 135, 255, 175, 135, 255, 215, 135, 255, 255, 175, 0, 0, 175, 0, 95, 175, 0, 135, 175, 0,
                175, 175, 0, 215, 175, 0, 255, 175, 95, 0, 175, 95, 95, 175, 95, 135, 175, 95, 175, 175, 95, 215, 175,
                95, 255, 175, 135, 0, 175, 135, 95, 175, 135, 135, 175, 135, 175, 175, 135, 215, 175, 135, 255, 175,
                175, 0, 175, 175, 95, 175, 175, 135, 175, 175, 175, 175, 175, 215, 175, 175, 255, 175, 215, 0, 175, 215,
                95, 175, 215, 135, 175, 215, 175, 175, 215, 215, 175, 215, 255, 175, 255, 0, 175, 255, 95, 175, 255,
                135, 175, 255, 175, 175, 255, 215, 175, 255, 255, 215, 0, 0, 215, 0, 95, 215, 0, 135, 215, 0, 175, 215,
                0, 215, 215, 0, 255, 215, 95, 0, 215, 95, 95, 215, 95, 135, 215, 95, 175, 215, 95, 215, 215, 95, 255,
                215, 135, 0, 215, 135, 95, 215, 135, 135, 215, 135, 175, 215, 135, 215, 215, 135, 255, 215, 175, 0, 215,
                175, 95, 215, 175, 135, 215, 175, 175, 215, 175, 215, 215, 175, 255, 215, 215, 0, 215, 215, 95, 215,
                215, 135, 215, 215, 175, 215, 215, 215, 215, 215, 255, 215, 255, 0, 215, 255, 95, 215, 255, 135, 215,
                255, 175, 215, 255, 215, 215, 255, 255, 255, 0, 0, 255, 0, 95, 255, 0, 135, 255, 0, 175, 255, 0, 215,
                255, 0, 255, 255, 95, 0, 255, 95, 95, 255, 95, 135, 255, 95, 175, 255, 95, 215, 255, 95, 255, 255, 135,
                0, 255, 135, 95, 255, 135, 135, 255, 135, 175, 255, 135, 215, 255, 135, 255, 255, 175, 0, 255, 175, 95,
                255, 175, 135, 255, 175, 175, 255, 175, 215, 255, 175, 255, 255, 215, 0, 255, 215, 95, 255, 215, 135,
                255, 215, 175, 255, 215, 215, 255, 215, 255, 255, 255, 0, 255, 255, 95, 255, 255, 135, 255, 255, 175,
                255, 255, 215, 255, 255, 255, 8, 8, 8, 18, 18, 18, 28, 28, 28, 38, 38, 38, 48, 48, 48, 58, 58, 58, 68,
                68, 68, 78, 78, 78, 88, 88, 88, 98, 98, 98, 108, 108, 108, 118, 118, 118, 128, 128, 128, 138, 138, 138,
                148, 148, 148, 158, 158, 158, 168, 168, 168, 178, 178, 178, 188, 188, 188, 198, 198, 198, 208, 208, 208,
                218, 218, 218, 228, 228, 228, 238, 238, 238,
            };
            int startX = 10;
            int startY = 375;
            int r = 0, g = 1, b = 2;
            for (var i = 0; i < colorGrid.Length; i++)
            {
                if (i % 16 == 0)
                {
                    startX = 10;
                    startY += 16;
                }

                colorGrid[i] = new Button
                {
                    Location = new System.Drawing.Point(startX, startY),
                    Size = new System.Drawing.Size(16, 16),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(colors[r], colors[g], colors[b]),

                };
                colorGrid[i].Click += new EventHandler(this.ColorGridSelect);
                startX += 16;
                r += 3;
                g += 3;
                b += 3;
                this.Controls.Add(colorGrid[i]);
            }
        }


        private void ColorGridSelect(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Console.WriteLine(b.BackColor);
            pixelColor.BackColor = b.BackColor;
        }

        private void ImageGridClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = pixelColor.BackColor;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!FileName.Text.Equals(""))
            {
                LoadColors();
                Bitmap bmpImg = new Bitmap(16, 16);
                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        bmpImg.SetPixel(j, i, imageColors[i, j]);
                    }
                }

                if (FileName.Text.Contains(".bmp"))
                    bmpImg.Save(FileName.Text);
                else
                    bmpImg.Save(FileName.Text + @".bmp");
                AddBitmap(bmpImg);

            }
            else
            {
                MessageBox.Show(@"Empty File Name");
            }
        }

        void LoadColors()
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    imageColors[i, j] = image[i, j].BackColor;
                }
            }
        }

        void SaveColors()
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    image[i, j].BackColor = imageColors[i, j];
                }
            }
        }

        private void ShiftLeft()
        {
            LoadColors();
            for (int i = 0; i < 16; i++)
            {
                Color temp = imageColors[i, 0];
                for (int k = 0; k < 15; k++)
                {
                    imageColors[i, k] = imageColors[i, k + 1];
                }

                imageColors[i, 15] = temp;
            }

            SaveColors();
        }

        private void ShiftRight()
        {
            LoadColors();
            for (int i = 0; i < 16; i++)
            {
                Color temp = imageColors[i, 15];
                for (int k = 14; k >= 0; k--)
                {
                    imageColors[i, k + 1] = imageColors[i, k];
                }

                imageColors[i, 0] = temp;
            }

            SaveColors();
        }

        private void ShiftUp()
        {
            LoadColors();
            for (int i = 0; i < 16; i++)
            {
                Color temp = imageColors[0, i];
                for (int k = 0; k < 15; k++)
                {
                    imageColors[k, i] = imageColors[k + 1, i];
                }

                imageColors[15, i] = temp;
            }

            SaveColors();
        }

        private void ShiftDown()
        {
            LoadColors();
            for (int i = 0; i < 16; i++)
            {
                Color temp = imageColors[15, i];
                for (int k = 14; k >= 0; k--)
                {
                    imageColors[k + 1, i] = imageColors[k, i];
                }

                imageColors[0, i] = temp;
            }

            SaveColors();
        }

        private void Rotate()
        {
            LoadColors();
            Color[,] temp = new Color[16, 16];
            Color[] rc = new Color[16];
            for (int i = 0; i < 16; i++)
            {
                for (int r = 0; r < 16; r++)
                {
                    rc[r] = imageColors[i, r];
                }

                for (int r = 0; r < 16; r++)
                {
                    temp[15 - r, i] = rc[r];
                }
            }

            imageColors = temp;
            SaveColors();
        }

        private void Flip()
        {
            LoadColors();
            Color[,] temp = new Color[16, 16];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    temp[j, i] = imageColors[15 - j, i];
                }
            }

            imageColors = temp;
            SaveColors();
        }

        private void ShiftLeftButton_Click(object sender, EventArgs e)
        {
            ShiftLeft();
        }

        private void ShiftRightButton_Click(object sender, EventArgs e)
        {
            ShiftRight();
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            Rotate();
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            Flip();
        }

        private void ShiftUpButton_Click(object sender, EventArgs e)
        {
            ShiftUp();
        }

        private void ShiftDownButton_Click(object sender, EventArgs e)
        {
            ShiftDown();
        }

        private void AddBitmap(Bitmap imBitmap)
        {
            listBitmaps.Add(imBitmap);
            imBitmap = ScaleImage(imBitmap);
            imageList.ImageSize = new Size(50, 50);
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.Images.Add(imageList.Images.Count.ToString(), imBitmap);
            ImageListView.LargeImageList = imageList;
            var listViewItem = ImageListView.Items.Add("");
            listViewItem.ImageKey = imageList.Images.Count.ToString();
        }

        public Bitmap ScaleImage(Bitmap bmp)
        {
            Bitmap img = new Bitmap(64, 64);

            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 16; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    for (int x1 = 0; x1 < 4; x1++)
                    {
                        for (int y1 = 0; y1 < 4; y1++)
                        {
                            img.SetPixel(4 * x + x1, 4 * y + y1, c);
                        }
                    }
                }
            }

            return img;
        }

        private void ReadFiles()
        {
            foreach (string file in Directory.EnumerateFiles("./", "*.bmp"))
            {
                Console.WriteLine(file);
                Bitmap bmp = new Bitmap(file, true);
                AddBitmap(bmp);
            }
        }

        private void ImageListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImageListView.SelectedItems.Count > 0)
            {
                int index = ImageListView.SelectedIndices[0];
                if (index < listBitmaps.Count)
                {
                    Console.WriteLine(index + @" -> THIS IS");
                    LoadBmp(index);
                }

            }
            Console.WriteLine(sender);
        }

        void LoadBmp(int index)
        {
            Bitmap bitmap = listBitmaps[index];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    imageColors[j, i] = bitmap.GetPixel(i, j);
                }
            }
            SaveColors();
        }
    }
}
