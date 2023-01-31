using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.Vistas.UserControls.HomeWebPreview
{
    class HomeWebPreviewUserControlVM : ObservableRecipient
    {
        private string hTMLRuta;

        public string HTMLRuta
        {
            get { return hTMLRuta; }
            set { SetProperty(ref hTMLRuta, value); }
        }

        // Commands

        public RelayCommand ArticuloComand { get; set; } // Son solo muestras no son de aqui
        public RelayCommand HomeWebPreview { get; set; }

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
            ActualUserControl = servicioNavegacion.IrHomeWebPreviewUserControl();

        }

        private void ManejadorCommands()
        {
            ArticuloComand = new RelayCommand(ArticuloCommandFun);
            HomeWebPreview = new RelayCommand(HomeWebPreviewFun);
        }

        // Commands Funcs



        private void HomeWebPreviewFun()
        {

        }
    }
}
