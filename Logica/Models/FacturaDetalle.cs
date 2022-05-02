using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaDetalle
    {
        public String DescripcionItem { get; set; }


        public decimal CantidadFacturada { get; set; }

        public decimal PrecioUnitario { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal SubtotalLinea { get; set; }
        public decimal impuerstosLinea { get; set; }
        public decimal TotalLinea { get; set; }

        Producto MiProducto { get; set; }

        //constructor
        public FacturaDetalle()
        {

            //Se instancia miTipo

            MiProducto = new Producto();

        }
    }
}