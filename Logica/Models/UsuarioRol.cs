using System.Data;

namespace Logica.Models
{
    public class UsuarioRol
    {
        public int IDUsuarioRol { get; set; }
        public string Rol { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SpUsuarioRolListar");
            
            return R;
        }

    }
}