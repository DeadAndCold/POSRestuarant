using Syncfusion.XlsIO.Parser.Biff_Records;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace POSRestuarant.FormUI.Custome_Controls.RoundCornerControls
{
    public class RoundCorner
    {
        public void RoundButton(Button btn)
        {
            GraphicsPath rad = new GraphicsPath();
            rad.StartFigure();
            rad.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            rad.AddLine(10, 0, btn.Width - 20, 0);
            rad.AddArc(new Rectangle(btn.Width - 20, 0, 20, 20), -90, 90);
            rad.AddLine(btn.Width, 20, btn.Width, btn.Height - 10);
            rad.AddArc(new Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90);
            rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height);
            rad.AddArc(new Rectangle(0, btn.Height - 20, 20, 20), 90, 90);
            btn.Region = new Region(rad);
        }
    }
}
