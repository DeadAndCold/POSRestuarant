using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestuarant.ClassesBackEndProcess;
using POSRestuarant.FormUI.Custome_Controls;
using Syncfusion.Windows.Forms.Tools.Win32API;
using static Syncfusion.XlsIO.Implementation.Security.Aes;

namespace POSRestuarant.FormUI.FRMMain
{
    public partial class FRMMain : Form
    {
        FRMDashboard FRMDashboard = new FRMDashboard();
        FRMMenu frmMenu = new FRMMenu();
        FRMOrders frmOrders = new FRMOrders();
        FRMTables frmTables = new FRMTables();

        bool frmDashboardVisible = false;
        bool frmMenuVisible = false;
        bool frmOrdersVisible = false;
        bool frmTablesVisible = false;
        public FRMMain()
        {
            InitializeComponent();
            SqlConnection conn = ClsMain.conn;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void FRMDashBoard_Load(object sender, EventArgs e)
        {
            tlpForm.ColumnStyles[0].SizeType = SizeType.Absolute;
            tlpForm.ColumnStyles[0].Width = 225;
            //RoundFlowLayoutPanel rb = new RoundFlowLayoutPanel();
            //rb.Text = "Rounded Button";
            //rb.Height = 46;
            //rb.Width = 139;
            //rb.Location = new Point(120, 20);
            //rb.rdus = 30;
            //rb.BackColor = Color.IndianRed;
            //rb.Dock = DockStyle.Fill;
            //rb.BorderStyle = BorderStyle.None;
            //rb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            //tableLayoutPanel1.Controls.Add(rb, 1, 1);

        } 

        bool isExpand = true;

        //// ================================= Method To Disable All Key Binding On The Window Form ================================

        //private bool disableKeys = false;

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (disableKeys)
        //    {
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        private void navigationBar_Tick(object sender, EventArgs e)
        {
            tlpForm.ColumnStyles[0].SizeType = SizeType.Absolute;
            if (isExpand)
            {
                tlpForm.ColumnStyles[0].Width -= 8;
                tlpFormContainer.Visible = false;
                if(frmMenuVisible == true)
                {
                    frmMenu.Size += tlpFormContainer.ClientSize;
                }
                else if (frmDashboardVisible == true)
                {
                    FRMDashboard.Size += tlpFormContainer.ClientSize;
                }
                else if (frmOrdersVisible == true)
                {
                    frmOrders.Size += tlpFormContainer.ClientSize;
                }
                else if(frmTablesVisible == true)
                {
                    frmTables.Size += tlpFormContainer.ClientSize;
                }

                if (tlpForm.ColumnStyles[0].Width <= 125)
                {
                    BtnNavigation.Text = string.Empty;
                    BtnDashboard.Text = string.Empty;
                    BtnMenu.Text = string.Empty;
                    BtnOrders.Text = string.Empty;
                    BtnTables.Text = string.Empty;
                    BtnUsername.Text = string.Empty;
                    BtnLogOut.Text = string.Empty;
                }
                if(tlpForm.ColumnStyles[0].Width <= 41)
                {
                    isExpand = false;
                    navigationBar.Stop();
                    tlpFormContainer.Visible = true;
                    if (frmMenuVisible == true)
                    {
                        frmMenu.Size = tlpFormContainer.ClientSize;
                    }
                    else if (frmDashboardVisible == true)
                    {
                        FRMDashboard.Size = tlpFormContainer.ClientSize;
                    }
                    else if(frmOrdersVisible == true)
                    {
                        frmOrders.Size = tlpFormContainer.ClientSize;
                    }
                    else if(frmTablesVisible == true)
                    {
                        frmTables.Size = tlpFormContainer.ClientSize;
                    }
                }
            }
            else
            {
                tlpForm.ColumnStyles[0].Width += 8;
                tlpFormContainer.Visible = false;
                if (frmMenuVisible == true)
                {
                    frmMenu.Size -= tlpFormContainer.ClientSize;
                }
                else if (frmDashboardVisible == true)
                {
                    FRMDashboard.Size -= tlpFormContainer.ClientSize;
                }
                else if(frmOrdersVisible == true)
                {
                    frmOrders.Size = tlpFormContainer.ClientSize;
                }
                else if(frmTablesVisible == true)
                {
                    frmTables.Size = tlpFormContainer.ClientSize;
                }

                if (tlpForm.ColumnStyles[0].Width >= 125)
                {
                    BtnNavigation.Text = "Restuarant";
                    BtnDashboard.Text = "Dashborad";
                    BtnMenu.Text = "Menu";
                    BtnOrders.Text = "Orders";
                    BtnTables.Text = "Tables";
                    BtnUsername.Text = "Username";
                    BtnLogOut.Text = "Log Out";
                }
                if (tlpForm.ColumnStyles[0].Width >= 225)
                {
                    isExpand = true;
                    navigationBar.Stop();
                    tlpFormContainer.Visible = true;
                    if (frmMenuVisible == true)
                    {
                        frmMenu.Size = tlpFormContainer.ClientSize;
                    }
                    else if (frmDashboardVisible == true)
                    {
                        FRMDashboard.Size = tlpFormContainer.ClientSize;
                    }
                    else if(frmOrdersVisible == true)
                    {
                        frmOrders.Size = tlpFormContainer.ClientSize;
                    }
                    else if(frmTablesVisible == true)
                    {
                        frmTables.Size = tlpFormContainer.ClientSize;
                    }
                }
            }
        }

        private void FRMDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNavigation_Click(object sender, EventArgs e)
        {
            //disableKeys = true;
            navigationBar.Start();
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            DisplayFormOnTableLayoutPanel("FRMMENU");
        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            DisplayFormOnTableLayoutPanel("FRMDASHBOARD");
        }
        private void BtnOrders_Click(object sender, EventArgs e)
        {
            DisplayFormOnTableLayoutPanel("FRMORDERS");
            lblChildFormName.Text = "Nice! We have a lot of orders here!";
        }
        private void BtnTables_Click(object sender, EventArgs e)
        {
            DisplayFormOnTableLayoutPanel("FRMTABLES");
            lblChildFormName.Text = "Tables";
        }
        private void DisplayFormOnTableLayoutPanel(string FormName)
        {
            tlpFormContainer.Controls.Clear();

            if(FormName.ToUpper() == "FRMDASHBOARD")
            {
                InitializeFormVisibity("FRMDASHBOARD");

                FRMDashboard.TopLevel = false;
                FRMDashboard.Size = tlpFormContainer.ClientSize;
                FRMDashboard.FormBorderStyle = FormBorderStyle.None;
                FRMDashboard.Visible = true;
                tlpFormContainer.Controls.Add(FRMDashboard);
            }
            else if (FormName.ToUpper() == "FRMMENU")
            {
                InitializeFormVisibity("FRMMENU");

                frmMenu.TopLevel = false;
                frmMenu.Size = tlpFormContainer.ClientSize;
                frmMenu.FormBorderStyle = FormBorderStyle.None;
                frmMenu.Visible = true;
                tlpFormContainer.Controls.Add(frmMenu);
            }
            else if (FormName.ToUpper() == "FRMORDERS")
            {
                InitializeFormVisibity("FRMORDERS");

                frmOrders.TopLevel = false;
                frmOrders.Size = tlpFormContainer.ClientSize;
                frmOrders.FormBorderStyle = FormBorderStyle.None;
                frmOrders.Visible = true;
                tlpFormContainer.Controls.Add(frmOrders);
            }
            else if (FormName.ToUpper() == "FRMTABLES")
            {
                InitializeFormVisibity("FRMTABLES");

                frmTables.TopLevel = false;
                frmTables.Size = tlpFormContainer.ClientSize;
                frmTables.FormBorderStyle = FormBorderStyle.None;
                frmTables.Visible = true;
                tlpFormContainer.Controls.Add(frmTables);
            }
        }

        private void InitializeFormVisibity(string FormName)
        {
            if (FormName.ToUpper() == "FRMDASHBOARD")
            {
                frmDashboardVisible = true;
                frmMenuVisible = false;
                frmOrdersVisible = false;
                frmTablesVisible = false;
            }
            else if (FormName.ToUpper() == "FRMMENU")
            {
                frmDashboardVisible = false;
                frmMenuVisible = true;
                frmOrdersVisible = false;
                frmTablesVisible = false;
            }
            else if (FormName.ToUpper() == "FRMORDERS")
            {
                frmDashboardVisible = false;
                frmMenuVisible = false;
                frmOrdersVisible = true;
                frmTablesVisible = false;
            }
            else if (FormName.ToUpper() == "FRMTABLES")
            {
                frmDashboardVisible = false;
                frmMenuVisible = false;
                frmOrdersVisible = false;
                frmTablesVisible = true;
            }
        }
        private void BtnDashboard_MouseEnter(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.LightGray;
        }

        private void BtnMenu_MouseEnter(object sender, EventArgs e)
        {
            BtnMenu.BackColor = Color.LightGray;
        }

        private void BtnOrders_MouseEnter(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.LightGray;
        }

        private void BtnTables_MouseEnter(object sender, EventArgs e)
        {
            BtnTables.BackColor = Color.LightGray;
        }

        private void BtnUsername_MouseEnter(object sender, EventArgs e)
        {
            BtnUsername.BackColor = Color.LightGray;
        }

        private void BtnLogOut_MouseEnter(object sender, EventArgs e)
        {
            BtnLogOut.BackColor = Color.LightGray;
        }

        private void BtnDashboard_MouseLeave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.DarkBlue;
        }

        private void BtnMenu_MouseLeave(object sender, EventArgs e)
        {
            BtnMenu.BackColor = Color.DarkBlue;
        }

        private void BtnOrders_MouseLeave(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.DarkBlue;
        }

        private void BtnTables_MouseLeave(object sender, EventArgs e)
        {
            BtnTables.BackColor = Color.DarkBlue;
        }

        private void BtnUsername_MouseLeave(object sender, EventArgs e)
        {
            BtnUsername.BackColor = Color.DarkBlue;
        }

        private void BtnLogOut_MouseLeave(object sender, EventArgs e)
        {
            BtnLogOut.BackColor = Color.DarkBlue;
        }

        private void BtnNavigation_MouseEnter(object sender, EventArgs e)
        {
            BtnNavigation.BackColor = Color.DarkBlue;
        }

        private void BtnNavigation_MouseLeave(object sender, EventArgs e)
        {
            BtnNavigation.BackColor = Color.DarkBlue;
        }
    }
}
