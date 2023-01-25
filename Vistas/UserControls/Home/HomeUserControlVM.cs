using GestorRestReview.Servicios;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GestorRestReview.Vistas.UserControls.Home
{
    class HomeUserControlVM : ObservableRecipient
    {
        private UserControl actualUserControl;

        public UserControl ActualUserControl
        {
            get { return actualUserControl; }
            set { SetProperty(ref actualUserControl, value); }
        }

        // Commands

        private RelayCommand ArticuloComand { get; set; }

        // Services

        private NavegacionServicio servicioNavegacion;

        public HomeUserControlVM()
        {
            servicioNavegacion = new NavegacionServicio();
            InicioPorDefecto();


            ManejadorCommands();
        }

        private void InicioPorDefecto()
        {
            ActualUserControl = servicioNavegacion.IrHomeWebPreview();
        }

        private void ManejadorCommands()
        {
            ArticuloComand = new RelayCommand(ArticuloCommandFun);
        }

        // Commands Funcs

        private void ArticuloCommandFun()
        {
            ActualUserControl = servicioNavegacion.IrArticulosUserControl(); // ver que no se tiene que eliminar
        }
    }
}
