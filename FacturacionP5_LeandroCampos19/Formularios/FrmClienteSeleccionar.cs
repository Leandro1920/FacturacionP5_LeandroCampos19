using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Models;

namespace FacturacionP5_LeandroCampos19.Formularios
{
    public partial class FrmClienteSeleccionar : Form
    {

        DataTable ListaClientes = new DataTable();
        public Logica.Models.ClienteTipo MiCliente { get; set; }
        public FrmClienteSeleccionar()
        {
            InitializeComponent();

            MiCliente = new Logica.Models.ClienteTipo();
        }

        private void FrmClienteSeleccionar_Load(object sender, EventArgs e)
        {
            LlenarListaClientes();
        }

        private void LlenarListaClientes(string Filtro = "")
        {
            ListaClientes = new DataTable();

            ListaClientes = MiCliente.Listar(true, Filtro);

            DgvLista.DataSource = ListaClientes;

            DgvLista.ClearSelection();
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvLista.SelectedRows[0];

                int IdCliente = Convert.ToInt32(Fila.Cells["CIDCliente"].Value);
                string Nombre = Convert.ToString(Fila.Cells["CNombre"].Value);
                string Telefono = Convert.ToString(Fila.Cells["CTelefono"].Value);

                //ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.IDCliente = IdCliente;
               // ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.Nombre = Nombre;
                //ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.Telefono = Telefono;

                DialogResult = DialogResult.OK;
            }
        }

        private void TxtBuscar_MouseDown(object sender, MouseEventArgs e)
        {
            TmrBuscarCliente.Enabled = false;
        }

        private void TxtBuscar_MouseUp(object sender, MouseEventArgs e)
        {
            TmrBuscarCliente.Enabled = true;
        }

        private void TmrBuscarCliente_Tick(object sender, EventArgs e)
        {
            TmrBuscarCliente.Enabled = false;

            if (!String.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                string Filtro = TxtBuscar.Text.Trim();

                LlenarListaClientes(Filtro);
            }
            else
            {
                LlenarListaClientes();
            }
        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }
    }
}
        

