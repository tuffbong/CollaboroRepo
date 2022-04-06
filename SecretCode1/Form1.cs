using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecretCode1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();

            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(c.R, c.R, c.R));
                }
            pictureBox2.Image = (Bitmap)bmp;
        }
    }
}
