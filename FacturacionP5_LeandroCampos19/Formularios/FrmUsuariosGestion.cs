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
    public partial class FrmUsuariosGestion : Form
    {

        public Logica.Models.Usuario MiUsuarioLocal { get; set; }
        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();

            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;

            ListarUsuariosActivos();
            CargarRolesDeUsuarioEnCombo();
            LimpiarForm();

            ActivarAgregar();
        }

        private void ActivarAgregar()
        {
            //activa solo el botón de agregar 
            btnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void ActivarEditarYEliminar()
        {
            //activa solo el botón de agregar 
            btnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void LimpiarForm()
        {
            //este método elimina todos los datos de los controles del formulario 
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtEmail.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtEmailRespaldo.Clear();
            TxtPassword.Clear();

            CboxTipoUsuario.SelectedIndex = -1;
        }

        private void CargarRolesDeUsuarioEnCombo()
        {
            Logica.Models.UsuarioRol objRolDeUsuario = new Logica.Models.UsuarioRol();

            DataTable ListaRoles = new DataTable();

            ListaRoles = objRolDeUsuario.Listar();


            CboxTipoUsuario.ValueMember = "id";
            CboxTipoUsuario.DisplayMember = "d";
            CboxTipoUsuario.DataSource = ListaRoles;
            //El menos 1 es para que el combo aparezca vacio al compilar
            CboxTipoUsuario.SelectedIndex = -1;

        }



        private void ListarUsuariosActivos()
        {
            Logica.Models.Usuario Miusuario = new Logica.Models.Usuario();
            DataTable dt = Miusuario.ListarActivos();

            DgvListaUsuarios.DataSource = dt;
            DgvListaUsuarios.ClearSelection();

        }

        private void ListarUsuariosDesactivados()
        {
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            DataTable dt = MiUsuario.ListarInactivos();

            //mostrar datos en el dgv
            DgvListaUsuarios.DataSource = dt;

            DgvListaUsuarios.ClearSelection();
        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmailRespaldo.Text.Trim()) &&
                CboxTipoUsuario.SelectedIndex > -1)
            {
                if (BtnEditar.Enabled)
                {
                    //si estamos en modo de edicón el password es opcional 
                    //y poder retornar True en este punto 
                    R = true;
                }
                else
                {
                    //Si el botón de Editar está "apagado" la única otra opción 
                    // es que estemos en modo de Agregación y acá si debemos validar 
                    //el password
                    if (!string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                    {
                        R = true;
                    }


                    /* }
                     else
                     {
                         //retroalimentar al usuario para indicarle en qué está fallando 
                         //debemos reevaluar cada cuadro de texto para ver si no lo digitó 
                         //y dar el aviso correspondiente 

                         if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                         {
                             MessageBox.Show("El Nombre del Usuario es requerido", "Error de Validación", MessageBoxButtons.OK);
                             TxtNombre.Focus();
                             return false;
                         }

                         if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                         {
                             MessageBox.Show("El Email del Usuario es requerido", "Error de Validación", MessageBoxButtons.OK);
                             TxtEmail.Focus();
                             return false;
                         }

                         if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                         {
                             MessageBox.Show("La Cédula del Usuario es requerida", "Error de Validación", MessageBoxButtons.OK);
                             TxtCedula.Focus();
                             return false;
                         }

                         if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                         {
                             MessageBox.Show("El Número de Teléfono del Usuario es requerido", "Error de Validación", MessageBoxButtons.OK);
                             TxtTelefono.Focus();
                             return false;
                         }



                         if (string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                         {
                             MessageBox.Show("La Contraseña del Usuario es requerida", "Error de Validación", MessageBoxButtons.OK);
                             TxtPassword.Focus();
                             return false;
                         }

                         if (CboxTipoUsuario.SelectedIndex == -1)
                         {
                             MessageBox.Show("El Tipo De Usuario es requerido", "Error de Validación", MessageBoxButtons.OK);
                             CboxTipoUsuario.Focus();
                             return false;
                         }

                     }

                     return R;

                 }*/
                }

            }
            return R;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar Funcionalidad de validacion

            //if (ValidarDatosRequeridos())
            {
                string Pregunta = string.Format("¿Está seguro de agregar al Usuario {0}?", TxtNombre.Text.Trim());

                DialogResult RespuestaDelUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDelUsuario == DialogResult.Yes)
                {
                    //TEMPORAL: se agregan los valores de los atributos del objeto local
                    MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                    MiUsuarioLocal.NombreUsuario = TxtEmail.Text.Trim();
                    MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
                    MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
                    MiUsuarioLocal.Contrasennia = TxtPassword.Text.Trim();
                    MiUsuarioLocal.CorreoDeRespaldo = TxtEmailRespaldo.Text.Trim();
                    MiUsuarioLocal.MiRol.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);
                    bool A = MiUsuarioLocal.ConsultarPorCedula();

                    bool B = MiUsuarioLocal.ConsultarPorEmail();


                    if (!A && !B)
                    {
                        if (MiUsuarioLocal.Agregar())
                        {

                            MessageBox.Show("Usuario agregado correctamente", ":)", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error y el usuario no se guardo", ":(", MessageBoxButtons.OK);

                        }

                        ListarUsuariosActivos();
                        //Falta limpiar el form
                    }
                    else
                    {
                        if (A)
                        {
                            MessageBox.Show("Ya existe un usuario con la cedula digitada", "Error de validacion", MessageBoxButtons.OK);
                            TxtBuscar.Focus();
                            TxtCedula.SelectAll();
                        }
                        if (B)
                        {
                            MessageBox.Show("Ya existe un usuario con el email digitado", "Error de validacion", MessageBoxButtons.OK);
                            TxtEmail.Focus();
                            TxtEmail.SelectAll();
                        }

                    }
                }
            }
        }



        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaUsuarios.ClearSelection();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, true);

        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, true);
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e);
        }

        private void BtnLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar();
        }

        //Aqui no se que pasó pero el btnAgregar de arriba perdió la funcionalidad:(

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //Agregar Funcionalidad de validacion

            //if (ValidarDatosRequeridos())
            {
                string Pregunta = string.Format("¿Está seguro de agregar al Usuario {0}?", TxtNombre.Text.Trim());

                DialogResult RespuestaDelUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDelUsuario == DialogResult.Yes)
                {
                    //TEMPORAL: se agregan los valores de los atributos del objeto local
                    MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                    MiUsuarioLocal.NombreUsuario = TxtEmail.Text.Trim();
                    MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
                    MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
                    MiUsuarioLocal.Contrasennia = TxtPassword.Text.Trim();
                    MiUsuarioLocal.CorreoDeRespaldo = TxtEmailRespaldo.Text.Trim();
                    MiUsuarioLocal.MiRol.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);
                    bool A = MiUsuarioLocal.ConsultarPorCedula();

                    bool B = MiUsuarioLocal.ConsultarPorEmail();


                    if (!A && !B)
                    {
                        if (MiUsuarioLocal.Agregar())
                        {

                            MessageBox.Show("Usuario agregado correctamente", ":)", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error y el usuario no se guardo", ":(", MessageBoxButtons.OK);

                        }

                        ListarUsuariosActivos();
                        LimpiarForm();
                    }
                    else
                    {
                        if (A)
                        {
                            MessageBox.Show("Ya existe un usuario con la cedula digitada", "Error de validacion", MessageBoxButtons.OK);
                            TxtBuscar.Focus();
                            TxtCedula.SelectAll();
                        }
                        if (B)
                        {
                            MessageBox.Show("Ya existe un usuario con el email digitado", "Error de validacion", MessageBoxButtons.OK);
                            TxtEmail.Focus();
                            TxtEmail.SelectAll();
                        }

                    }
                }
            }
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //el siguiente código permite que al hacer clic sobre una línea del dgv 
            //los datos de ese usuario se muestren en el formulario y además el obj 
            //de usuario local también se carga con dicha info. 
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaUsuarios.SelectedRows[0];

                int IdUsuarioSeleccionado = Convert.ToInt32(Fila.Cells["CIDUsuario"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IdUsuarioSeleccionado);

                if (MiUsuarioLocal.IDUsuario > 0)
                {
                    //se representa la info en los controles respectivos usando el obj MiUsuarioLocal como
                    //fuente de datos 

                    LimpiarForm();

                    TxtCodigo.Text = MiUsuarioLocal.IDUsuario.ToString();
                    TxtNombre.Text = MiUsuarioLocal.Nombre;
                    TxtEmail.Text = MiUsuarioLocal.NombreUsuario;
                    TxtCedula.Text = MiUsuarioLocal.Cedula;
                    TxtTelefono.Text = MiUsuarioLocal.Telefono;
                    TxtEmailRespaldo.Text = MiUsuarioLocal.CorreoDeRespaldo;

                    CboxTipoUsuario.SelectedValue = MiUsuarioLocal.MiRol.IDUsuarioRol;

                    ActivarEditarYEliminar();
                    if (cbVerActivos.Checked)
                    {
                        GbDetalles.Enabled = true;
                        BtnEditar.Enabled = true;
                    }
                    else
                    {
                        GbDetalles.Enabled = false;
                        BtnEditar.Enabled = false;
                    }

                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //el código es muy silimar al de agregar. Primero se validan los datos requeridos 

            if (ValidarDatosRequeridos())
            {
                string Mensaje = string.Format("¿Desea continuar con la modificación del usuario {0}", TxtNombre.Text.Trim());

                DialogResult respuesta = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                    MiUsuarioLocal.NombreUsuario = TxtEmail.Text.Trim();
                    MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
                    MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
                    MiUsuarioLocal.CorreoDeRespaldo = TxtEmailRespaldo.Text.Trim();
                    MiUsuarioLocal.Contrasennia = TxtPassword.Text.Trim();
                    MiUsuarioLocal.MiRol.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);

                    if (MiUsuarioLocal.Editar())
                    {
                        string MensajeExito = string.Format("El usuario {0} se ha modificado correctamente", MiUsuarioLocal.Nombre);

                        MessageBox.Show(MensajeExito, ":)", MessageBoxButtons.OK);

                        ListarUsuariosActivos();
                        LimpiarForm();
                        ActivarAgregar();
                    }
                    else
                    {
                        string MensajeFracaso = string.Format("El usuario {0} No se ha modificado correctamente", MiUsuarioLocal.Nombre);

                        MessageBox.Show(MensajeFracaso, ":(", MessageBoxButtons.OK);

                        //TODO: determinar si es buena idea limpiar el form 
                    }
                }
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            //al salir del cuadro de text validamos en tiempo real que el formato del email sea el correcto 

            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) && !Validacion.ValidarEmail(TxtEmail.Text.Trim()))
            {
                MessageBox.Show("El formato del email es incorrecto!", "Error de Validación", MessageBoxButtons.OK);
                TxtEmail.Focus();
                TxtEmail.SelectAll();
            }
        }

        private void BtnVer_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = false;
        }

        private void BtnVer_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //En la funcionalidad de Editar la consulta por el ID se ejecuta directamente en la 
            //función Editar(), acá lo voy a consultar previamente 

            if (MiUsuarioLocal.IDUsuario > 0)
            {
                Logica.Models.Usuario UsuarioConsulta = new Logica.Models.Usuario();

                UsuarioConsulta = MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IDUsuario);

                if (UsuarioConsulta.IDUsuario > 0)
                {
                    string Mensaje = "";

                    if (cbVerActivos.Checked)
                    {
                        Mensaje = string.Format("¿Desea continuar con la Eliminación del usuario {0}", MiUsuarioLocal.Nombre);
                    }
                    else
                    {
                        Mensaje = string.Format("¿Desea continuar con la Activación del usuario {0}", MiUsuarioLocal.Nombre);
                    }

                    DialogResult resp = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                    if (resp == DialogResult.Yes)
                    {

                        if (cbVerActivos.Checked)
                        {
                            if (MiUsuarioLocal.Eliminar())
                            {
                                MessageBox.Show("Usuario Eliminado Correctamente", ":/", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if (MiUsuarioLocal.Activar())
                            {
                                MessageBox.Show("Usuario Activado Correctamente", ":)", MessageBoxButtons.OK);
                            }
                        }

                        cbVerActivos.Checked = true;
                        ListarUsuariosActivos();
                        LimpiarForm();
                        ActivarAgregar();

                    }
                }
            }
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerActivos.Checked)
            {
                btnEliminar.Text = "ELIMINAR";
                ListarUsuariosActivos();
                LimpiarForm();
                ActivarAgregar();
            }
            else
            {
                btnEliminar.Text = "ACTIVAR";
                //ListarUsuariosDesactivados();
                LimpiarForm();
                ActivarEditarYEliminar();
            }
        }

        private void cbVerActivos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbVerActivos.Checked)
            {
                btnEliminar.Text = "ELIMINAR";
                ListarUsuariosActivos();
                LimpiarForm();
                ActivarAgregar();
            }
            else
            {
                btnEliminar.Text = "ACTIVAR";
                ListarUsuariosDesactivados();
                LimpiarForm();
                ActivarEditarYEliminar();
            }
        }
    }
}



