using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ManagementEmployees
{
    internal class Connection
    {
       private static string connectString = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=ManagementEmployees;Integrated Security=True";
       
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectString);
        }

    }
}
