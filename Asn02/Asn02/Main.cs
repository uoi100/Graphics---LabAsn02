using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asn02
{
    public partial class Main : Form
    {
        int _colorSwitch;
        int _s, _g;
        Controller _controller;

        public int S
        {
            get { return _s; }
            set { _s = value; }
        }

        public int G
        {
            get { return _g; }
            set { _g = value; }
        }

        public Main()
        {
            InitializeComponent();

            _colorSwitch = 0;
            _s = 25;
            _g = 1;

            _controller = new Controller(this);
            _controller.Show();
        }

        public void PanelClick(object sender, EventArgs e)
        {
            if (_colorSwitch == 0)
                _colorSwitch++;
            else
                _colorSwitch--;

            drawBackground();
            drawRectangles();
        }

        private void drawBackground()
        {
            Rectangle leftSide = new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height);
            Rectangle rightSide = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height);

            using (Graphics g = panel.CreateGraphics())
            {
                if (_colorSwitch == 0)
                {
                    g.FillRectangle(Brushes.Black, leftSide);
                    g.FillRectangle(Brushes.White, rightSide);
                }
                else
                {
                    g.FillRectangle(Brushes.White, leftSide);
                    g.FillRectangle(Brushes.Black, rightSide);
                }
            }
        }

        private void drawRectangles()
        {
            Rectangle rect = new Rectangle(0, 0, _s, _s);
            int vGap = _g;
            int hGap = _g;
            int borderSpace = (int)((double)1.5 * _s + _g);
            int rMax = (ClientRectangle.Height - borderSpace*2) / (rect.Height + vGap);
            int cMax = ((ClientRectangle.Width / 2) - borderSpace) / (rect.Width + hGap);
            int width = ClientRectangle.Width / 2;

            for (int rIndex = 0; rIndex < rMax; rIndex++)
            {
                int y1 = rect.Height * (rIndex);

                int vSpace = (vGap * (rIndex)) + borderSpace;

                for (int cIndex = 0; cIndex < cMax; cIndex++)
                {
                    int x1 = rect.Width * (cIndex);
                    int x2 = rect.Width * (cIndex + 1);
                    int hSpace = (hGap * (cIndex));

                    // Render Rectangles
                    using (Graphics g = panel.CreateGraphics())
                    {
                        g.FillRectangle(Brushes.LightGreen, new Rectangle(width - x2 - hSpace, y1 + vSpace, rect.Width, rect.Height));
                        g.FillRectangle(Brushes.LightGreen, new Rectangle(width + x1 + hSpace, y1 + vSpace, rect.Width, rect.Height));
                    }
                }
            }
        }

        private void formPaint(object sender, PaintEventArgs e)
        {
            drawBackground();
            drawRectangles();
        }

        private void formResize(object sender, EventArgs e)
        {
            drawBackground();
            drawRectangles();
        }
    }
}
