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
    public class RepartidorADO
    {
        private ConexionADO MiConexion;

        public RepartidorADO() { MiConexion = new ConexionADO(); }
        SqlDataReader dtr;

        public bool InsertarRepartidor(RepartidorBE repartidorBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Insertarrepartidor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombres", repartidorBE.Nom_repartidor);
                cmd.Parameters.AddWithValue("@apellidos", repartidorBE.Ape_repartidor);
                cmd.Parameters.AddWithValue("@dni", repartidorBE.Dni_repartidor);
                cmd.Parameters.AddWithValue("@email", repartidorBE.Correo_repartidor);
                cmd.Parameters.AddWithValue("@telefono", repartidorBE.Correo_repartidor);
                cmd.Parameters.AddWithValue("@FechaNacimiento", repartidorBE.Fecha_nac);
                cmd.Parameters.AddWithValue("@EstadoRepartidor", repartidorBE.Est_repartidor);

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
        public bool ModificarRepartidor(RepartidorBE repartidorBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ModificarRepartidor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idRepartidor",repartidorBE.Id_repartidor.ToString());
                cmd.Parameters.AddWithValue("@nombres", repartidorBE.Nom_repartidor);
                cmd.Parameters.AddWithValue("@apellidos", repartidorBE.Ape_repartidor);
                cmd.Parameters.AddWithValue("@dni", repartidorBE.Dni_repartidor);
                cmd.Parameters.AddWithValue("@email", repartidorBE.Correo_repartidor);
                cmd.Parameters.AddWithValue("@telefono", repartidorBE.Tel_repartidor);
                cmd.Parameters.AddWithValue("@FechaNacimiento", repartidorBE.Fecha_nac);
                cmd.Parameters.AddWithValue("@EstadoRepartidor", repartidorBE.Est_repartidor);

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
        public bool BajaRepartidor(int cod)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BajaRepartidor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idRepartidor", cod);
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
        public DataTable ListarRepartidor()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarRepartidores";
                try
                {
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Repartidor");
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
        public DataTable ListarRepartidoresPorEstado(int est)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarRepartidoresPorEstado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@estadoRepartidor", est);
                try
                {
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Repartidor");
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

        public RepartidorBE RepartidorPorId(int cod)
        {
            RepartidorBE repartidorBE = new RepartidorBE();
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_RepartidorPorId";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idRepartidor", cod);

                try
                {
                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    if (dtr.HasRows)
                    {
                        dtr.Read();
                        repartidorBE.Id_repartidor = Convert.ToInt16(dtr["id_repartidor"].ToString());
                        repartidorBE.Nom_repartidor = dtr["nom_repartidor"].ToString();
                        repartidorBE.Ape_repartidor = dtr["ape_repartidor"].ToString();
                        repartidorBE.Dni_repartidor = dtr["dni_repartidor"].ToString();
                        repartidorBE.Correo_repartidor = dtr["correo_repartidor"].ToString();
                        repartidorBE.Fecha_nac = Convert.ToDateTime(dtr["fecha_nac"].ToString());
                        repartidorBE.Tel_repartidor= (dtr["tel_repartidor"].ToString());

                        repartidorBE.Id_repartidor = Convert.ToInt16(dtr["id_repartidor"].ToString());

                    }
                    dtr.Close();
                    return repartidorBE;


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
