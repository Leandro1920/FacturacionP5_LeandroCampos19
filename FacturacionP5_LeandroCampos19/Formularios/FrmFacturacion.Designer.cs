namespace FacturacionP5_LeandroCampos19.Formularios
{
    partial class FrmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.PanEncabezado = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboxTipoFactura = new System.Windows.Forms.ComboBox();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CboxEmpresa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnItemAgregar = new System.Windows.Forms.Button();
            this.BtnItemModificar = new System.Windows.Forms.Button();
            this.BtnItemEliminar = new System.Windows.Forms.Button();
            this.DgvListaItems = new System.Windows.Forms.DataGridView();
            this.CIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdescripcionItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadFacturada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImpuestoLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.LblImpuestos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LblDescuentos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.0397F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.96029F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PanEncabezado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DgvListaItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.66972F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.33028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1083, 652);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnFacturar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(859, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 101);
            this.panel1.TabIndex = 0;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(0, 64);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(215, 34);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFacturar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnFacturar.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnFacturar.Location = new System.Drawing.Point(0, 0);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(221, 34);
            this.BtnFacturar.TabIndex = 0;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = false;
            // 
            // PanEncabezado
            // 
            this.PanEncabezado.BackColor = System.Drawing.Color.LightGray;
            this.PanEncabezado.Controls.Add(this.label6);
            this.PanEncabezado.Controls.Add(this.TxtNotas);
            this.PanEncabezado.Controls.Add(this.label5);
            this.PanEncabezado.Controls.Add(this.CboxTipoFactura);
            this.PanEncabezado.Controls.Add(this.LblNombreCliente);
            this.PanEncabezado.Controls.Add(this.TxtIdCliente);
            this.PanEncabezado.Controls.Add(this.label4);
            this.PanEncabezado.Controls.Add(this.label3);
            this.PanEncabezado.Controls.Add(this.CboxUsuario);
            this.PanEncabezado.Controls.Add(this.label2);
            this.PanEncabezado.Controls.Add(this.DtpFechaFactura);
            this.PanEncabezado.Controls.Add(this.label1);
            this.PanEncabezado.Controls.Add(this.CboxEmpresa);
            this.PanEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanEncabezado.Location = new System.Drawing.Point(3, 3);
            this.PanEncabezado.Name = "PanEncabezado";
            this.PanEncabezado.Size = new System.Drawing.Size(850, 232);
            this.PanEncabezado.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Notas";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNotas.Location = new System.Drawing.Point(542, 65);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(281, 154);
            this.TxtNotas.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo Factura";
            // 
            // CboxTipoFactura
            // 
            this.CboxTipoFactura.FormattingEnabled = true;
            this.CboxTipoFactura.Location = new System.Drawing.Point(121, 164);
            this.CboxTipoFactura.Name = "CboxTipoFactura";
            this.CboxTipoFactura.Size = new System.Drawing.Size(224, 24);
            this.CboxTipoFactura.TabIndex = 9;
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(250, 117);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(122, 16);
            this.LblNombreCliente.TabIndex = 8;
            this.LblNombreCliente.Text = "Nombre del Cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtIdCliente.Location = new System.Drawing.Point(121, 114);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(116, 22);
            this.TxtIdCliente.TabIndex = 7;
            this.TxtIdCliente.DoubleClick += new System.EventHandler(this.TxtIdCliente_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            // 
            // CboxUsuario
            // 
            this.CboxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxUsuario.FormattingEnabled = true;
            this.CboxUsuario.Location = new System.Drawing.Point(121, 65);
            this.CboxUsuario.MaxDropDownItems = 12;
            this.CboxUsuario.Name = "CboxUsuario";
            this.CboxUsuario.Size = new System.Drawing.Size(329, 24);
            this.CboxUsuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // DtpFechaFactura
            // 
            this.DtpFechaFactura.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DtpFechaFactura.Location = new System.Drawing.Point(542, 9);
            this.DtpFechaFactura.Name = "DtpFechaFactura";
            this.DtpFechaFactura.Size = new System.Drawing.Size(270, 22);
            this.DtpFechaFactura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa:";
            // 
            // CboxEmpresa
            // 
            this.CboxEmpresa.FormattingEnabled = true;
            this.CboxEmpresa.Location = new System.Drawing.Point(121, 9);
            this.CboxEmpresa.Name = "CboxEmpresa";
            this.CboxEmpresa.Size = new System.Drawing.Size(329, 24);
            this.CboxEmpresa.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(859, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 232);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.BtnItemAgregar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnItemModificar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnItemEliminar, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(859, 241);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(221, 301);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnItemAgregar
            // 
            this.BtnItemAgregar.BackColor = System.Drawing.Color.Wheat;
            this.BtnItemAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnItemAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItemAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItemAgregar.Location = new System.Drawing.Point(3, 3);
            this.BtnItemAgregar.Name = "BtnItemAgregar";
            this.BtnItemAgregar.Size = new System.Drawing.Size(207, 64);
            this.BtnItemAgregar.TabIndex = 0;
            this.BtnItemAgregar.Text = "Agregar";
            this.BtnItemAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnItemAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnItemAgregar.UseVisualStyleBackColor = false;
            this.BtnItemAgregar.Click += new System.EventHandler(this.BtnItemAgregar_Click);
            // 
            // BtnItemModificar
            // 
            this.BtnItemModificar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnItemModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnItemModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItemModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItemModificar.Location = new System.Drawing.Point(3, 73);
            this.BtnItemModificar.Name = "BtnItemModificar";
            this.BtnItemModificar.Size = new System.Drawing.Size(207, 64);
            this.BtnItemModificar.TabIndex = 2;
            this.BtnItemModificar.Text = "Modificar";
            this.BtnItemModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnItemModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnItemModificar.UseVisualStyleBackColor = false;
            // 
            // BtnItemEliminar
            // 
            this.BtnItemEliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnItemEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnItemEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItemEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItemEliminar.Location = new System.Drawing.Point(3, 143);
            this.BtnItemEliminar.Name = "BtnItemEliminar";
            this.BtnItemEliminar.Size = new System.Drawing.Size(207, 64);
            this.BtnItemEliminar.TabIndex = 1;
            this.BtnItemEliminar.Text = "Eliminar";
            this.BtnItemEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnItemEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnItemEliminar.UseVisualStyleBackColor = false;
            // 
            // DgvListaItems
            // 
            this.DgvListaItems.AllowUserToAddRows = false;
            this.DgvListaItems.AllowUserToDeleteRows = false;
            this.DgvListaItems.AllowUserToOrderColumns = true;
            this.DgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDProducto,
            this.CdescripcionItem,
            this.CCantidadFacturada,
            this.CPrecioUnitario,
            this.CPorcentajeDescuento,
            this.CSubTotalLinea,
            this.CImpuestoLinea,
            this.CTotalLinea});
            this.DgvListaItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaItems.Location = new System.Drawing.Point(3, 241);
            this.DgvListaItems.Name = "DgvListaItems";
            this.DgvListaItems.ReadOnly = true;
            this.DgvListaItems.RowHeadersVisible = false;
            this.DgvListaItems.RowHeadersWidth = 51;
            this.DgvListaItems.RowTemplate.Height = 24;
            this.DgvListaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaItems.Size = new System.Drawing.Size(850, 301);
            this.DgvListaItems.TabIndex = 4;
            this.DgvListaItems.VirtualMode = true;
            // 
            // CIDProducto
            // 
            this.CIDProducto.DataPropertyName = "IDProducto";
            this.CIDProducto.HeaderText = "Codigo Item";
            this.CIDProducto.MinimumWidth = 6;
            this.CIDProducto.Name = "CIDProducto";
            this.CIDProducto.ReadOnly = true;
            this.CIDProducto.Width = 125;
            // 
            // CdescripcionItem
            // 
            this.CdescripcionItem.DataPropertyName = "descripcionItem";
            this.CdescripcionItem.HeaderText = "Descripcion";
            this.CdescripcionItem.MinimumWidth = 6;
            this.CdescripcionItem.Name = "CdescripcionItem";
            this.CdescripcionItem.ReadOnly = true;
            this.CdescripcionItem.Width = 125;
            // 
            // CCantidadFacturada
            // 
            this.CCantidadFacturada.DataPropertyName = "CantidadFacturada";
            this.CCantidadFacturada.HeaderText = "Cantidad";
            this.CCantidadFacturada.MinimumWidth = 6;
            this.CCantidadFacturada.Name = "CCantidadFacturada";
            this.CCantidadFacturada.ReadOnly = true;
            this.CCantidadFacturada.Width = 125;
            // 
            // CPrecioUnitario
            // 
            this.CPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.CPrecioUnitario.HeaderText = "Precio Unitario";
            this.CPrecioUnitario.MinimumWidth = 6;
            this.CPrecioUnitario.Name = "CPrecioUnitario";
            this.CPrecioUnitario.ReadOnly = true;
            this.CPrecioUnitario.Width = 125;
            // 
            // CPorcentajeDescuento
            // 
            this.CPorcentajeDescuento.DataPropertyName = "PorcentajeDescuento";
            this.CPorcentajeDescuento.HeaderText = "%Desc";
            this.CPorcentajeDescuento.MinimumWidth = 6;
            this.CPorcentajeDescuento.Name = "CPorcentajeDescuento";
            this.CPorcentajeDescuento.ReadOnly = true;
            this.CPorcentajeDescuento.Width = 125;
            // 
            // CSubTotalLinea
            // 
            this.CSubTotalLinea.DataPropertyName = "SubTotalLinea";
            this.CSubTotalLinea.HeaderText = "SubTotal";
            this.CSubTotalLinea.MinimumWidth = 6;
            this.CSubTotalLinea.Name = "CSubTotalLinea";
            this.CSubTotalLinea.ReadOnly = true;
            this.CSubTotalLinea.Width = 125;
            // 
            // CImpuestoLinea
            // 
            this.CImpuestoLinea.DataPropertyName = "ImpuestoLinea";
            this.CImpuestoLinea.HeaderText = "Impuesto";
            this.CImpuestoLinea.MinimumWidth = 6;
            this.CImpuestoLinea.Name = "CImpuestoLinea";
            this.CImpuestoLinea.ReadOnly = true;
            this.CImpuestoLinea.Width = 125;
            // 
            // CTotalLinea
            // 
            this.CTotalLinea.DataPropertyName = "TotalLinea";
            this.CTotalLinea.HeaderText = "Total";
            this.CTotalLinea.MinimumWidth = 6;
            this.CTotalLinea.Name = "CTotalLinea";
            this.CTotalLinea.ReadOnly = true;
            this.CTotalLinea.Width = 125;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 548);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(850, 101);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.LblTotal, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(594, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(253, 95);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // LblTotal
            // 
            this.LblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Gold;
            this.LblTotal.Location = new System.Drawing.Point(3, 47);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(247, 48);
            this.LblTotal.TabIndex = 4;
            this.LblTotal.Text = "0";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 47);
            this.label9.TabIndex = 3;
            this.label9.Text = "TOTAL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.LblImpuestos, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(397, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(191, 95);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // LblImpuestos
            // 
            this.LblImpuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImpuestos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblImpuestos.Location = new System.Drawing.Point(3, 47);
            this.LblImpuestos.Name = "LblImpuestos";
            this.LblImpuestos.Size = new System.Drawing.Size(185, 48);
            this.LblImpuestos.TabIndex = 3;
            this.LblImpuestos.Text = "0";
            this.LblImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 47);
            this.label10.TabIndex = 2;
            this.label10.Text = "IMPUESTOS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.LblDescuentos, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(200, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(191, 95);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // LblDescuentos
            // 
            this.LblDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescuentos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblDescuentos.Location = new System.Drawing.Point(3, 47);
            this.LblDescuentos.Name = "LblDescuentos";
            this.LblDescuentos.Size = new System.Drawing.Size(185, 48);
            this.LblDescuentos.TabIndex = 2;
            this.LblDescuentos.Text = "0";
            this.LblDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 47);
            this.label8.TabIndex = 1;
            this.label8.Text = "DESCUENTOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.LblSubTotal, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(191, 95);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblSubTotal.Location = new System.Drawing.Point(3, 47);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(185, 48);
            this.LblSubTotal.TabIndex = 1;
            this.LblSubTotal.Text = "0";
            this.LblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 47);
            this.label7.TabIndex = 0;
            this.label7.Text = "SUB TOTAL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1083, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FrmFacturacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURACION";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanEncabezado.ResumeLayout(false);
            this.PanEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.Panel PanEncabezado;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboxTipoFactura;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboxEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnItemAgregar;
        private System.Windows.Forms.Button BtnItemModificar;
        private System.Windows.Forms.Button BtnItemEliminar;
        private System.Windows.Forms.DataGridView DgvListaItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label LblDescuentos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblImpuestos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdescripcionItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadFacturada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotalLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImpuestoLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLinea;
    }
}