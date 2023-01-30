using GestorRestReview.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.BD
{
    class ArticuloService
    {
        private DAOArticulos articuloDAO;

        public ArticuloService()
        {
            articuloDAO = new DAOArticulos();
        }

        public List<Articulo> GetAllArticulos()
        {
            return articuloDAO.GetAllArticulos(); // Igual que en el get one
        }

        public Articulo GetArticuloById(int id)
        {
            return articuloDAO.GetOneArticulo(id); // Anyadir un campo autor que se complete desde aqui para poder acceder al autor
        }

        public void InsertArticulo(Articulo articulo)
        {
           articuloDAO.InsertarArticulo(articulo);
        }

        public void UpdateArticulo(Articulo articulo)
        {
           articuloDAO.UpdateArticulo(articulo);
        }

        public void DeleteArticulo(int id)
        {
            articuloDAO.DeleteArticulo(id);
        }

        // Necesitamos 
        // Todos los articulos de una categoria ordenados por fecha de adicion a la base de datos
    }
}
