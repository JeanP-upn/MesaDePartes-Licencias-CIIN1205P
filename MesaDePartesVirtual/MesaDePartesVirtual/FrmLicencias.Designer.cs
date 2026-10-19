namespace MesaDePartesVirtual
{
    partial class FrmLicencias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboGiro = new System.Windows.Forms.ComboBox();
            this.lblGiro = new System.Windows.Forms.Label();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.lblRuc = new System.Windows.Forms.Label();
            this.grpTramites = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.lblMayorArea = new System.Windows.Forms.Label();
            this.lblTotalRegistrados = new System.Windows.Forms.Label();
            this.dgvExpedientes = new System.Windows.Forms.DataGridView();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.txtResultadoBusqueda = new System.Windows.Forms.TextBox();
            this.lblTituloResultados = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarRuc = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnCargarPrueba = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpRegistro.SuspendLayout();
            this.grpTramites.SuspendLayout();
            this.grpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(254, 9);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(610, 37);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "MESA DE PARTES VIRTUAL - LICENCIAS RÍMAC";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(348, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(430, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Municipalidad Distrital del Rímac | Ley N.° 31170 & Ley N.° 28976";
            // 
            // grpRegistro
            // 
            this.grpRegistro.Controls.Add(this.btnLimpiar);
            this.grpRegistro.Controls.Add(this.btnEliminar);
            this.grpRegistro.Controls.Add(this.btnModificar);
            this.grpRegistro.Controls.Add(this.btnRegistrar);
            this.grpRegistro.Controls.Add(this.txtArea);
            this.grpRegistro.Controls.Add(this.lblArea);
            this.grpRegistro.Controls.Add(this.cboGiro);
            this.grpRegistro.Controls.Add(this.lblGiro);
            this.grpRegistro.Controls.Add(this.txtNombreComercial);
            this.grpRegistro.Controls.Add(this.lblNombre);
            this.grpRegistro.Controls.Add(this.txtRuc);
            this.grpRegistro.Controls.Add(this.lblRuc);
            this.grpRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistro.Location = new System.Drawing.Point(12, 78);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(260, 443);
            this.grpRegistro.TabIndex = 2;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "REGISTRO DE EXPEDIENTES";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(35, 209);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(184, 32);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "REGISTRAR EXPEDIENTE";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(134, 162);
            this.txtArea.MaxLength = 4;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(111, 25);
            this.txtArea.TabIndex = 7;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(6, 165);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(122, 17);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Área del Local (m²):";
            // 
            // cboGiro
            // 
            this.cboGiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiro.FormattingEnabled = true;
            this.cboGiro.Items.AddRange(new object[] {
            "Bodega",
            "Farmacia",
            "Ferretería",
            "Restaurante",
            "Local para eventos",
            "Servicios"});
            this.cboGiro.Location = new System.Drawing.Point(121, 126);
            this.cboGiro.Name = "cboGiro";
            this.cboGiro.Size = new System.Drawing.Size(124, 25);
            this.cboGiro.TabIndex = 5;
            // 
            // lblGiro
            // 
            this.lblGiro.AutoSize = true;
            this.lblGiro.Location = new System.Drawing.Point(6, 129);
            this.lblGiro.Name = "lblGiro";
            this.lblGiro.Size = new System.Drawing.Size(109, 17);
            this.lblGiro.TabIndex = 4;
            this.lblGiro.Text = "Giro de Negocio:";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(9, 89);
            this.txtNombreComercial.MaxLength = 50;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(236, 25);
            this.txtNombreComercial.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(209, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre Comercial / Razón Social:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(9, 41);
            this.txtRuc.MaxLength = 11;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(236, 25);
            this.txtRuc.TabIndex = 1;
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Location = new System.Drawing.Point(6, 21);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(213, 17);
            this.lblRuc.TabIndex = 0;
            this.lblRuc.Text = "RUC del Contribuyente (11 dígitos):";
            // 
            // grpTramites
            // 
            this.grpTramites.Controls.Add(this.grpInformacion);
            this.grpTramites.Controls.Add(this.dgvExpedientes);
            this.grpTramites.Controls.Add(this.btnCargarPrueba);
            this.grpTramites.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpTramites.Location = new System.Drawing.Point(278, 78);
            this.grpTramites.Name = "grpTramites";
            this.grpTramites.Size = new System.Drawing.Size(531, 443);
            this.grpTramites.TabIndex = 3;
            this.grpTramites.TabStop = false;
            this.grpTramites.Text = "EXPEDIENTES EN TRÁMITE";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(35, 247);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 47);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "MODIFICAR REGISTRO";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(134, 247);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 47);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR REGISTRO";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.lblMayorArea);
            this.grpInformacion.Controls.Add(this.lblTotalRegistrados);
            this.grpInformacion.Location = new System.Drawing.Point(6, 363);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(516, 74);
            this.grpInformacion.TabIndex = 2;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "INFORMACIÓN";
            // 
            // lblMayorArea
            // 
            this.lblMayorArea.AutoSize = true;
            this.lblMayorArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayorArea.Location = new System.Drawing.Point(310, 33);
            this.lblMayorArea.Name = "lblMayorArea";
            this.lblMayorArea.Size = new System.Drawing.Size(128, 17);
            this.lblMayorArea.TabIndex = 1;
            this.lblMayorArea.Text = "Mayor Área: 0.00 m²";
            // 
            // lblTotalRegistrados
            // 
            this.lblTotalRegistrados.AutoSize = true;
            this.lblTotalRegistrados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistrados.Location = new System.Drawing.Point(73, 33);
            this.lblTotalRegistrados.Name = "lblTotalRegistrados";
            this.lblTotalRegistrados.Size = new System.Drawing.Size(124, 17);
            this.lblTotalRegistrados.TabIndex = 0;
            this.lblTotalRegistrados.Text = "Total Registrados: 0";
            // 
            // dgvExpedientes
            // 
            this.dgvExpedientes.AllowUserToAddRows = false;
            this.dgvExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpedientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpedientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RUC,
            this.NombreComercial,
            this.Giro,
            this.Area});
            this.dgvExpedientes.Location = new System.Drawing.Point(6, 22);
            this.dgvExpedientes.Name = "dgvExpedientes";
            this.dgvExpedientes.ReadOnly = true;
            this.dgvExpedientes.RowHeadersVisible = false;
            this.dgvExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpedientes.Size = new System.Drawing.Size(516, 295);
            this.dgvExpedientes.TabIndex = 0;
            this.dgvExpedientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpedientes_CellClick);
            this.dgvExpedientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpedientes_CellDoubleClick);
            // 
            // RUC
            // 
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            this.RUC.ReadOnly = true;
            // 
            // NombreComercial
            // 
            this.NombreComercial.HeaderText = "Nombre Comercial";
            this.NombreComercial.Name = "NombreComercial";
            this.NombreComercial.ReadOnly = true;
            // 
            // Giro
            // 
            this.Giro.HeaderText = "Giro";
            this.Giro.Name = "Giro";
            this.Giro.ReadOnly = true;
            // 
            // Area
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Area.DefaultCellStyle = dataGridViewCellStyle2;
            this.Area.HeaderText = "Área (m²)";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.txtResultadoBusqueda);
            this.grpConsulta.Controls.Add(this.lblTituloResultados);
            this.grpConsulta.Controls.Add(this.btnBuscar);
            this.grpConsulta.Controls.Add(this.txtBuscarRuc);
            this.grpConsulta.Controls.Add(this.lblBuscar);
            this.grpConsulta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpConsulta.Location = new System.Drawing.Point(815, 78);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(325, 443);
            this.grpConsulta.TabIndex = 4;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "CONSULTA CIUDADANA Y BÚSQUEDA";
            // 
            // txtResultadoBusqueda
            // 
            this.txtResultadoBusqueda.BackColor = System.Drawing.Color.White;
            this.txtResultadoBusqueda.Location = new System.Drawing.Point(6, 157);
            this.txtResultadoBusqueda.MaxLength = 50;
            this.txtResultadoBusqueda.Multiline = true;
            this.txtResultadoBusqueda.Name = "txtResultadoBusqueda";
            this.txtResultadoBusqueda.ReadOnly = true;
            this.txtResultadoBusqueda.Size = new System.Drawing.Size(307, 256);
            this.txtResultadoBusqueda.TabIndex = 11;
            // 
            // lblTituloResultados
            // 
            this.lblTituloResultados.AutoSize = true;
            this.lblTituloResultados.Location = new System.Drawing.Point(6, 129);
            this.lblTituloResultados.Name = "lblTituloResultados";
            this.lblTituloResultados.Size = new System.Drawing.Size(174, 17);
            this.lblTituloResultados.TabIndex = 10;
            this.lblTituloResultados.Text = "RESULTADOS DE BÚSQUEDA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(78, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 32);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarRuc
            // 
            this.txtBuscarRuc.Location = new System.Drawing.Point(9, 41);
            this.txtBuscarRuc.MaxLength = 11;
            this.txtBuscarRuc.Name = "txtBuscarRuc";
            this.txtBuscarRuc.Size = new System.Drawing.Size(279, 25);
            this.txtBuscarRuc.TabIndex = 6;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 21);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(137, 17);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Ingrese RUC a buscar:";
            // 
            // btnCargarPrueba
            // 
            this.btnCargarPrueba.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargarPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPrueba.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCargarPrueba.ForeColor = System.Drawing.Color.White;
            this.btnCargarPrueba.Location = new System.Drawing.Point(6, 323);
            this.btnCargarPrueba.Name = "btnCargarPrueba";
            this.btnCargarPrueba.Size = new System.Drawing.Size(184, 31);
            this.btnCargarPrueba.TabIndex = 9;
            this.btnCargarPrueba.Text = "CARGAR BD (ejemplo)";
            this.btnCargarPrueba.UseVisualStyleBackColor = false;
            this.btnCargarPrueba.Click += new System.EventHandler(this.btnCargarPrueba_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(35, 300);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(184, 32);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "LIMPIAR CAMPOS";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmLicencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 541);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpTramites);
            this.Controls.Add(this.grpRegistro);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Name = "FrmLicencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesa de Partes Virtual - Licencias Rímac";
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            this.grpTramites.ResumeLayout(false);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboGiro;
        private System.Windows.Forms.Label lblGiro;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grpTramites;
        private System.Windows.Forms.DataGridView dgvExpedientes;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Label lblTotalRegistrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.Label lblMayorArea;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.TextBox txtBuscarRuc;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtResultadoBusqueda;
        private System.Windows.Forms.Label lblTituloResultados;
        private System.Windows.Forms.Button btnCargarPrueba;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

