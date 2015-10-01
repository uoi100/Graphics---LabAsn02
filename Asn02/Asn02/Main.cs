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
        Rectangle[] sides;
        int colorSwitch;

        public Main()
        {
            InitializeComponent();

            sides = new Rectangle[2];
            colorSwitch = 0;
        }

        private void PanelClick(object sender, EventArgs e)
        {
            if (colorSwitch == 0)
                colorSwitch++;
            else
                colorSwitch--;

            drawBackground();
            drawRectangles();
        }

        private void drawBackground()
        {
            sides[0] = new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height);
            sides[1] = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height);

            using (Graphics g = panel.CreateGraphics())
            {
                if (colorSwitch == 0)
                {
                    g.FillRectangle(Brushes.Black, sides[0]);
                    g.FillRectangle(Brushes.White, sides[1]);
                }
                else
                {
                    g.FillRectangle(Brushes.White, sides[0]);
                    g.FillRectangle(Brushes.Black, sides[1]);
                }
            }
        }

        private void drawRectangles()
        {
            Rectangle rect = new Rectangle(0, 0, 25, 25);
            int vGap = 25;
            int hGap = 25;
            int rMax = ClientRectangle.Height / (rect.Height + vGap);
            int cMax = (ClientRectangle.Width / 2) / (rect.Width + hGap);
            int width = ClientRectangle.Width / 2;

            for (int rIndex = 0; rIndex < rMax; rIndex++)
            {
                int y1 = rect.Height * (rIndex);
                int vSpace = vGap * (rIndex + 1);

                for (int cIndex = 0; cIndex < cMax; cIndex++)
                {
                    int x1 = rect.Width * (cIndex);
                    int x2 = rect.Width * (cIndex + 1);
                    int hSpace = hGap * (cIndex);

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
