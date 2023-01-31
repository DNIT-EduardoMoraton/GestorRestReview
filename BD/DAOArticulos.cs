using GestorRestReview.Modelo;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace GestorRestReview
{
    public class DAOArticulos
    {
        private string _connectionString;
        SQLiteConnection connection;

        public DAOArticulos()
        {
            _connectionString = "Data Source=BDRevista.db";
            connection = new SQLiteConnection(_connectionString);
            connection.Open();
        }

        public List<Articulo> GetAllArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            string sql = "SELECT * FROM Articulo;";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                int idAutor = Convert.ToInt32(reader["idAutor"]);
                int idSeccion = Convert.ToInt32(reader["idSeccion"]);
                string titulo = reader["titulo"].ToString();
                string imagen = reader["imagen"].ToString();
                string texto = reader["texto"].ToString();

                articulos.Add(new Articulo(id, idAutor, idSeccion, titulo, imagen, texto));
            }
            Console.WriteLine(articulos.ToString());
            return articulos;
        }

        public Articulo GetOneArticulo(int id)
        {
            Articulo articulo = null;
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = "SELECT * FROM articulos WHERE id = @id";
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        articulo = new Articulo();
                        articulo.Id = reader.GetInt32(0);
                        articulo.IdAutor = reader.GetInt32(1);
                        articulo.IdSeccion = reader.GetInt32(2);
                        articulo.Titulo = reader.GetString(3);
                        articulo.Texto = reader.GetString(4);
                        articulo.Imagen = reader.GetString(5);
                    }
                }
            }
            return articulo;
        }

        public void InsertarArticulo(Articulo articulo)
        {
            // Inserta un nuevo articulo en la tabla
            string sql = "INSERT INTO articulos (idAutor, idSeccion, titulo, texto, imagen) VALUES (@idAutor, @idSeccion, @titulo, @texto, @imagen)";
            SQliteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.AddWithValue("@idAutor", articulo.IdAutor);
            command.Parameters.AddWithValue("@idSeccion", articulo.IdSeccion);
            command.Parameters.AddWithValue("@titulo", articulo.Titulo);
            command.Parameters.AddWithValue("@texto", articulo.Texto);
            command.Parameters.AddWithValue("@imagen", articulo.Imagen);
            command.ExecuteNonQuery();
        }


        public void UpdateArticulo(Articulo articulo)
        {
            // Actualiza un articulo existente en la tabla
            string sql = "UPDATE articulos SET idAutor = @idAutor, idSeccion = @idSeccion, titulo = @titulo, texto = @texto, imagen = @imagen WHERE id = @id";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.AddWithValue("@idAutor", articulo.IdAutor);
            command.Parameters.AddWithValue("@idSeccion", articulo.IdSeccion);
            command.Parameters.AddWithValue("@titulo", articulo.Titulo);
            command.Parameters.AddWithValue("@texto", articulo.Texto);
            command.Parameters.AddWithValue("@imagen", articulo.Imagen);
            command.Parameters.AddWithValue("@id", articulo.Id);
            command.ExecuteNonQuery();
        }

        public int DeleteArticulo(int id)
        {
            int rowsAffected = 0;
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = "DELETE FROM articulos WHERE id = @id";
                command.Parameters.AddWithValue("@id", id);
                rowsAffected = command.ExecuteNonQuery();
            }
            return rowsAffected;
        }

    }
}
