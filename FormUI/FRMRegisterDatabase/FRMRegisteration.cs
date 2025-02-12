using POSRestuarant.ClassesBackEndProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestuarantBackEnd;

namespace POSRestuarant.FormUI.FRMRegisterDatabase
{
    public partial class    FRMRegisteration : Form
    {

        bool _isChkCreateNewDB = false;
        bool _isChkExistingDB = false;
        bool _isSavedClick = false;
        DatabaseRegisterInfo objAPI = new DatabaseRegisterInfo();
        public FRMRegisteration()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _isSavedClick = true;
            try
            {
                SaveDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRMRegisteration_Load(object sender, EventArgs e)
        {
            TxtServerName.Select();
            label1.Text = "Restuarant" + "\n" + "Database Registeration";
        }

        private void TxtServerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtUserID.Focus();
            }
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtPassword.Focus();
            }
        }
        private void ChkCreateNewDB_CheckedChanged(object sender, EventArgs e)
        {
            TxtCreateNewDB.Enabled = true;
        }
        private void SaveDatabase()
        {
            try
            {
                if (_isSavedClick)
                {
                    if (!string.IsNullOrWhiteSpace(TxtServerName.Text) || !string.IsNullOrWhiteSpace(TxtUserID.Text) || !string.IsNullOrWhiteSpace(TxtPassword.Text) || !string.IsNullOrWhiteSpace(TxtCreateNewDB.Text))
                    {
                        string DatabaseInfoTextFilePath = Path.Combine(Application.StartupPath, "SQLConnectionInfo.txt");
                        string ItemFilePath = Path.Combine(Application.StartupPath, "Images", "Item Image");
                        string ServerName = objAPI.Encrypt(TxtServerName.Text.Trim());
                        string UserID = objAPI.Encrypt(TxtUserID.Text.Trim());
                        string Password = objAPI.Encrypt(TxtPassword.Text.Trim());
                        string DatabaseName = string.Empty;
                        if (ChkCreateNewDB.Checked == true)
                        {
                            DatabaseName = objAPI.Encrypt(TxtCreateNewDB.Text.Trim());

                            string ConnectionString = $"Server={TxtServerName.Text.Trim()}; Database=MASTER; User Id={TxtUserID.Text.Trim()}; Password={TxtPassword.Text.Trim()}; Connect Timeout = 10;";
                            SqlConnection conn = new SqlConnection(ConnectionString);
                            string StrSelect = $"SELECT name AS Databasename FROM sys.databases WHERE name = '{TxtCreateNewDB.Text.Trim()}'";
                            SqlCommand cmd = new SqlCommand(StrSelect, conn);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            sda.Fill(ds);
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                MessageBox.Show("Invalid Name.\n" + "The database already exist");
                            }
                            else if (ds.Tables[0].Rows.Count <= 0)
                            {
                                objAPI.SaveSQLServerConnection(true, DatabaseInfoTextFilePath, objAPI.Decrypt(ServerName), objAPI.Decrypt(UserID), objAPI.Decrypt(Password), objAPI.Decrypt(DatabaseName));
                                ConnectionString = $"Server={TxtServerName.Text.Trim()}; Database={TxtCreateNewDB.Text.Trim()}; User Id={TxtUserID.Text.Trim()}; Password={TxtPassword.Text.Trim()}; Connect Timeout = 10;";
                                conn = new SqlConnection(ConnectionString);
                                objAPI.InsertDefaultItem(ItemFilePath, conn);
                            }
                            MessageBox.Show("Saved");
                            this.Hide();
                            FRMLogin frm1 = new FRMLogin();
                            frm1.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Fill All The Blank Information");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChkExistingDB_CheckedChanged(object sender, EventArgs e)
        {
            TxtCreateNewDB.Enabled = false;

        }
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtServerName.Focus();
            }
        }
    }
}
