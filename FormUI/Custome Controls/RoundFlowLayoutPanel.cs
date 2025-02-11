using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRestuarant.FormUI.Custome_Controls
{
    public class RoundFlowLayoutPanel : FlowLayoutPanel
    {
        public int rdus = 0;
        System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int Radius)
        {
            float r2 = Radius / 2f;
            System.Drawing.Drawing2D.GraphicsPath GraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            GraphicsPath.AddArc(Rect.X, Rect.Y, Radius, Radius, 180, 90);
            GraphicsPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphicsPath.AddArc(Rect.X + Rect.Width - Radius, Rect.Y, Radius, Radius, 270, 90);
            GraphicsPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphicsPath.AddArc(Rect.X + Rect.Width - Radius, Rect.Y + Rect.Height - Radius, Radius, Radius, 0, 90);
            GraphicsPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphicsPath.AddArc(Rect.X, Rect.Y + Rect.Height - Radius, Radius, Radius, 90, 90);
            GraphicsPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphicsPath.CloseFigure();
            return GraphicsPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 0f))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
    }
}
