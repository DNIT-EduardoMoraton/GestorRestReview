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
            return articuloDAO.GetAllArticulos();
        }

        public Articulo GetArticuloById(int id)
        {
            return articuloDAO.GetOneArticulo(id);
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
    }
}
