using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.FormControls
{
    
    public class CircularProgressBar : UserControl
    {
        float valueSize = 40;
        int boarderSize = 15;
        Color middleCircleColor = Color.DarkBlue;
        Color outerCircleColor = Color.Transparent;
        Color arcColor = Color.White;
        string text = "";
        public CircularProgressBar()
        {
            DoubleBuffered = true;
        }

        public new string Text {
            get => text;
            set{ 
                text = value == null ? "" : value ;
                Invalidate();
            }
        } 
        
        public float ValueSize
        {
            get => valueSize;
            set
            {
                valueSize = (value > 100) ? 100 : value;
                Invalidate();
            }
        }
        public int BorderSize
        {
            get => boarderSize;
            set
            {
                boarderSize = (value > 20) ? 20 : value;
                Invalidate();
            }
        }
        public Color MiddleCircleColor
        {
            get => middleCircleColor;
            set
            {
                middleCircleColor  = value;
                Invalidate();
            }
        }
        public Color ArcColor
        {
            get => arcColor;
            set
            {
                arcColor = value;
                Invalidate();
            }
        }
        public Color OuterCircleColor
        {
            get => outerCircleColor;
            set
            {
                outerCircleColor = value;
                Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen Backpen = new Pen(arcColor, BorderSize - 1);
            Pen pen = new Pen(middleCircleColor, BorderSize) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            graphics.FillPie(new SolidBrush(outerCircleColor), new Rectangle(10, 10, Width - 20, Height - 20), 0, 360);
            graphics.DrawArc(Backpen, new Rectangle(10, 10, Width - 20, Height - 20), -90, 360);
            //graphics.DrawArc(Backpen, new Rectangle(10, 10, Width - 20, Height - 20), -90,  360);
            graphics.DrawArc(pen, new Rectangle(10, 10, Width - 20, Height - 20), -90, ValueSize/100 * 360);
            
            
            StringFormat stringFormat = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center};
            graphics.DrawString((Text == "" ? ValueSize + "%" : Text), Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
            graphics.DrawString("ккал", new Font(Font.Name, Font.Size * 2 / 3, Font.Style, GraphicsUnit.Point, 208), new SolidBrush(ForeColor), new Rectangle(10, 10+Font.Height*3/5, Width - 20, Height - 20), stringFormat);
            StringFormat percents  = new StringFormat() { LineAlignment = StringAlignment.Far , Alignment = StringAlignment.Center };

            if (Text != "")
            {
                graphics.DrawString(ValueSize + "%" , new Font(Font.Name, Font.Size /2, Font.Style, GraphicsUnit.Point, 208), new SolidBrush(ForeColor), new Rectangle(10, 10, Width - 20, Height - 20 - (Font.Height/4)), percents);
            }

            base.OnPaint(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Height = Width;
            base.OnSizeChanged(e);
        }
    }
}
