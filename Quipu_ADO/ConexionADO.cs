using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_ADO
{
    public class ConexionADO
    {
        public string GetCnx()
        {
            string strCnx =
                ConfigurationManager.ConnectionStrings["Quipu"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }
        }

        public SqlConnection GetSqlConnection()
        {
            string connectionString = GetCnx();
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
