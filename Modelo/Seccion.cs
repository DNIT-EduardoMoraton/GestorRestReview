using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace GestorRestReview.Modelo
{
    public class Seccion : ObservableObject
    {
        // Getters y Setters
        // Investigar como de posible es de usar aqui un arraylist que se complete cuando se hace una llmada al DAO para poder usar un mismo objeto Seccion para ver todos los articulos

        private int id;
        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { SetProperty(ref descripcion, value); }
        }

        public Seccion()
        {
        }

        public Seccion(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

       
    }


}
