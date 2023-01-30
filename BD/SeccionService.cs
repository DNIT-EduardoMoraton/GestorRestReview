using GestorRestReview.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.BD
{
    class SeccionService
    {
        private DAOSeccion seccionDAO;

        public SeccionService()
        {
            seccionDAO = new DAOSeccion();
        }

        public void InsertSeccion(Seccion seccion)
        {
            seccionDAO.InsertSeccion(seccion);
        }

        public void UpdateSeccion(Seccion seccion)
        {
            seccionDAO.UpdateSeccion(seccion);
        }

        public int DeleteSeccion(int id)
        {
            return seccionDAO.DeleteSeccion(id);
        }

        public Seccion GetSeccion(int id)
        {
            return seccionDAO.GetSeccion(id);
        }

        public List<Seccion> GetAllSecciones()
        {
            return seccionDAO.GetAllSecciones();
        }
    }
}
