using GestorRestReview.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview
{
    public class ClienteDAL
    {
        private string _connectionString;

        public ClienteDAL()
        {
            _connectionString = "Data Source=BDRevista.db";
        }

        public List<Articulo> GetAllClientes()
        {
            List<Articulo> articulos = new List<Articulo>();

            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Articulo";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    int idAutor = Convert.ToInt32(reader["IdAutor"]);
                    int idSeccion = Convert.ToInt32(reader["IdSeccion"]);
                    string titulo = reader["Titulo"].ToString();
                    string imagen = reader["Imagen"].ToString();
                    string texto = reader["Texto"].ToString();

                    articulos.Add(new Articulo(id, idAutor, idSeccion, titulo, imagen,texto));
                }
            }
            Console.WriteLine(articulos.ToString());
            return articulos;
        }

        /*public void AddCliente(Cliente cliente)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO clientes (nombre, apellido, email) VALUES (@nombre, @apellido, @email)";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@email", cliente.Email);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateCliente(Cliente cliente)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, email = @email WHERE id = @id";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@email", cliente.Email);
                command.Parameters.AddWithValue("@id", cliente.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCliente(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM clientes WHERE id = @id";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }*/
    }
}
