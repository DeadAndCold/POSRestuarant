using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestuarant.ClassesBackEndProcess;
using POSRestuarant.FormUI.Custome_Controls.RoundCornerControls;
using POSRestuarant.FormUI.FRMMain;
using POSRestuarantBackEnd;
using POSRestuarantBackEnd.SQLServer;

namespace POSRestuarant
{
    public partial class FRMLogin : Form
    {
        SqlConnection conn;
        RoundBorder objRoundBorder = new RoundBorder();
        public FRMLogin()
        {
            InitializeComponent();
            ClsMain clsConnection = new ClsMain();
            clsConnection.GetSQLConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objRoundBorder.RoundButton(BtnCancel);
            objRoundBorder.RoundButton(BtnLogIn);
            TxtUsername.Select();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string _errorMessage = string.Empty;
            List<string> Content = new List<string>();   
            try
            {
                InitializeSQLServer objAPI = new InitializeSQLServer();
                Content = objAPI.GetUserAndPermission(TxtUsername.Text.Trim().ToUpper(), TxtPassword.Text.Trim().ToUpper());
                if(Content.Count > 0)
                {
                    string UserID = Content[0];
                    string Username = Content[1];
                    string Password = Content[2];
                    string Permission = Content[3];

                    if (Permission != "None")
                    {
                        ClsMain._UserID = UserID;
                        ClsMain._Username = Username;
                        ClsMain._Password = Password;
                        ClsMain._Permission = Permission;
                        this.Hide();
                        FRMMain frmDashBoard = new FRMMain();
                        frmDashBoard.ShowDialog();
                    }
                    else
                    {
                        ClsMain._UserID = "Not Found";
                        ClsMain._Username = "Not Found";
                        ClsMain._Password = "Not Found";
                        ClsMain._Permission = Permission;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credential" + "\n" + "Please try again");
                    TxtUsername.Focus();
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BtnLogIn_Click(sender, e);
            }
        }
    }
}
