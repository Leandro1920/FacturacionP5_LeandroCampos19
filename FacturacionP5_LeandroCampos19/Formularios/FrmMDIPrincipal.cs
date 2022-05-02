using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionP5_LeandroCampos19.Formularios
{
    public partial class FrmMDIPrincipal : Form
    {
        public FrmMDIPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMDIPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMDIPrincipal_Load(object sender, EventArgs e)
        {

            string UsuarioLogueado = string.Format("{0}({1})", ObjetosGlobales.MiUsuarioGlobal.Nombre, 
                ObjetosGlobales.MiUsuarioGlobal.NombreUsuario,
            ObjetosGlobales.MiUsuarioGlobal.MiRol.Rol);
            LblUsuarioLogueado.Text = UsuarioLogueado;

            switch (ObjetosGlobales.MiUsuarioGlobal.MiRol.IDUsuarioRol)
            {
                case 1:
                    //Es un admmin, no se debe hacer bloqueo por el momento.
                    break;
                case 2:
                    //Es un facturador y se debe ocultar ciertas opciones del menú 

                    MnuUsuariosGestion.Enabled = false;
                    MnuProveedoresGestion.Enabled = false;
                    MnuProductosGestion.Enabled = false;
                    MnuEmpresaGestion.Enabled = false;

                    break;
            }

            //Activamos el timer
            //me quedo pendiente


        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.MiFormDeGestionDeUsuarios.Visible)
            {
                ObjetosGlobales.MiFormDeGestionDeUsuarios = new FrmUsuariosGestion();
                ObjetosGlobales.MiFormDeGestionDeUsuarios.Show();
            }
        }

        private void FrmMDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MnuFacturar_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.MiFormFacturador.Visible)
            {
                ObjetosGlobales.MiFormFacturador = new FrmFacturacion();
                ObjetosGlobales.MiFormFacturador.Show();
            }
        }
    }
}
