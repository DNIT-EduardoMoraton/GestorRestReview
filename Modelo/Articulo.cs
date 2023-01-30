using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.Modelo
{
    public class Articulo : ObservableObject
    {

        // Ver como de factible es de poner aqui una propiedad que contenga un objeto Autor al que hace refencia
        // Getters y Setters
        private int id;

        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        // Hacer para el resto de las propiedades y objetos

        private int idAutor;
        private int idSeccion;
        private string texto;
        private string titulo;
        private string imagen;

        public Articulo()
        {
        }



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


        // To String y demas metodos de utilidad son necesarios



    }
}
