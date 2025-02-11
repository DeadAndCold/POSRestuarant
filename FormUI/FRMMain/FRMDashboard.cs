using POSRestuarant.ClassesBackEndProcess;
using POSRestuarant.FormUI.Custome_Controls.RoundCornerControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRestuarant.FormUI.FRMMain
{
    public partial class FRMDashboard : Form
    {
        RoundBorder objRoundBorder = new RoundBorder();
        public FRMDashboard()
        {
            InitializeComponent();
        }

        private void FRMDashboard_Load(object sender, EventArgs e)
        {
            objRoundBorder.CustomePanel(customePanelOrder1);
            objRoundBorder.CustomePanel(customePanelOrder2);
            objRoundBorder.CustomePanel(customePanelOrder3);
            objRoundBorder.RoundButton(BtnAll);
            objRoundBorder.RoundButton(BtnComplete);
            objRoundBorder.RoundButton(BtnPending);
        }
    }
}
