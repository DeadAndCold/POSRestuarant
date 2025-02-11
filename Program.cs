using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestuarant.FormUI.FRMRegisterDatabase;
using POSRestuarantBackEnd;

namespace POSRestuarant
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseRegisterInfo objAPI = new DatabaseRegisterInfo();

            string DatabaseInfoTextFile = Path.Combine(Application.StartupPath, "SQLConnectionInfo.txt");
            if (!File.Exists(DatabaseInfoTextFile))
            {
                Application.Run(new FRMRegisteration());
            }
            else if (File.Exists(DatabaseInfoTextFile))
            {
                string DatabaseName = string.Empty;
                FileAttributes attributes = File.GetAttributes(DatabaseInfoTextFile);
                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    string[] lines = File.ReadAllLines(DatabaseInfoTextFile);
                    string Server = objAPI.Decrypt(lines[0]);
                    string UserID = objAPI.Decrypt(lines[1]);
                    string Password = objAPI.Decrypt(lines[2]); 
                    DatabaseName = objAPI.Decrypt(lines[3]);

                    string ConnectionString = $"Server={Server.Trim()}; Database={DatabaseName.Trim()}; User Id={UserID.Trim()}; Password={Password.Trim()}; Connect Timeout = 10;";
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    try
                    {
                        conn.Open();
                        if (conn.State == System.Data.ConnectionState.Open)
                        {
                            Application.Run(new FRMLogin());
                        }
                    }
                    catch (SqlException ex)
                    {
                        File.Delete(DatabaseInfoTextFile);
                        MessageBox.Show($"Failed to connect to SQL Server. Error: {ex.Message}", "Connection Error");
                        Application.Run(new FRMRegisteration());
                    }
                    finally
                    {
                        if (conn.State == System.Data.ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
    }
}
