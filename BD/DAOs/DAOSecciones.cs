using GestorRestReview.Modelo;
using GestorRestReview.Servicios;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.BD.DAOs
{
    class DAOSecciones
    {
        private BDRevista bd;
        private AlertaServicio servicioAlerta;
        public DAOSecciones()
        {
            bd = new BDRevista();
            servicioAlerta = new AlertaServicio();
        }

        public int insert(SeccionEntity seccion)
        {
            SqliteConnection con = bd.getNewConnection();
            int result = -1;

            try
            {
                con.Open();

                string sql = "INSERT INTO Secciones (nombre, descripcion) " +
                             "VALUES (@nombre, @descripcion)";

                SqliteCommand command = new SqliteCommand(sql, con);
                command.Parameters.AddWithValue("@nombre", seccion.Nombre);
                command.Parameters.AddWithValue("@descripcion", seccion.Descripcion);

                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                servicioAlerta.MessageBoxError(e.Message);
            }
            finally
            {
                con.Close();
            }

            return result;

        }

    }
}
