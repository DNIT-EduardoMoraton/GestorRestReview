using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.Modelo
{
    class Articulo
    {
        private int id;
        private int idAutor;
        private int idSeccion;
        private string texto;
        private string titulo;
        private string imagen;

        // Constructor
        public Articulo(int id, int idAutor, int idSeccion, string texto, string titulo, string imagen)
        {
            this.id = id;
            this.idAutor = idAutor;
            this.idSeccion = idSeccion;
            this.texto = texto;
            this.titulo = titulo;
            this.imagen = imagen;
        }

        // Getters y Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }

        public int IdSeccion
        {
            get { return idSeccion; }
            set { idSeccion = value; }
        }

        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
    }
}
