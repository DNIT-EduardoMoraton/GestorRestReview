using GestorRestReview.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.BD
{
    public class AutoresService
    {
        private DAOAutores autorDAO;

        public AutoresService()
        {
            autorDAO = new DAOAutores();
        }

        public void InsertAutor(Autor autor)
        {
            autorDAO.InsertAutor(autor);
        }

        public void UpdateAutor(Autor autor) 
        {
            autorDAO.UpdateAutor(autor);
        }

        public int DeleteAutor(int id) 
        {
            return autorDAO.DeleteAutor(id);
        }

        public Autor GetAutor(int id)
        {
            return autorDAO.GetOneAutor(id); // Que tenga una lista de articulos
        }

        public List<Autor> GetAllAutores()
        {
            return autorDAO.GetAllAutores(); // Que cada uno de los autores tenga una lista de Articulos
        }


        
        
    }
}
