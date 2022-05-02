using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {

        public int IDUsuario { get; set; }
        public String Nombre { get; set; }
        public String NombreUsuario { get; set; }
        public String Telefono { get; set; }
        public String CorreoDeRespaldo { get; set; }
        public String Contrasennia { get; set; }
        public String Cedula { get; set; }
        public bool Activo { get; set; }


        //Atributos compuesto

        public UsuarioRol MiRol { get; set; }


        public Usuario()
        {

           
            MiRol = new UsuarioRol();

        }


        public bool Agregar()
        {
            bool R = false;

            Conexion Micnn3 = new Conexion();
            Encriptador MiEncriptador = new Encriptador();
            string PassWordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);

            //aplicar mecanismo de encriptacion para la contrseña

            //Enlistar los parametros

            Micnn3.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            Micnn3.ListaParametros.Add(new SqlParameter("@Email", this.NombreUsuario));
            Micnn3.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            Micnn3.ListaParametros.Add(new SqlParameter("@CorreoRespaldo", this.CorreoDeRespaldo));
            Micnn3.ListaParametros.Add(new SqlParameter("@Contrasennia", PassWordEncriptado));
            Micnn3.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            Micnn3.ListaParametros.Add(new SqlParameter("@IdRolUsuario", this.MiRol.IDUsuarioRol));

            int Resultado = Micnn3.EjecutarUpdateDeleteInsert("SpUsuariosAgregar");


            if (Resultado > 0)
            {
                R = true;
            }

            return R;

        }

        public bool Editar()
        {
            bool R = false;

            //Según el diagrama de caso de uso expandido para la gestión de usuario
            //para poder editar un usuario antes debemos ejecutar el caso de uso 
            //Consultar por ID
            Usuario usuarioConsulta = new Usuario();

            usuarioConsulta = ConsultarPorID(this.IDUsuario);

            if (usuarioConsulta.IDUsuario > 0)
            {
                //ya se validó que existe el usuario 

                //Se prosigue con la edición del usuario 

                Conexion MyCnn = new Conexion();

                string PassWordEncriptado = "";

                if (!string.IsNullOrEmpty(this.Contrasennia))
                {
                    Encriptador MiEncriptador = new Encriptador();
                    PassWordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
                }

                //se agregan los parámetros del SP
                MyCnn.ListaParametros.Add(new SqlParameter("@id", this.IDUsuario));
                MyCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MyCnn.ListaParametros.Add(new SqlParameter("@nombreUsuario", this.NombreUsuario));
                MyCnn.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
                //MyCnn.ListaParametros.Add(new SqlParameter("@CorreoRespaldo", this.CorreoDeRespaldo));
                MyCnn.ListaParametros.Add(new SqlParameter("@Contrasennia", PassWordEncriptado));
                MyCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
                MyCnn.ListaParametros.Add(new SqlParameter("@idUsuarioRol", this.MiRol.IDUsuarioRol));

                int Resultado = MyCnn.EjecutarUpdateDeleteInsert("SpUsuariosEditar");

                if (Resultado > 0) R = true;

            }

            return R;
        }
        public bool Eliminar()
        {
            bool R = false;

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@id", IDUsuario));

            if (MyCnn.EjecutarUpdateDeleteInsert("SpUsuariosDesactivar") > 0) R = true;

            return R;
        }
        public bool Activar()
        {

            bool R = false;

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@id", IDUsuario));

            if (MyCnn.EjecutarUpdateDeleteInsert("SpUsuariosActivar") > 0) R = true;

            return R;
        }

        public Usuario ValidarIngreso(string pUsuario, string pContrasennia)
        {
            Usuario R = new Usuario();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@usuario", pUsuario));

            Encriptador MiEncriptador = new Encriptador();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(pContrasennia);
            MyCnn.ListaParametros.Add(new SqlParameter("@contrasennia", ContrasenniaEncriptada));

            DataTable DatosDeUsuario = new DataTable();

            DatosDeUsuario = MyCnn.EjecutarSelect("SpUsuariosValidarIngreso");

            if (DatosDeUsuario != null && DatosDeUsuario.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeUsuario.Rows[0];

                R.IDUsuario = Convert.ToInt32(MisDatos["IDUsuario"]);
                R.Nombre = Convert.ToString(MisDatos["Nombre"]);
                R.NombreUsuario = Convert.ToString(MisDatos["NombreUsuario"]);
                R.Cedula = Convert.ToString(MisDatos["Cedula"]);
                R.Telefono = Convert.ToString(MisDatos["Telefono"]);
                R.CorreoDeRespaldo = Convert.ToString(MisDatos["CorreoDeRespaldo"]);
                R.Contrasennia = Convert.ToString(MisDatos["Contrasennia"]);

                R.Activo = Convert.ToBoolean(MisDatos["Activo"]);

                R.MiRol.IDUsuarioRol = Convert.ToInt32(MisDatos["IDUsuarioRol"]);
                R.MiRol.Rol = Convert.ToString(MisDatos["Rol"]);
            }

            return R;
        }



        public bool ConsultarPorCedula()
        {


            bool R = false;

            Conexion MiCnn = new Conexion();

            //Agregar los parametros al procedimiento Almacenado
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            DataTable Consulta = MiCnn.EjecutarSelect("SpUsuariosConsultarPorCedula");


            if (Consulta.Rows.Count >0)
            {
                R = true;
            }

            return R;
        }
        public bool ConsultarPorEmail()
        {


            bool R = false;

            Conexion MiCnn2= new Conexion();

            //Agregar los parametros al procedimiento Almacenado
            MiCnn2.ListaParametros.Add(new SqlParameter("@Email", this.NombreUsuario));

            DataTable Consulta = MiCnn2.EjecutarSelect("SpUsuariosConsultarPorEmail");


            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }
        public bool ConsultarPorID()
        {


            bool R = false;


            return R;
        }

        public Usuario ConsultarPorID(int pIdUsuario)
        {


            Usuario R = new Usuario();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@id", pIdUsuario));

           DataTable DatosDeUsuario = new DataTable();

            DatosDeUsuario = MyCnn.EjecutarSelect("SpUsuariosConsultarPorID");

            if (DatosDeUsuario != null && DatosDeUsuario.Rows.Count>0)
            {
                DataRow MisDatos = DatosDeUsuario.Rows[0];

                R.IDUsuario = Convert.ToInt32( MisDatos["IDUsuario"]);
                R.Nombre = Convert.ToString( MisDatos["Nombre"]);
                R.NombreUsuario = Convert.ToString( MisDatos["NombreUsuario"]);
                R.Cedula = Convert.ToString( MisDatos["Cedula"]);
                R.Telefono = Convert.ToString( MisDatos["Telefono"]);
                R.Contrasennia = Convert.ToString( MisDatos["Contrasennia"]);

                R.Activo = Convert.ToBoolean(MisDatos["Activo"]);

                R.MiRol.IDUsuarioRol = Convert.ToInt32(MisDatos["IDUsuarioRol"]);
                R.MiRol.Rol = Convert.ToString(MisDatos["Rol"]);


            }


            return R;
        }



        public DataTable ListarActivos(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            Conexion Micnn = new Conexion();

            R = Micnn.EjecutarSelect("SPUsuariosListarActivos");

            return R;

        }
        public DataTable ListarInactivos(bool VerActivos = false)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SpUsuariosListarInactivos");

            return R;

        }

    }


}
