using Quipu_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_ADO
{
    public class UsuarioADO
    {
        private ConexionADO MiConexion;

        public UsuarioADO() { MiConexion = new ConexionADO(); }
        SqlDataReader dtr;

        public UsuarioBE LoginUsuario(String email)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                UsuarioBE usuarioBE = new UsuarioBE();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_VerificarUsuario";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        usuarioBE.Id_usuario = Convert.ToInt16(dtr["id_usuario"].ToString());
                        usuarioBE.Nom_usuario = dtr["nom_usuario"].ToString();
                        usuarioBE.Correo_usuario = dtr["correo_usuario"].ToString();
                        usuarioBE.Contrasena = dtr["contrasena"].ToString();
                        usuarioBE.Fecha_registro = Convert.ToDateTime(dtr["fecha_Registro"]);
                        usuarioBE.Fecha_ult_con = Convert.ToDateTime(dtr["fecha_ult_con"]);
                        usuarioBE.Rol = dtr["rol"].ToString();
                        usuarioBE.Est_usuario = Convert.ToBoolean(dtr["est_usuario"]);
                    }
                    
                    dtr.Close();
                    return usuarioBE;
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

        public void ActualizarConexion(string email)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                UsuarioBE usuarioBE = new UsuarioBE();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ActualizarConexion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();                    
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