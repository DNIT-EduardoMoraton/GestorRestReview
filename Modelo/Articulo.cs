
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.Modelo
{
    class Articulo : ObservableObject
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        private int autor;

        public int Autor
        {
            get { return autor; }
            set { SetProperty(ref autor, value); }
        }

        private int idSeccion;

        public int IdSeccion
        {
            get { return idSeccion; }
            set { SetProperty(ref idSeccion, value); }
        }

        private string texto;

        public string Texto
        {
            get { return texto; }
            set { SetProperty(ref texto, value); }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { SetProperty(ref titulo, value); }
        }

        private string imagen;

        public string Imagen
        {
            get { return imagen; }
            set { SetProperty(ref imagen, value); }
        }

        public DateTime fechaPublicacion;
        public DateTime FechaPublicacion
        {
            get { return fechaPublicacion; }
            set { SetProperty(ref fechaPublicacion, value); }
        }

        public Articulo(int id, int autor, int idSeccion, string texto, string titulo, string imagen, DateTime fechaPublicacion)
        {
            Id = id;
            Autor = autor;
            IdSeccion = idSeccion;
            Texto = texto;
            Titulo = titulo;
            Imagen = imagen;
            FechaPublicacion = fechaPublicacion;
        }
    }
}
