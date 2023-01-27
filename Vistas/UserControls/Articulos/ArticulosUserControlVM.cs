using GestorRestReview.Servicios;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GestorRestReview.Vistas.UserControls.Articulos
{
    class ArticulosUserControlVM : ObservableRecipient
    {
        private UserControl currUserControl;

        public UserControl CurrUserControl
        {
            get { return currUserControl; }
            set { SetProperty(ref currUserControl, value); }
        }

        // Commands



        // Services

        private NavegacionServicio servicioNavegacion;


        public ArticulosUserControlVM()
        {
            servicioNavegacion = new NavegacionServicio();
            InicioPorDefecto();
            
        }

        private void InicioPorDefecto()
        {
            CurrUserControl = servicioNavegacion.irArticulosListaUserControl();
        }
    }
}
