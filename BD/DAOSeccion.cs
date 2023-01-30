using GestorRestReview.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.BD
{
    public class DAOSeccion
    {
        private SQLiteConnection connection;
        private string _connectionString;


        public DAOSeccion()
        {
            _connectionString = "Data Source=BDRevista.db";
            connection = new SQLiteConnection(_connectionString);
            connection.Open();
        }

        public Seccion GetSeccion(int id)
        {
            Seccion seccion = null;
            using (SQLiteConnection conexion = new SQLiteConnection(_connectionString))
            {
                conexion.Open();
                string sql = "SELECT * FROM Secciones WHERE id=@id";
                using (SQLiteCommand comando = new SQLiteCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            seccion = new Seccion
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Descripcion = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            return seccion;
        }



        public List<Seccion> GetAllSecciones()
        {
            List<Seccion> listaSecciones = new List<Seccion>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(_connectionString))
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Seccion", con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Seccion seccion = new Seccion
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Nombre = Convert.ToString(reader["Nombre"]),
                                    Descripcion = Convert.ToString(reader["Descripcion"])
                                };
                                listaSecciones.Add(seccion);
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaSecciones;
        }

        public void InsertSeccion(Seccion seccion)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO secciones (nombre, descripcion) VALUES (@nombre, @descripcion)";
                command.Parameters.AddWithValue("@nombre", seccion.Nombre);
                command.Parameters.AddWithValue("@descripcion", seccion.Descripcion);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine("Error al insertar la sección: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void UpdateSeccion(Seccion seccion)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE secciones SET nombre = @nombre, descripcion = @descripcion WHERE id = @id";
                command.Parameters.AddWithValue("@nombre", seccion.Nombre);
                command.Parameters.AddWithValue("@descripcion", seccion.Descripcion);
                command.Parameters.AddWithValue("@id", seccion.Id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine("Error al actualizar la sección: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeleteSeccion(Seccion seccion)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM secciones WHERE id = @id";
                command.Parameters.AddWithValue("@id", seccion.Id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine("Error al eliminar la sección: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }




    }
}
