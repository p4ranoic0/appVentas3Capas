using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_ADO
{
    public class ProveedorADO
    {
        private ConexionADO MiConexion;

        public ProveedorADO() { MiConexion = new ConexionADO(); }
        
        public DataTable ListarProveedores()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarProveedoresActivos";
                try
                {
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Proveedor");
                    ada.Fill(dt);
                    return dt;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (cnx.State == ConnectionState.Open)
                    {
                        cnx.Close();
                    }
                }
            }
        }
    }
}
