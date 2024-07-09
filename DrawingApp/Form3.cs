using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form3 : Form
    {
        private bool draw = false;
        private Point lastPoint;
        private Bitmap drawingBitmap; // Bitmap to store the drawing

        public Form3()
        {
            InitializeComponent();
            // Initialize bitmap
            drawingBitmap = new Bitmap(3 * pictureBox1.Width, 3 * pictureBox1.Height);
            pictureBox1.Image = drawingBitmap;
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);
        }

        // Enable drag to draw
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                lastPoint = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                // Draw onto the bitmap 
                using (Graphics graphics = Graphics.FromImage(drawingBitmap))
                {
                    Pen pen = new Pen(Color.Black, 2);
                    graphics.DrawLine(pen, lastPoint, e.Location);
                    lastPoint = e.Location;
                }
                // Refresh the PictureBox to show the updated bitmap
                pictureBox1.Invalidate();
            }
        }

        // Stops drawing when left mouse button is released
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw = false;
            }
        }

        // Clear the sketch
        private void clearButton_Click(object sender, EventArgs e)
        {
            drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = drawingBitmap;
        }
    }
}