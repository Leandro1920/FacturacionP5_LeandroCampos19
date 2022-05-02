using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ClienteTipo
    {
        //1 Atributos

        public int IDClienteTipo { get; set; }


        public String Tipo { get; set; }
        public DataTable Listar(bool v)
        {
            DataTable R = new DataTable();




            //datos necesarios
            return R;

        }

        public DataTable Listar(bool v, string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
