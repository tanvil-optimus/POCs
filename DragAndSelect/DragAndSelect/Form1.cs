using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndSelect
{
    public partial class Form1 : Form
    {

        private Point _rectStartPoint;
        private Rectangle _rect;

        public Form1()
        {
            InitializeComponent();
        }

        //Start the rectangle
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _rectStartPoint = e.Location;
            Invalidate();
        }

        //Draw the rectangle
        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            _rect.Location = new Point(
                Math.Min(_rectStartPoint.X, tempEndPoint.X),
                Math.Min(_rectStartPoint.Y, tempEndPoint.Y));
            _rect.Size = new Size(
                Math.Abs(_rectStartPoint.X - tempEndPoint.X),
                Math.Abs(_rectStartPoint.Y - tempEndPoint.Y));
            pictureBox1.Invalidate();
        }

        // Draw Area
        //
        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Draw the rectangle...
            if (pictureBox1.Image != null)
            {
                Brush brush = new SolidBrush(Color.FromArgb(255,0,0,0));
                e.Graphics.FillRectangle(brush, _rect);
            }
        }

        //Hide the rectangle.
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _rect.Location = new Point(
              Math.Min(0,0),
              Math.Min(0, 0));
                _rect.Size = new Size(
                    Math.Abs(0),
                    Math.Abs(0));
                pictureBox1.Invalidate();
            }
        }
 
    }
}
