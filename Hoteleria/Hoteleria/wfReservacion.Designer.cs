namespace Hoteleria
{
    partial class wfReservacion
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
            this.txtCod_rsva = new System.Windows.Forms.TextBox();
            this.lblCod_rsva = new System.Windows.Forms.Label();
            this.lblCod_cte = new System.Windows.Forms.Label();
            this.txtCod_cte = new System.Windows.Forms.TextBox();
            this.lblFechres_rsva = new System.Windows.Forms.Label();
            this.lblFechent_rsva = new System.Windows.Forms.Label();
            this.lblFechsal_rsva = new System.Windows.Forms.Label();
            this.lblAdultos_rsva = new System.Windows.Forms.Label();
            this.lblNinos_rsva = new System.Windows.Forms.Label();
            this.lblDias_rsva = new System.Windows.Forms.Label();
            this.txtAdultos_rsva = new System.Windows.Forms.TextBox();
            this.txtNinos_rsva = new System.Windows.Forms.TextBox();
            this.txtDias_rsva = new System.Windows.Forms.TextBox();
            this.cboConfent_rsva = new System.Windows.Forms.ComboBox();
            this.lblConfent_rsva = new System.Windows.Forms.Label();
            this.lblConfsal_rsva = new System.Windows.Forms.Label();
            this.cboConfsal_rsva = new System.Windows.Forms.ComboBox();
            this.txtConfent_rsva = new System.Windows.Forms.TextBox();
            this.txtConfsal_rsva = new System.Windows.Forms.TextBox();
            this.dtpFechres_rsva = new System.Windows.Forms.DateTimePicker();
            this.dtpFechent_rsva = new System.Windows.Forms.DateTimePicker();
            this.dtpFechsal_rsva = new System.Windows.Forms.DateTimePicker();
            this.txtFechres_rsva = new System.Windows.Forms.TextBox();
            this.txtFechent_rsva = new System.Windows.Forms.TextBox();
            this.txtFechsal_rsva = new System.Windows.Forms.TextBox();
            this.txtTotal_rsva = new System.Windows.Forms.TextBox();
            this.lblTotal_rsva = new System.Windows.Forms.Label();
            this.dgvDetalleReservacion = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAambiente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTotalAmbiente = new System.Windows.Forms.TextBox();
            this.cboCodigos = new System.Windows.Forms.ComboBox();
            this.btnBuscarAmbientes = new System.Windows.Forms.Button();
            this.lblEstado_rsva = new System.Windows.Forms.Label();
            this.cboEstado_rsva = new System.Windows.Forms.ComboBox();
            this.txtEstado_rsva = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReservacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod_rsva
            // 
            this.txtCod_rsva.Location = new System.Drawing.Point(143, 272);
            this.txtCod_rsva.MaxLength = 4;
            this.txtCod_rsva.Name = "txtCod_rsva";
            this.txtCod_rsva.Size = new System.Drawing.Size(150, 21);
            this.txtCod_rsva.TabIndex = 12;
            this.txtCod_rsva.Tag = "cod_rsva";
            this.txtCod_rsva.EnabledChanged += new System.EventHandler(this.txtCod_rsva_EnabledChanged);
            this.txtCod_rsva.TextChanged += new System.EventHandler(this.txtCod_rsva_TextChanged);
            // 
            // lblCod_rsva
            // 
            this.lblCod_rsva.AutoSize = true;
            this.lblCod_rsva.Location = new System.Drawing.Point(12, 275);
            this.lblCod_rsva.Name = "lblCod_rsva";
            this.lblCod_rsva.Size = new System.Drawing.Size(46, 15);
            this.lblCod_rsva.TabIndex = 2;
            this.lblCod_rsva.Text = "Código";
            // 
            // lblCod_cte
            // 
            this.lblCod_cte.AutoSize = true;
            this.lblCod_cte.Location = new System.Drawing.Point(335, 275);
            this.lblCod_cte.Name = "lblCod_cte";
            this.lblCod_cte.Size = new System.Drawing.Size(105, 15);
            this.lblCod_cte.TabIndex = 4;
            this.lblCod_cte.Text = "Código del cliente";
            // 
            // txtCod_cte
            // 
            this.txtCod_cte.Location = new System.Drawing.Point(458, 272);
            this.txtCod_cte.MaxLength = 4;
            this.txtCod_cte.Name = "txtCod_cte";
            this.txtCod_cte.Size = new System.Drawing.Size(149, 21);
            this.txtCod_cte.TabIndex = 13;
            this.txtCod_cte.Tag = "cod_cte";
            this.txtCod_cte.Enter += new System.EventHandler(this.txtCod_cte_Enter);
            this.txtCod_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_cte_KeyPress);
            // 
            // lblFechres_rsva
            // 
            this.lblFechres_rsva.AutoSize = true;
            this.lblFechres_rsva.Location = new System.Drawing.Point(12, 304);
            this.lblFechres_rsva.Name = "lblFechres_rsva";
            this.lblFechres_rsva.Size = new System.Drawing.Size(124, 15);
            this.lblFechres_rsva.TabIndex = 7;
            this.lblFechres_rsva.Text = "Fecha de reservación";
            // 
            // lblFechent_rsva
            // 
            this.lblFechent_rsva.AutoSize = true;
            this.lblFechent_rsva.Location = new System.Drawing.Point(11, 331);
            this.lblFechent_rsva.Name = "lblFechent_rsva";
            this.lblFechent_rsva.Size = new System.Drawing.Size(103, 15);
            this.lblFechent_rsva.TabIndex = 8;
            this.lblFechent_rsva.Text = "Fecha de entrada";
            // 
            // lblFechsal_rsva
            // 
            this.lblFechsal_rsva.AutoSize = true;
            this.lblFechsal_rsva.Location = new System.Drawing.Point(335, 329);
            this.lblFechsal_rsva.Name = "lblFechsal_rsva";
            this.lblFechsal_rsva.Size = new System.Drawing.Size(94, 15);
            this.lblFechsal_rsva.TabIndex = 9;
            this.lblFechsal_rsva.Text = "Fecha de salida";
            // 
            // lblAdultos_rsva
            // 
            this.lblAdultos_rsva.AutoSize = true;
            this.lblAdultos_rsva.Location = new System.Drawing.Point(12, 356);
            this.lblAdultos_rsva.Name = "lblAdultos_rsva";
            this.lblAdultos_rsva.Size = new System.Drawing.Size(116, 15);
            this.lblAdultos_rsva.TabIndex = 10;
            this.lblAdultos_rsva.Text = "Cantidad de adultos";
            // 
            // lblNinos_rsva
            // 
            this.lblNinos_rsva.AutoSize = true;
            this.lblNinos_rsva.Location = new System.Drawing.Point(335, 356);
            this.lblNinos_rsva.Name = "lblNinos_rsva";
            this.lblNinos_rsva.Size = new System.Drawing.Size(106, 15);
            this.lblNinos_rsva.TabIndex = 11;
            this.lblNinos_rsva.Text = "Cantidad de niños";
            // 
            // lblDias_rsva
            // 
            this.lblDias_rsva.AutoSize = true;
            this.lblDias_rsva.Location = new System.Drawing.Point(335, 383);
            this.lblDias_rsva.Name = "lblDias_rsva";
            this.lblDias_rsva.Size = new System.Drawing.Size(115, 15);
            this.lblDias_rsva.TabIndex = 12;
            this.lblDias_rsva.Text = "Días de reservación";
            // 
            // txtAdultos_rsva
            // 
            this.txtAdultos_rsva.Location = new System.Drawing.Point(144, 353);
            this.txtAdultos_rsva.MaxLength = 4;
            this.txtAdultos_rsva.Name = "txtAdultos_rsva";
            this.txtAdultos_rsva.Size = new System.Drawing.Size(150, 21);
            this.txtAdultos_rsva.TabIndex = 17;
            this.txtAdultos_rsva.Tag = "adultos_rsva";
            this.txtAdultos_rsva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdultos_rsva_KeyPress);
            // 
            // txtNinos_rsva
            // 
            this.txtNinos_rsva.Location = new System.Drawing.Point(457, 353);
            this.txtNinos_rsva.MaxLength = 4;
            this.txtNinos_rsva.Name = "txtNinos_rsva";
            this.txtNinos_rsva.Size = new System.Drawing.Size(150, 21);
            this.txtNinos_rsva.TabIndex = 18;
            this.txtNinos_rsva.Tag = "ninos_rsva";
            this.txtNinos_rsva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNinos_rsva_KeyPress);
            // 
            // txtDias_rsva
            // 
            this.txtDias_rsva.Location = new System.Drawing.Point(457, 380);
            this.txtDias_rsva.MaxLength = 4;
            this.txtDias_rsva.Name = "txtDias_rsva";
            this.txtDias_rsva.Size = new System.Drawing.Size(150, 21);
            this.txtDias_rsva.TabIndex = 20;
            this.txtDias_rsva.Tag = "dias_rsva";
            this.txtDias_rsva.EnabledChanged += new System.EventHandler(this.txtDias_rsva_EnabledChanged);
            this.txtDias_rsva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_rsva_KeyPress);
            // 
            // cboConfent_rsva
            // 
            this.cboConfent_rsva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConfent_rsva.FormattingEnabled = true;
            this.cboConfent_rsva.Items.AddRange(new object[] {
            "Confirmado",
            "No confirmado"});
            this.cboConfent_rsva.Location = new System.Drawing.Point(143, 407);
            this.cboConfent_rsva.Name = "cboConfent_rsva";
            this.cboConfent_rsva.Size = new System.Drawing.Size(150, 23);
            this.cboConfent_rsva.TabIndex = 21;
            this.cboConfent_rsva.SelectedIndexChanged += new System.EventHandler(this.cboConfent_rsva_SelectedIndexChanged);
            // 
            // lblConfent_rsva
            // 
            this.lblConfent_rsva.AutoSize = true;
            this.lblConfent_rsva.Location = new System.Drawing.Point(12, 410);
            this.lblConfent_rsva.Name = "lblConfent_rsva";
            this.lblConfent_rsva.Size = new System.Drawing.Size(125, 15);
            this.lblConfent_rsva.TabIndex = 17;
            this.lblConfent_rsva.Text = "Confirmación entrada";
            // 
            // lblConfsal_rsva
            // 
            this.lblConfsal_rsva.AutoSize = true;
            this.lblConfsal_rsva.Location = new System.Drawing.Point(335, 410);
            this.lblConfsal_rsva.Name = "lblConfsal_rsva";
            this.lblConfsal_rsva.Size = new System.Drawing.Size(116, 15);
            this.lblConfsal_rsva.TabIndex = 18;
            this.lblConfsal_rsva.Text = "Confirmación salida";
            // 
            // cboConfsal_rsva
            // 
            this.cboConfsal_rsva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConfsal_rsva.FormattingEnabled = true;
            this.cboConfsal_rsva.Items.AddRange(new object[] {
            "Confirmado",
            "No confirmado"});
            this.cboConfsal_rsva.Location = new System.Drawing.Point(457, 407);
            this.cboConfsal_rsva.Name = "cboConfsal_rsva";
            this.cboConfsal_rsva.Size = new System.Drawing.Size(150, 23);
            this.cboConfsal_rsva.TabIndex = 22;
            this.cboConfsal_rsva.SelectedIndexChanged += new System.EventHandler(this.cboConfsal_rsva_SelectedIndexChanged);
            // 
            // txtConfent_rsva
            // 
            this.txtConfent_rsva.Location = new System.Drawing.Point(299, 407);
            this.txtConfent_rsva.MaxLength = 4;
            this.txtConfent_rsva.Name = "txtConfent_rsva";
            this.txtConfent_rsva.Size = new System.Drawing.Size(21, 21);
            this.txtConfent_rsva.TabIndex = 20;
            this.txtConfent_rsva.Tag = "confent_rsva";
            this.txtConfent_rsva.Visible = false;
            this.txtConfent_rsva.EnabledChanged += new System.EventHandler(this.txtConfent_rsva_EnabledChanged);
            this.txtConfent_rsva.TextChanged += new System.EventHandler(this.txtConfent_rsva_TextChanged);
            // 
            // txtConfsal_rsva
            // 
            this.txtConfsal_rsva.Location = new System.Drawing.Point(308, 407);
            this.txtConfsal_rsva.MaxLength = 4;
            this.txtConfsal_rsva.Name = "txtConfsal_rsva";
            this.txtConfsal_rsva.Size = new System.Drawing.Size(21, 21);
            this.txtConfsal_rsva.TabIndex = 21;
            this.txtConfsal_rsva.Tag = "confsal_rsva";
            this.txtConfsal_rsva.Visible = false;
            this.txtConfsal_rsva.EnabledChanged += new System.EventHandler(this.txtConfsal_rsva_EnabledChanged);
            this.txtConfsal_rsva.TextChanged += new System.EventHandler(this.txtConfsal_rsva_TextChanged);
            // 
            // dtpFechres_rsva
            // 
            this.dtpFechres_rsva.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFechres_rsva.Enabled = false;
            this.dtpFechres_rsva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechres_rsva.Location = new System.Drawing.Point(143, 299);
            this.dtpFechres_rsva.Name = "dtpFechres_rsva";
            this.dtpFechres_rsva.Size = new System.Drawing.Size(150, 21);
            this.dtpFechres_rsva.TabIndex = 14;
            this.dtpFechres_rsva.ValueChanged += new System.EventHandler(this.dtpFechres_rsva_ValueChanged);
            // 
            // dtpFechent_rsva
            // 
            this.dtpFechent_rsva.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFechent_rsva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechent_rsva.Location = new System.Drawing.Point(143, 326);
            this.dtpFechent_rsva.Name = "dtpFechent_rsva";
            this.dtpFechent_rsva.Size = new System.Drawing.Size(150, 21);
            this.dtpFechent_rsva.TabIndex = 15;
            this.dtpFechent_rsva.Tag = "";
            this.dtpFechent_rsva.ValueChanged += new System.EventHandler(this.dtpFechent_rsva_ValueChanged);
            // 
            // dtpFechsal_rsva
            // 
            this.dtpFechsal_rsva.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFechsal_rsva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechsal_rsva.Location = new System.Drawing.Point(457, 326);
            this.dtpFechsal_rsva.Name = "dtpFechsal_rsva";
            this.dtpFechsal_rsva.Size = new System.Drawing.Size(150, 21);
            this.dtpFechsal_rsva.TabIndex = 16;
            this.dtpFechsal_rsva.ValueChanged += new System.EventHandler(this.dtpFechsal_rsva_ValueChanged);
            // 
            // txtFechres_rsva
            // 
            this.txtFechres_rsva.Location = new System.Drawing.Point(299, 301);
            this.txtFechres_rsva.MaxLength = 4;
            this.txtFechres_rsva.Name = "txtFechres_rsva";
            this.txtFechres_rsva.Size = new System.Drawing.Size(21, 21);
            this.txtFechres_rsva.TabIndex = 23;
            this.txtFechres_rsva.Tag = "fechres_rsva";
            this.txtFechres_rsva.Visible = false;
            this.txtFechres_rsva.EnabledChanged += new System.EventHandler(this.txtFechres_rsva_EnabledChanged);
            this.txtFechres_rsva.TextChanged += new System.EventHandler(this.txtFechres_rsva_TextChanged);
            // 
            // txtFechent_rsva
            // 
            this.txtFechent_rsva.Location = new System.Drawing.Point(299, 326);
            this.txtFechent_rsva.MaxLength = 4;
            this.txtFechent_rsva.Name = "txtFechent_rsva";
            this.txtFechent_rsva.Size = new System.Drawing.Size(21, 21);
            this.txtFechent_rsva.TabIndex = 24;
            this.txtFechent_rsva.Tag = "fechent_rsva";
            this.txtFechent_rsva.Visible = false;
            this.txtFechent_rsva.EnabledChanged += new System.EventHandler(this.txtFechent_rsva_EnabledChanged);
            this.txtFechent_rsva.TextChanged += new System.EventHandler(this.txtFechent_rsva_TextChanged);
            // 
            // txtFechsal_rsva
            // 
            this.txtFechsal_rsva.Location = new System.Drawing.Point(586, 301);
            this.txtFechsal_rsva.MaxLength = 4;
            this.txtFechsal_rsva.Name = "txtFechsal_rsva";
            this.txtFechsal_rsva.Size = new System.Drawing.Size(21, 21);
            this.txtFechsal_rsva.TabIndex = 25;
            this.txtFechsal_rsva.Tag = "fechsal_rsva";
            this.txtFechsal_rsva.Visible = false;
            this.txtFechsal_rsva.EnabledChanged += new System.EventHandler(this.txtFechsal_rsva_EnabledChanged);
            this.txtFechsal_rsva.TextChanged += new System.EventHandler(this.txtFechsal_rsva_TextChanged);
            // 
            // txtTotal_rsva
            // 
            this.txtTotal_rsva.Location = new System.Drawing.Point(144, 380);
            this.txtTotal_rsva.MaxLength = 10;
            this.txtTotal_rsva.Name = "txtTotal_rsva";
            this.txtTotal_rsva.Size = new System.Drawing.Size(150, 21);
            this.txtTotal_rsva.TabIndex = 19;
            this.txtTotal_rsva.Tag = "total_rsva";
            this.txtTotal_rsva.EnabledChanged += new System.EventHandler(this.txtTotal_rsva_EnabledChanged);
            this.txtTotal_rsva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_rsva_KeyPress);
            // 
            // lblTotal_rsva
            // 
            this.lblTotal_rsva.AutoSize = true;
            this.lblTotal_rsva.Location = new System.Drawing.Point(12, 383);
            this.lblTotal_rsva.Name = "lblTotal_rsva";
            this.lblTotal_rsva.Size = new System.Drawing.Size(117, 15);
            this.lblTotal_rsva.TabIndex = 26;
            this.lblTotal_rsva.Text = "Total de reservación";
            // 
            // dgvDetalleReservacion
            // 
            this.dgvDetalleReservacion.AllowUserToAddRows = false;
            this.dgvDetalleReservacion.AllowUserToResizeColumns = false;
            this.dgvDetalleReservacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalleReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleReservacion.Location = new System.Drawing.Point(11, 473);
            this.dgvDetalleReservacion.MultiSelect = false;
            this.dgvDetalleReservacion.Name = "dgvDetalleReservacion";
            this.dgvDetalleReservacion.ReadOnly = true;
            this.dgvDetalleReservacion.RowHeadersVisible = false;
            this.dgvDetalleReservacion.RowHeadersWidth = 30;
            this.dgvDetalleReservacion.RowTemplate.Height = 20;
            this.dgvDetalleReservacion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleReservacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleReservacion.Size = new System.Drawing.Size(420, 170);
            this.dgvDetalleReservacion.TabIndex = 27;
            this.dgvDetalleReservacion.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetalleReservacion_RowsAdded);
            this.dgvDetalleReservacion.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalleReservacion_RowsRemoved);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(453, 543);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 15);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "Total";
            // 
            // lblAambiente
            // 
            this.lblAambiente.AutoSize = true;
            this.lblAambiente.Location = new System.Drawing.Point(452, 499);
            this.lblAambiente.Name = "lblAambiente";
            this.lblAambiente.Size = new System.Drawing.Size(59, 15);
            this.lblAambiente.TabIndex = 40;
            this.lblAambiente.Text = "Ambiente";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(455, 588);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 23);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar Ambiente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTotalAmbiente
            // 
            this.txtTotalAmbiente.Enabled = false;
            this.txtTotalAmbiente.Location = new System.Drawing.Point(455, 561);
            this.txtTotalAmbiente.Name = "txtTotalAmbiente";
            this.txtTotalAmbiente.Size = new System.Drawing.Size(150, 21);
            this.txtTotalAmbiente.TabIndex = 26;
            // 
            // cboCodigos
            // 
            this.cboCodigos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigos.FormattingEnabled = true;
            this.cboCodigos.Location = new System.Drawing.Point(455, 517);
            this.cboCodigos.Name = "cboCodigos";
            this.cboCodigos.Size = new System.Drawing.Size(150, 23);
            this.cboCodigos.TabIndex = 25;
            this.cboCodigos.SelectedIndexChanged += new System.EventHandler(this.cboCodigos_SelectedIndexChanged);
            // 
            // btnBuscarAmbientes
            // 
            this.btnBuscarAmbientes.Location = new System.Drawing.Point(455, 473);
            this.btnBuscarAmbientes.Name = "btnBuscarAmbientes";
            this.btnBuscarAmbientes.Size = new System.Drawing.Size(152, 23);
            this.btnBuscarAmbientes.TabIndex = 24;
            this.btnBuscarAmbientes.Text = "Buscar Ambientes";
            this.btnBuscarAmbientes.UseVisualStyleBackColor = true;
            this.btnBuscarAmbientes.Click += new System.EventHandler(this.btnBuscarAmbientes_Click);
            // 
            // lblEstado_rsva
            // 
            this.lblEstado_rsva.AutoSize = true;
            this.lblEstado_rsva.Location = new System.Drawing.Point(11, 439);
            this.lblEstado_rsva.Name = "lblEstado_rsva";
            this.lblEstado_rsva.Size = new System.Drawing.Size(45, 15);
            this.lblEstado_rsva.TabIndex = 42;
            this.lblEstado_rsva.Text = "Estado";
            // 
            // cboEstado_rsva
            // 
            this.cboEstado_rsva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_rsva.FormattingEnabled = true;
            this.cboEstado_rsva.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_rsva.Location = new System.Drawing.Point(143, 436);
            this.cboEstado_rsva.Name = "cboEstado_rsva";
            this.cboEstado_rsva.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_rsva.TabIndex = 23;
            this.cboEstado_rsva.SelectedIndexChanged += new System.EventHandler(this.cboEstado_rsva_SelectedIndexChanged);
            // 
            // txtEstado_rsva
            // 
            this.txtEstado_rsva.Location = new System.Drawing.Point(299, 436);
            this.txtEstado_rsva.MaxLength = 4;
            this.txtEstado_rsva.Name = "txtEstado_rsva";
            this.txtEstado_rsva.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_rsva.TabIndex = 44;
            this.txtEstado_rsva.Tag = "estado_rsva";
            this.txtEstado_rsva.Visible = false;
            this.txtEstado_rsva.EnabledChanged += new System.EventHandler(this.txtEstado_rsva_EnabledChanged);
            this.txtEstado_rsva.TextChanged += new System.EventHandler(this.txtEstado_rsva_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(21, 21);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(678, 189);
            this.navegador1.TabIndex = 45;
            // 
            // wfReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 662);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado_rsva);
            this.Controls.Add(this.cboEstado_rsva);
            this.Controls.Add(this.lblEstado_rsva);
            this.Controls.Add(this.btnBuscarAmbientes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAambiente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotalAmbiente);
            this.Controls.Add(this.cboCodigos);
            this.Controls.Add(this.dgvDetalleReservacion);
            this.Controls.Add(this.txtTotal_rsva);
            this.Controls.Add(this.lblTotal_rsva);
            this.Controls.Add(this.txtFechsal_rsva);
            this.Controls.Add(this.txtFechent_rsva);
            this.Controls.Add(this.txtFechres_rsva);
            this.Controls.Add(this.dtpFechsal_rsva);
            this.Controls.Add(this.dtpFechent_rsva);
            this.Controls.Add(this.dtpFechres_rsva);
            this.Controls.Add(this.txtConfsal_rsva);
            this.Controls.Add(this.txtConfent_rsva);
            this.Controls.Add(this.cboConfsal_rsva);
            this.Controls.Add(this.lblConfsal_rsva);
            this.Controls.Add(this.lblConfent_rsva);
            this.Controls.Add(this.cboConfent_rsva);
            this.Controls.Add(this.txtDias_rsva);
            this.Controls.Add(this.txtNinos_rsva);
            this.Controls.Add(this.txtAdultos_rsva);
            this.Controls.Add(this.lblDias_rsva);
            this.Controls.Add(this.lblNinos_rsva);
            this.Controls.Add(this.lblAdultos_rsva);
            this.Controls.Add(this.lblFechsal_rsva);
            this.Controls.Add(this.lblFechent_rsva);
            this.Controls.Add(this.lblFechres_rsva);
            this.Controls.Add(this.txtCod_cte);
            this.Controls.Add(this.lblCod_cte);
            this.Controls.Add(this.lblCod_rsva);
            this.Controls.Add(this.txtCod_rsva);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfReservacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservaciones";
            this.Load += new System.EventHandler(this.wfReservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReservacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCod_rsva;
        private System.Windows.Forms.Label lblCod_rsva;
        private System.Windows.Forms.Label lblCod_cte;
        private System.Windows.Forms.TextBox txtCod_cte;
        private System.Windows.Forms.Label lblFechres_rsva;
        private System.Windows.Forms.Label lblFechent_rsva;
        private System.Windows.Forms.Label lblFechsal_rsva;
        private System.Windows.Forms.Label lblAdultos_rsva;
        private System.Windows.Forms.Label lblNinos_rsva;
        private System.Windows.Forms.Label lblDias_rsva;
        private System.Windows.Forms.TextBox txtAdultos_rsva;
        private System.Windows.Forms.TextBox txtNinos_rsva;
        private System.Windows.Forms.TextBox txtDias_rsva;
        private System.Windows.Forms.ComboBox cboConfent_rsva;
        private System.Windows.Forms.Label lblConfent_rsva;
        private System.Windows.Forms.Label lblConfsal_rsva;
        private System.Windows.Forms.ComboBox cboConfsal_rsva;
        private System.Windows.Forms.TextBox txtConfent_rsva;
        private System.Windows.Forms.TextBox txtConfsal_rsva;
        private System.Windows.Forms.DateTimePicker dtpFechres_rsva;
        private System.Windows.Forms.DateTimePicker dtpFechent_rsva;
        private System.Windows.Forms.DateTimePicker dtpFechsal_rsva;
        private System.Windows.Forms.TextBox txtFechres_rsva;
        private System.Windows.Forms.TextBox txtFechent_rsva;
        private System.Windows.Forms.TextBox txtFechsal_rsva;
        private System.Windows.Forms.TextBox txtTotal_rsva;
        private System.Windows.Forms.Label lblTotal_rsva;
        private System.Windows.Forms.DataGridView dgvDetalleReservacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAambiente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTotalAmbiente;
        private System.Windows.Forms.ComboBox cboCodigos;
        private System.Windows.Forms.Button btnBuscarAmbientes;
        private System.Windows.Forms.Label lblEstado_rsva;
        private System.Windows.Forms.ComboBox cboEstado_rsva;
        private System.Windows.Forms.TextBox txtEstado_rsva;
        private NavegadorVista.Navegador navegador1;
    }
}