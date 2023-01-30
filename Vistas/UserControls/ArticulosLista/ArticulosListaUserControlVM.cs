using GestorRestReview.Modelo;
using GestorRestReview.Servicios;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.Vistas.UserControls.ArticulosLista
{
    class ArticulosListaUserControlVM :  ObservableRecipient
    {
        // Getters y Setters

        private Articulo articuloActual;

        public Articulo ArticuloActual
        {
            get { return articuloActual; }
            set { SetProperty(ref articuloActual, value); }
        }


        // Commands

        public RelayCommand AnyadirArticuloCommand { get; set; }

        // Services

        private NavegacionServicio servicioNavegacion;

        public ArticulosListaUserControlVM()
        {

        }

    }
}
