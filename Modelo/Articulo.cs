using Microsoft.Toolkit.Mvvm.ComponentModel;
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
        private int idAutor;
        private int idSeccion;
        private String texto;
        private String titulo;
        private String imagen;
    }
}
