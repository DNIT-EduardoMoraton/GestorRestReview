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
        // Todo el servicio debe devolver un booleano o un objeto o lista de objetos o en su defecto Null

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

        public void DeleteSeccion(int id)
        {
            seccionDAO.DeleteSeccion(id);
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
