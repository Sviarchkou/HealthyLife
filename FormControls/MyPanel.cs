using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.FormControls
{
    public class MyPanel : UserControl
    {
        public override Image? BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }
        public new string Text { get => base.Text; set => base.Text = value; }
        public Color BorderColor { get; set; } = Color.DarkGray;

        private Color panelColor;
        public Color PanelColor
        {
            get => panelColor;
            set
            {
                panelColor = value;
                Invalidate();
            }
        }

        private int rad = 1;
        public int Rad { 
            get => rad;
            set {
                rad = value;
                Invalidate();
            }
        }


        public MyPanel()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            GraphicsPath gpathPath = paintRoundedRectangle(rect, Rad);
            
            graph.FillPath(new SolidBrush(PanelColor), gpathPath);

            StringFormat stringFormat = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);

        }

        private GraphicsPath paintRoundedRectangle(Rectangle rect, float RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

            gp.CloseFigure();

            return gp;
        }

        public void paint(PaintEventArgs e)
        {
            OnPaint(e);
        }
    }
}

