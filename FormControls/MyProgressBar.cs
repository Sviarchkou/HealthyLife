using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace HealthyLife_Pt2.FormControls
{
    public class MyProgressBar : UserControl
    {

        #region -- Свойства --

        public Color BorderColor { get; set; } = Color.DarkGray;
        public Color BackColorProgressLeft { get; set; } = Color.GreenYellow;
        public Color BackColorProgressRight { get; set; } = Color.GreenYellow;

        private int _value = 0;
        public int Value
        {
            get => _value;
            set
            {
                if (value >= ValueMinimum && value <= ValueMaximum)
                {
                    _value = value;
                }
                else
                {
                    value = _value;
                }
            }
        }

        private int _valueMinimum = 0;
        public int ValueMinimum
        {
            get => _valueMinimum;
            set
            {
                if (value < ValueMaximum)
                {
                    _valueMinimum = value;

                    if (_valueMinimum > Value)
                    {
                        Value = _valueMinimum;
                        Invalidate();
                    }
                }
                else
                {
                    value = _valueMinimum;
                }
            }
        }

        private int _valueMaximum = 100;
        public int ValueMaximum
        {
            get => _valueMaximum;
            set
            {
                if (value > ValueMinimum)
                {
                    _valueMaximum = value;
                    Invalidate();
                }
                else
                {
                    value = _valueMaximum;
                }
            }
        }

        private int rad = 5;
        public int Rad
        {
            get => rad;
            set
            {
                rad = value;
                Invalidate();
            }
        }

        public int Step { get; set; } = 1;

        #endregion

        public MyProgressBar()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
     

            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;


            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            GraphicsPath gp1 = new GraphicsPath();

            gp1.AddArc(rect.X, rect.Y, Rad, Rad > rect.Height ? rect.Height : Rad, 180, 90);
            gp1.AddArc(rect.X + rect.Width - Rad, rect.Y, Rad, Rad > rect.Height ? rect.Height : Rad, 270, 90);
            gp1.AddArc(rect.X + rect.Width - Rad, rect.Y + rect.Height - Rad, Rad, Rad > rect.Height ? rect.Height : Rad, 0, 90);
            gp1.AddArc(rect.X, rect.Y + rect.Height - Rad, Rad, Rad > rect.Height ? rect.Height : Rad, 90, 90);
            
            gp1.CloseFigure();

            GraphicsPath gp2 = new GraphicsPath();

            gp2.AddArc(rect.X, rect.Y, Rad, Rad > rect.Height ? rect.Height : Rad, 180, 90);
            gp2.AddArc(rect.X + (rect.Width * Value / 100) - Rad, rect.Y, Rad, Rad > rect.Height ? rect.Height : Rad, 270, 90);
            gp2.AddArc(rect.X + (rect.Width * Value/100) - Rad, rect.Y + rect.Height - Rad, Rad, Rad > rect.Height ? rect.Height : Rad, 0, 90);
            gp2.AddArc(rect.X, rect.Y + rect.Height - Rad, Rad, Rad > rect.Height ? rect.Height : Rad, 90, 90);

            gp2.CloseFigure();

            graphics.FillPath(new SolidBrush(BackColorProgressLeft), gp1);
            graphics.FillPath(new SolidBrush(BackColorProgressRight), gp2);
            graphics.DrawPath(new Pen(BorderColor), gp1);

            base.OnPaint(e);


            /*
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;


            Rectangle rectBase = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectProgress = new Rectangle(
                rectBase.X,
                rectBase.Y,
                CalculateProgressRectSize(rectBase),
                rectBase.Height);

            int Rad = (int) (Math.Min(Height, Width)/1.5);
            GraphicsPath gpathBase = paintRoundedRectangle(rectBase, Rad);
            GraphicsPath gpathProgress = paintRoundedRectangle(rectProgress, Rad);

            // Рисуем основу
            DrawBase(graph, gpathBase);

            // Рисуем прогресс
            DrawProgress(graph, rectProgress, gpathProgress);

            // Рисуем обводку
            DrawBorder(graph, gpathBase);
            */
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
        private int CalculateProgressRectSize(Rectangle rect)
        {
            int margin = ValueMaximum - ValueMinimum;
            return rect.Width * (int)Value / margin;
        }

        #region -- Рисование объектов --

        private void DrawBase(Graphics graph, GraphicsPath gpath)
        {
            graph.FillPath(new SolidBrush(BackColor), gpath);
        }

        private void DrawBorder(Graphics graph, GraphicsPath gpath)
        {
            graph.DrawPath(new Pen(BorderColor), gpath);
        }

        private void DrawProgress(Graphics graph, Rectangle rect, GraphicsPath gpath)
        {
            if (rect.Width > 0)
            {
                LinearGradientBrush LGB = new LinearGradientBrush(rect, BackColorProgressLeft, BackColorProgressRight, 360);

                graph.DrawPath(new Pen(LGB), gpath);
                graph.FillPath(LGB, gpath);
            }
        }

        #endregion


        #region -- Public методы --

        public bool PerformStep()
        {
            if (Value < ValueMaximum)
            {
                if (Value + Step >= ValueMaximum)
                {
                    Value = ValueMaximum;
                    return false;
                }
                else
                {
                    Value += Step;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void ResetProgress()
        {
            Value = ValueMinimum;
        }

        #endregion
    }
}




