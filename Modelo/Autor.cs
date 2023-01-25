using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestReview.Modelo
{
    public class Autor
    {
        private int id;
        private string nombre;
        private string imagen;
        private string nickName;

        // Constructor
        public Autor(int id, string nombre, string imagen, String nickName)
        {
            this.id = id;
            this.nombre = nombre;
            this.imagen = imagen;
            this.nickName = nickName;
        }

        // Getters y Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
    }



}
