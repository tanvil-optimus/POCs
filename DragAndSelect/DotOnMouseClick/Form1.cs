using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotOnMouseClick
{
    public partial class Form1 : Form
    {
        private Point _circleStartPoint;
        private Rectangle _rect;
        private int _pixelSize = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            _circleStartPoint = e.Location;
            _pixelSize = 2; //will be set to one later. This is for illustration purpose.

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //// Draw the rectangle...
            //if (pictureBox1.Image != null) //Ideally this condition should be added.
            //{
            Brush brush = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(brush,_circleStartPoint.X, _circleStartPoint.Y,2,2);
            //}
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _circleStartPoint.X = 0;
            _circleStartPoint.Y = 0;
            _pixelSize = 0;

            pictureBox1.Invalidate();
        }

        
    }
}
