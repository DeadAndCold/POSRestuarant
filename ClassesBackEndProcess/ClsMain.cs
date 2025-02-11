using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestuarantBackEnd.SQLServer;

namespace POSRestuarant.ClassesBackEndProcess
{
    public class ClsMain
    {
        public static string _UserID;
        public static string _Username;
        public static string _Password;
        public static string _Permission;
        public static SqlConnection conn;
        public SqlConnection GetSQLConnection()
        {
            InitializeSQLServer objAPIConn = new InitializeSQLServer();
            conn = objAPIConn.GetConnection(Path.Combine(Application.StartupPath, "SQLConnectionInfo.txt"));
            return conn;
        }
    }
}
