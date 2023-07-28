using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quipu_BE;

namespace Quipu_ADO
{
    public class ClienteADO
    {
        private ConexionADO MiConexion;
        SqlDataReader dtr;
        public ClienteADO() { MiConexion = new ConexionADO(); }


        public Boolean InsertarCliente(ClienteBE clienteBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombres",clienteBE.Nom_cliente);
                cmd.Parameters.AddWithValue("@apellidos", clienteBE.Ape_cliente);
                cmd.Parameters.AddWithValue("@dni", clienteBE.Dni_cliente);
                cmd.Parameters.AddWithValue("@email", clienteBE.Correo_cliente);
                cmd.Parameters.AddWithValue("@direccion", clienteBE.Dir_cliente);
                cmd.Parameters.AddWithValue("@telefono", clienteBE.Tel_cliente);
                cmd.Parameters.AddWithValue("@estadoCliente", clienteBE.Est_cliente);

                try
                {
                 cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally {
                    if (cnx.State ==ConnectionState.Open) {
                        cnx.Close();
                    }
                }
            }

        }
        public bool ModificarCliente(ClienteBE clienteBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ModificarCliente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", clienteBE.Id_cliente);
                cmd.Parameters.AddWithValue("@nombres", clienteBE.Nom_cliente);
                cmd.Parameters.AddWithValue("@apellidos", clienteBE.Ape_cliente);
                cmd.Parameters.AddWithValue("@dni", clienteBE.Dni_cliente);
                cmd.Parameters.AddWithValue("@email", clienteBE.Correo_cliente);
                cmd.Parameters.AddWithValue("@direccion", clienteBE.Dir_cliente);
                cmd.Parameters.AddWithValue("@telefono", clienteBE.Tel_cliente);
                cmd.Parameters.AddWithValue("@estadoCliente", clienteBE.Est_cliente);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;
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
        public bool BajaCliente(int codCliente)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ModificarCliente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", codCliente);
               
                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;
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

       

        public DataTable ListarCliente()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarClientes";
                try
                {
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("cliente");
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

        public DataTable ListarClientePorEstado(int est)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
               
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarClientesPorEstado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@estadoCliente", est);
                try
                {
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("cliente");
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

        public ClienteBE ConsultarCliente(int codCliente)
        {
            ClienteBE objClienteBE= new ClienteBE();
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ClientePorId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", codCliente);
                try
                {
                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    if (dtr.HasRows == true)
                    {
                        //Leemos registro y lo devolvemos en objClienteBE
                        dtr.Read();
                        objClienteBE.Id_cliente = Convert.ToInt16(dtr["id_cliente"].ToString());
                        objClienteBE.Nom_cliente = dtr["nom_cliente"].ToString();
                        objClienteBE.Ape_cliente = dtr["ape_cliente"].ToString();
                        objClienteBE.Dni_cliente = dtr["dni_cliente"].ToString();
                        objClienteBE.Correo_cliente = dtr["correo_cliente"].ToString();
                        objClienteBE.Dir_cliente = dtr["dir_cliente"].ToString();
                        objClienteBE.Tel_cliente = dtr["tel_cliente"].ToString();
                        objClienteBE.Est_cliente = Convert.ToBoolean(dtr["est_cliente"]);

                    }
                    dtr.Close();
                    return objClienteBE;


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
