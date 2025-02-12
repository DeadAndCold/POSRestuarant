using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestuarant.FormUI.Custome_Controls.Custome_Panel;

namespace POSRestuarant.FormUI.Custome_Controls.RoundCornerControls
{
    public class RoundBorder
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
        public void RoundTableLayoutPanel(TableLayoutPanel tlp)
        {
            GraphicsPath rad = new GraphicsPath();
            rad.StartFigure();
            rad.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            rad.AddLine(10, 0, tlp.Width - 20, 0);
            rad.AddArc(new Rectangle(tlp.Width - 20, 0, 20, 20), -90, 90);
            rad.AddLine(tlp.Width, 20, tlp.Width, tlp.Height - 10);
            rad.AddArc(new Rectangle(tlp.Width - 25, tlp.Height - 25, 25, 25), 0, 90);
            rad.AddLine(tlp.Width - 10, tlp.Width, 20, tlp.Height);
            rad.AddArc(new Rectangle(0, tlp.Height - 20, 20, 20), 90, 90);
            tlp.Region = new Region(rad);
        }
        public void CustomePanel(CustomePanelOrder customePanel)
        {
            GraphicsPath rad = new GraphicsPath();
            rad.StartFigure();
            rad.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            rad.AddLine(10, 0, customePanel.Width - 20, 0);
            rad.AddArc(new Rectangle(customePanel.Width - 20, 0, 20, 20), -90, 90);
            rad.AddLine(customePanel.Width, 20, customePanel.Width, customePanel.Height - 10);
            rad.AddArc(new Rectangle(customePanel.Width - 25, customePanel.Height - 25, 25, 25), 0, 90);
            rad.AddLine(customePanel.Width - 10, customePanel.Width, 20, customePanel.Height);
            rad.AddArc(new Rectangle(0, customePanel.Height - 20, 20, 20), 90, 90);
            customePanel.Region = new Region(rad);
        }

        public void RoundPictureBox(PictureBox pic)
        {
            GraphicsPath rad = new GraphicsPath();
            rad.StartFigure();
            rad.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            rad.AddLine(10, 0, pic.Width - 20, 0);
            rad.AddArc(new Rectangle(pic.Width - 20, 0, 20, 20), -90, 90);
            rad.AddLine(pic.Width, 20, pic.Width, pic.Height - 10);
            rad.AddArc(new Rectangle(pic.Width - 25, pic.Height - 25, 25, 25), 0, 90);
            rad.AddLine(pic.Width - 10, pic.Width, 20, pic.Height);
            rad.AddArc(new Rectangle(0, pic.Height - 20, 20, 20), 90, 90);
            pic.Region = new Region(rad);
        }

        public void RoundPanel(Panel pn)
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
