using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using GestorRestReview.Modelo;
using Microsoft.Data.Sqlite;

namespace GestorRestReview.BD
{
    public class DAOAutores
    {
        private SQLiteConnection conexion;
        private string _connectionString;

        public DAOAutores()
        {
            // Inicializar la conexión con la base de datos SQLite
            _connectionString = "Data Source=BDRevista.db";
            conexion = new SQLiteConnection(_connectionString);
            conexion.Open();
        }

        public void Close()
        {
            conexion.Close();
        }

        // Método para obtener todos los autores de la base de datos
        public List<Autor> GetAllAutores()
        {
            List<Autor> autores = new List<Autor>();
            string query = "SELECT * FROM Autores";
            SqliteCommand command = new SqliteCommand(query, conexion);
            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                string imagen = reader.GetString(2);
                string nickName = reader.GetString(3);
                string redsocial = reader.GetString(4);


                autores.Add(new Autor(id, nombre, imagen, nickName, redsocial));
            }

            reader.Close();
            return autores;
        }


        public Autor GetOneAutor(int id)
        {
            using (SqliteConnection connection = new SqliteConnection(conexion))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT * FROM Autores WHERE id = @id";
                    command.Parameters.AddWithValue("@id", id);

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idAutor = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string imagen = reader.GetString(2);
                            string nickName = reader.GetString(3);
                            string redsocial = reader.GetString(4);

                            return new Autor(idAutor, nombre, imagen, nickName, redsocial);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

            // Método para insertar un nuevo autor en la base de datos
            public void InsertAutor(Autor autor)
        {
            string query = "INSERT INTO Autores (nombre, imagen, nickName, redSocial) " +
                           "VALUES (@nombre, @imagen, @nickName, @redSocial)";
            SQLiteCommand command = new SQLiteCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", autor.Nombre);
            command.Parameters.AddWithValue("@imagen", autor.Imagen);
            command.Parameters.AddWithValue("@nickName", autor.NickName);
            command.Parameters.AddWithValue("@redSocial", autor.Redsocial);

            command.ExecuteNonQuery();
        }

        // Método para actualizar un autor existente en la base de datos
        public void UpdateAutor(Autor autor)
        {
            string query = "UPDATE Autores SET nombre=@nombre, imagen=@imagen, nickName=@nickName, redSocial=@redSocial " +
                           "WHERE id=@id";
            SQLiteCommand command = new SQLiteCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", autor.Nombre);
            command.Parameters.AddWithValue("@imagen", autor.Imagen);
            command.Parameters.AddWithValue("@nickName", autor.NickName);
            command.Parameters.AddWithValue("@id", autor.Id);
            command.Parameters.AddWithValue("@redSocial", autor.Redsocial);

            command.ExecuteNonQuery();
        }


        public int DeleteAutor(int id)
        {
            int result = 0;
            using (SQLiteCommand command = new SQLiteCommand(conexion))
            {
                command.CommandText = "DELETE FROM Autores WHERE id = @id";
                command.Parameters.AddWithValue("@id", id);
                result = command.ExecuteNonQuery();
            }
            return result;
        }
    }
}


