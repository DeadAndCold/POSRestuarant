using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRestuarant.FormUI.Custome_Controls.RoundCornerControls
{
    public class RoundPanel
    {
        public void RoundCorner(Panel pn)
        {
            GraphicsPath rad = new GraphicsPath();
            rad.StartFigure();
            rad.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            rad.AddLine(10, 0, pn.Width - 20, 0);
            rad.AddArc(new Rectangle(pn.Width - 20, 0, 20, 20), -90, 90);
            rad.AddLine(pn.Width, 20, pn.Width, pn.Height - 10);
            rad.AddArc(new Rectangle(pn.Width - 25, pn.Height - 25, 25, 25), 0, 90);
            rad.AddLine(pn.Width - 10, pn.Width, 20, pn.Height);
            rad.AddArc(new Rectangle(0, pn.Height - 20, 20, 20), 90, 90);
            pn.Region = new Region(rad);
        }
    }
}
