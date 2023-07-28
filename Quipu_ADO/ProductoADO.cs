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
    public class ProductoADO
    {
        private ConexionADO MiConexion;

        public ProductoADO() { MiConexion = new ConexionADO(); }
        SqlDataReader dtr;
        public bool InsertarProducto(ProductoBE productoBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreProducto", productoBE.Nom_producto);
                cmd.Parameters.AddWithValue("@descripcion", productoBE.Descripcion);
                cmd.Parameters.AddWithValue("@precio", productoBE.Precio);
                cmd.Parameters.AddWithValue("@peso", productoBE.Peso);
                cmd.Parameters.AddWithValue("@idProveedor", productoBE.Id_proveedor);

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
        public bool ModificarProducto(ProductoBE productoBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ModificarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", productoBE.Id_producto);
                cmd.Parameters.AddWithValue("@nombreProducto", productoBE.Nom_producto);
                cmd.Parameters.AddWithValue("@descripcion", productoBE.Descripcion);
                cmd.Parameters.AddWithValue("@precio", productoBE.Precio);
                cmd.Parameters.AddWithValue("@peso", productoBE.Peso);
                cmd.Parameters.AddWithValue("@EstadoProducto", productoBE.Est_producto);
                cmd.Parameters.AddWithValue("@idProveedor", productoBE.Id_proveedor);

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
        public bool BajaProducto(int codProducto)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BajaProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", codProducto);
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


        public DataTable ListarProducto()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarProductos";
                try
                {
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Producto");
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

        public DataTable ListarProductoPorEstado()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarProductosPorEstado";
                try
                {
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Productos");
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

      

        public ProductoBE ProductoPorId(int codProducto)
        {
            ProductoBE ProductoBE = new ProductoBE();
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ProductoPorId";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", codProducto);

                try
                {
                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    if (dtr.HasRows)
                    {
                        dtr.Read();
                        ProductoBE.Id_producto = Convert.ToInt16(dtr["id_Producto"].ToString());
                        ProductoBE.Nom_producto = dtr["nom_Producto"].ToString();
                        ProductoBE.Descripcion = dtr["descripcion"].ToString();
                        ProductoBE.Precio = Convert.ToDouble(dtr["precio"].ToString());
                        ProductoBE.Peso = Convert.ToDouble(dtr["peso"].ToString());
                        ProductoBE.Est_producto = Convert.ToBoolean(dtr["est_producto"]);
                        ProductoBE.Id_proveedor= Convert.ToInt16(dtr["id_proveedor"].ToString());

                    }
                    dtr.Close();
                    return ProductoBE;


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
