using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccsessLogic
{
    public class Dall_Inventario
    {
        private string connectionString = "Data Source=DESKTOP-3E5G8UC;Initial Catalog=BaseAbm;Integrated Security=True";

        public DataTable Mostrar_Inventario()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Inventario";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public bool Agregar_Articulo(Inventario inventario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Inventario (id_articulo, Nombre_Articulo, Descripccion, Marca, Precio, Stock) VALUES (@id_articulo, @Nombre_Articulo, @Descripccion, @Marca, @Precio, @Stock)";
                SqlCommand cmd =new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_articulo", inventario.id_articulo);
                cmd.Parameters.AddWithValue("@Nombre_Articulo", inventario.Nombre_Articulo);
                cmd.Parameters.AddWithValue("@Descripccion", inventario.Descripccion);
                cmd.Parameters.AddWithValue("@Marca", inventario.Marca);
                cmd.Parameters.AddWithValue("@Precio", inventario.Precio);
                cmd.Parameters.AddWithValue("@Stock", inventario.Stock);
                int filasafectadas = cmd.ExecuteNonQuery();
                return filasafectadas > 0;
            }
        }
        public bool Eliminar_Articulo(int idarticulo) 
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Inventario WHERE id_articulo =@id_articulo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id_articulo",idarticulo);
                int filasafectadas = cmd.ExecuteNonQuery();
                return filasafectadas > 0;
            }
        }
        public bool Modificar_Articulo(Inventario inventario)
        {
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Inventario SET Nombre_Articulo = @Nombre_Articulo, Descripccion = @Descripccion, Marca = @Marca, Precio = @Precio, Stock = @Stock WHERE id_articulo = @id_articulo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_articulo", inventario.id_articulo);
                    cmd.Parameters.AddWithValue("@Nombre_Articulo", inventario.Nombre_Articulo);
                    cmd.Parameters.AddWithValue("@Descripccion", inventario.Descripccion);
                    cmd.Parameters.AddWithValue("@Marca", inventario.Marca);
                    cmd.Parameters.AddWithValue("@Precio", inventario.Precio);
                    cmd.Parameters.AddWithValue("@Stock", inventario.Stock);
                    int filasafectadas = cmd.ExecuteNonQuery();
                    return filasafectadas > 0;
                }
            }
        }
        public bool ArticuloRepetido(int idarticulo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Inventario WHERE id_articulo = @id_articulo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_articulo", idarticulo);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}