using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.Modelo
{
    public class Autor : ObservableObject
    {
        // Getters y Setters

        private int id;

        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        private string nombre;
        private string imagen;
        private string nickName;
        private string redsocial;



        // Constructor
        public Autor(int id, string nombre, string imagen, string nickName, string redsocial)
        {
            this.id = id;
            this.nombre = nombre;
            this.imagen = imagen;
            this.nickName = nickName;
            this.redsocial = redsocial;
        }


    }



}
