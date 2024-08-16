using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace DataAccsessLogic
{
    public class Dall_Usuarios
    {
        private string connectionString = "Data Source=DESKTOP-3E5G8UC;Initial Catalog=BaseAbm;Integrated Security=True";

        public bool ValidarUsuarios(string mail, string password) 
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email AND Contraseña = @Contraseña";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", mail);
                    cmd.Parameters.AddWithValue("@Contraseña", password);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool Argregar_Usuario(string mail,string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Usuarios (Email, Contraseña) VALUES (@Email, @Contraseña)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", mail);
                        cmd.Parameters.AddWithValue("@Contraseña", password);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar usuario: {ex.Message}");
                return false;
            }
        }
        
    }
}
