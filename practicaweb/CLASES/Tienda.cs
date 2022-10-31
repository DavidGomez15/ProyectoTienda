using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practicaweb.CLASES
{
    public class Tienda
    {
        private string Nombre;
        private string Direccion;
        private Producto[] Productos;
        private int NumProductos;
        private int LimProductos;

        public Tienda(int limProductos)
        {
            this.LimProductos = limProductos;
            Productos = new Producto[LimProductos];
        }


        public int NumProductos1 { get => NumProductos; set => NumProductos = value; }
        public int LimProductos1 { get => LimProductos; set => LimProductos = value; }
    }
}