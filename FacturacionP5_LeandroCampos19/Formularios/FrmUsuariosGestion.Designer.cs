namespace FacturacionP5_LeandroCampos19.Formularios
{
    partial class FrmUsuariosGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.CIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDetalles = new System.Windows.Forms.GroupBox();
            this.CboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmailRespaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiarForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.cbVerActivos = new System.Windows.Forms.CheckBox();
            this.BtnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).BeginInit();
            this.GbDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaUsuarios
            // 
            this.DgvListaUsuarios.AllowUserToAddRows = false;
            this.DgvListaUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDUsuario,
            this.CNombre,
            this.CNombreUsuario,
            this.CCedula,
            this.CRol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListaUsuarios.Location = new System.Drawing.Point(12, 42);
            this.DgvListaUsuarios.MultiSelect = false;
            this.DgvListaUsuarios.Name = "DgvListaUsuarios";
            this.DgvListaUsuarios.ReadOnly = true;
            this.DgvListaUsuarios.RowHeadersVisible = false;
            this.DgvListaUsuarios.RowHeadersWidth = 51;
            this.DgvListaUsuarios.RowTemplate.Height = 24;
            this.DgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaUsuarios.Size = new System.Drawing.Size(857, 231);
            this.DgvListaUsuarios.TabIndex = 0;
            this.DgvListaUsuarios.VirtualMode = true;
            this.DgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaUsuarios_CellClick);
            this.DgvListaUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaUsuarios_DataBindingComplete);
            // 
            // CIDUsuario
            // 
            this.CIDUsuario.DataPropertyName = "IDUsuario";
            this.CIDUsuario.HeaderText = "Codigo Usuario";
            this.CIDUsuario.MinimumWidth = 6;
            this.CIDUsuario.Name = "CIDUsuario";
            this.CIDUsuario.ReadOnly = true;
            this.CIDUsuario.Width = 125;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.MinimumWidth = 6;
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CNombreUsuario
            // 
            this.CNombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombreUsuario.DataPropertyName = "NombreUsuario";
            this.CNombreUsuario.HeaderText = "Email";
            this.CNombreUsuario.MinimumWidth = 6;
            this.CNombreUsuario.Name = "CNombreUsuario";
            this.CNombreUsuario.ReadOnly = true;
            this.CNombreUsuario.Width = 180;
            // 
            // CCedula
            // 
            this.CCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCedula.DataPropertyName = "Cedula";
            this.CCedula.HeaderText = "Cedula";
            this.CCedula.MinimumWidth = 6;
            this.CCedula.Name = "CCedula";
            this.CCedula.ReadOnly = true;
            this.CCedula.Width = 150;
            // 
            // CRol
            // 
            this.CRol.DataPropertyName = "Rol";
            this.CRol.HeaderText = "Tipo Usuario";
            this.CRol.MinimumWidth = 6;
            this.CRol.Name = "CRol";
            this.CRol.ReadOnly = true;
            this.CRol.Width = 125;
            // 
            // GbDetalles
            // 
            this.GbDetalles.Controls.Add(this.BtnVer);
            this.GbDetalles.Controls.Add(this.CboxTipoUsuario);
            this.GbDetalles.Controls.Add(this.label9);
            this.GbDetalles.Controls.Add(this.TxtPassword);
            this.GbDetalles.Controls.Add(this.label8);
            this.GbDetalles.Controls.Add(this.TxtEmailRespaldo);
            this.GbDetalles.Controls.Add(this.label6);
            this.GbDetalles.Controls.Add(this.TxtTelefono);
            this.GbDetalles.Controls.Add(this.label7);
            this.GbDetalles.Controls.Add(this.TxtCedula);
            this.GbDetalles.Controls.Add(this.label5);
            this.GbDetalles.Controls.Add(this.TxtEmail);
            this.GbDetalles.Controls.Add(this.TxtNombre);
            this.GbDetalles.Controls.Add(this.label4);
            this.GbDetalles.Controls.Add(this.label3);
            this.GbDetalles.Controls.Add(this.TxtCodigo);
            this.GbDetalles.Controls.Add(this.label2);
            this.GbDetalles.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDetalles.Location = new System.Drawing.Point(12, 279);
            this.GbDetalles.Name = "GbDetalles";
            this.GbDetalles.Size = new System.Drawing.Size(857, 239);
            this.GbDetalles.TabIndex = 1;
            this.GbDetalles.TabStop = false;
            this.GbDetalles.Text = "Detalles del Usuario";
            // 
            // CboxTipoUsuario
            // 
            this.CboxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoUsuario.FormattingEnabled = true;
            this.CboxTipoUsuario.Location = new System.Drawing.Point(439, 203);
            this.CboxTipoUsuario.Name = "CboxTipoUsuario";
            this.CboxTipoUsuario.Size = new System.Drawing.Size(288, 27);
            this.CboxTipoUsuario.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tipo Usuario";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(439, 147);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(235, 25);
            this.TxtPassword.TabIndex = 23;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Contraseña";
            // 
            // TxtEmailRespaldo
            // 
            this.TxtEmailRespaldo.Location = new System.Drawing.Point(89, 257);
            this.TxtEmailRespaldo.Name = "TxtEmailRespaldo";
            this.TxtEmailRespaldo.Size = new System.Drawing.Size(288, 25);
            this.TxtEmailRespaldo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Email Respaldo";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(439, 90);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(288, 25);
            this.TxtTelefono.TabIndex = 19;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefono";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(10, 205);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(288, 25);
            this.TxtCedula.TabIndex = 17;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cedula";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(10, 150);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(288, 25);
            this.TxtEmail.TabIndex = 15;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(9, 94);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(288, 25);
            this.TxtNombre.TabIndex = 14;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(10, 37);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(119, 25);
            this.TxtCodigo.TabIndex = 11;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAgregar.Location = new System.Drawing.Point(12, 605);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 51);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Coral;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnEditar.Location = new System.Drawing.Point(206, 605);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(154, 51);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar.Location = new System.Drawing.Point(414, 605);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 51);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BtnLimpiarForm
            // 
            this.BtnLimpiarForm.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnLimpiarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarForm.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnLimpiarForm.Location = new System.Drawing.Point(715, 605);
            this.BtnLimpiarForm.Name = "BtnLimpiarForm";
            this.BtnLimpiarForm.Size = new System.Drawing.Size(154, 51);
            this.BtnLimpiarForm.TabIndex = 5;
            this.BtnLimpiarForm.Text = "Limpiar";
            this.BtnLimpiarForm.UseVisualStyleBackColor = false;
            this.BtnLimpiarForm.Click += new System.EventHandler(this.BtnLimpiarForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(222, 6);
            this.TxtBuscar.MaxLength = 20;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(288, 28);
            this.TxtBuscar.TabIndex = 8;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbVerActivos
            // 
            this.cbVerActivos.AutoSize = true;
            this.cbVerActivos.Checked = true;
            this.cbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVerActivos.Location = new System.Drawing.Point(715, 11);
            this.cbVerActivos.Name = "cbVerActivos";
            this.cbVerActivos.Size = new System.Drawing.Size(154, 20);
            this.cbVerActivos.TabIndex = 9;
            this.cbVerActivos.Text = "Ver Usuarios Activos";
            this.cbVerActivos.UseVisualStyleBackColor = true;
            this.cbVerActivos.CheckedChanged += new System.EventHandler(this.cbVerActivos_CheckedChanged_1);
            // 
            // BtnVer
            // 
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnVer.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.Location = new System.Drawing.Point(686, 147);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(41, 25);
            this.BtnVer.TabIndex = 26;
            this.BtnVer.Text = "Ver";
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVer_MouseDown);
            this.BtnVer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVer_MouseUp);
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 687);
            this.Controls.Add(this.cbVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiarForm);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DgvListaUsuarios);
            this.Controls.Add(this.GbDetalles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion  de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).EndInit();
            this.GbDetalles.ResumeLayout(false);
            this.GbDetalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaUsuarios;
        private System.Windows.Forms.GroupBox GbDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button BtnLimpiarForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox cbVerActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRol;
        private System.Windows.Forms.ComboBox CboxTipoUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmailRespaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnVer;
    }
}