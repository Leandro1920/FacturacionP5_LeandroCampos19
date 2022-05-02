using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
   public class FacturaTipo
    {
        //Primero van los atributos simples y luegos los compuestos, despues las operaciones//

        //Atributos

        private int iDFacturatipo;

        public int IDFacturaTipo
        {
            get { return iDFacturatipo; }
            set { iDFacturatipo = value; }
        }
        //Forma simplificada de realizar el atributo

        public string tipo { get; set; }

        //Operaciones

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpFacturasTipoListar");
            return R;
        }
    }
}
