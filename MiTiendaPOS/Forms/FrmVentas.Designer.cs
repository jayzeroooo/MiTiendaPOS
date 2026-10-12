namespace MiTiendaPOS.Forms
{
    partial class frmVentas
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
            grpEncabezado = new GroupBox();
            cboUsuario = new ComboBox();
            cboCliente = new ComboBox();
            lblVenta = new Label();
            lblUsuario = new Label();
            lblCliente = new Label();
            grpHistorial = new GroupBox();
            dgvVentas = new DataGridView();
            label6 = new Label();
            grpDetalle = new GroupBox();
            btnQuitar = new Button();
            dgvDetalle = new DataGridView();
            btnAgregar = new Button();
            nudCantidad = new NumericUpDown();
            cboProducto = new ComboBox();
            lblTotal = new Label();
            lblCantidad = new Label();
            lblProducto = new Label();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpEncabezado.SuspendLayout();
            grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // grpEncabezado
            // 
            grpEncabezado.Controls.Add(cboUsuario);
            grpEncabezado.Controls.Add(cboCliente);
            grpEncabezado.Controls.Add(lblVenta);
            grpEncabezado.Controls.Add(lblUsuario);
            grpEncabezado.Controls.Add(lblCliente);
            grpEncabezado.Location = new Point(12, 12);
            grpEncabezado.Name = "grpEncabezado";
            grpEncabezado.Size = new Size(510, 125);
            grpEncabezado.TabIndex = 1;
            grpEncabezado.TabStop = false;
            grpEncabezado.Text = "Encabezado de la venta";
            // 
            // cboUsuario
            // 
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(314, 26);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(190, 28);
            cboUsuario.TabIndex = 4;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(67, 26);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(176, 28);
            cboCliente.TabIndex = 3;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenta.Location = new Point(30, 89);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(98, 20);
            lblVenta.TabIndex = 2;
            lblVenta.Text = "Venta Nueva";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(249, 29);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(6, 29);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // grpHistorial
            // 
            grpHistorial.Controls.Add(dgvVentas);
            grpHistorial.Location = new Point(545, 12);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Size = new Size(445, 589);
            grpHistorial.TabIndex = 7;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de Ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(6, 29);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(433, 522);
            dgvVentas.TabIndex = 13;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 443);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 16;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(btnQuitar);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnAgregar);
            grpDetalle.Controls.Add(nudCantidad);
            grpDetalle.Controls.Add(cboProducto);
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Controls.Add(lblCantidad);
            grpDetalle.Controls.Add(lblProducto);
            grpDetalle.Location = new Point(12, 143);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(510, 406);
            grpDetalle.TabIndex = 8;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de Productos";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(18, 300);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(94, 29);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "Quitar linea";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(18, 95);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(470, 188);
            dgvDetalle.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(394, 47);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(314, 48);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(63, 27);
            nudCantidad.TabIndex = 9;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(85, 47);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(158, 28);
            cboProducto.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(271, 300);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(147, 32);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: $0.00";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblCantidad.Location = new Point(253, 52);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(6, 47);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(73, 20);
            lblProducto.TabIndex = 5;
            lblProducto.Text = "Producto";
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(12, 555);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(145, 34);
            btnNueva.TabIndex = 13;
            btnNueva.Text = "Nueva venta";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Highlight;
            btnGuardar.Location = new Point(179, 555);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(141, 34);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar venta";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(348, 555);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(174, 34);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar venta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 613);
            Controls.Add(btnEliminar);
            Controls.Add(grpDetalle);
            Controls.Add(btnGuardar);
            Controls.Add(grpHistorial);
            Controls.Add(btnNueva);
            Controls.Add(label6);
            Controls.Add(grpEncabezado);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmVentas";
            Load += FrmVentas_Load;
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDetalle;
        private GroupBox grpEncabezado;
        private GroupBox grpHistorial;
        private Label label6;
        private Label lblVenta;
        private Label lblUsuario;
        private Label lblCliente;
        private ComboBox cboUsuario;
        private ComboBox cboCliente;
        private Label lblTotal;
        private Label lblCantidad;
        private Label lblProducto;
        private DataGridView dgvDetalle;
        private Button btnAgregar;
        private NumericUpDown nudCantidad;
        private ComboBox cboProducto;
        private Button btnQuitar;
        private DataGridView dgvVentas;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNueva;
    }
}