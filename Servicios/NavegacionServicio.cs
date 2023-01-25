using GestorRestReview.Vistas.UserControls.Articulos;
using GestorRestReview.Vistas.UserControls.Home;
using GestorRestReview.Vistas.UserControls.HomeWebPreview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.Servicios
{
    class NavegacionServicio
    {
        public NavegacionServicio()
        {
            
        }


        public HomeUserControl IrHomeUSerControl() // Usado desde main window
        {
            return new HomeUserControl();
        }
        public ArticulosUserControl IrArticulosUserControl()
        {
            return new ArticulosUserControl();
        }

        public HomeWebPreview IrHomeWebPreview()
        {
            return new HomeWebPreview();
        } 

        
    }
}
