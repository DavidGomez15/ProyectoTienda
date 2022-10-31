using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practicaweb.CLASES
{
    public class Producto
    {
        private int IDproducto;
        private string Descripcion;
        private string Tipo;
        private int PrecioCompra;
        private int PrecioVenta;
        private static int cont = 1;
        
        public Producto()
        {
            IDproducto = cont;
            cont++;
        }



    }
}