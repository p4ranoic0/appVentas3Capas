namespace Quipu_GUI.ManCliente
{
    partial class frmClientes
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
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.AllowUserToOrderColumns = true;
            this.dtgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nom_cliente,
            this.ape_cliente,
            this.dni_cliente,
            this.correo_cliente,
            this.dir_cliente,
            this.tel_cliente});
            this.dtgCliente.Location = new System.Drawing.Point(45, 77);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.RowHeadersVisible = false;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(889, 327);
            this.dtgCliente.TabIndex = 0;
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "Id";
            this.id_cliente.Name = "id_cliente";
            // 
            // nom_cliente
            // 
            this.nom_cliente.DataPropertyName = "nom_cliente";
            this.nom_cliente.HeaderText = "Nombre";
            this.nom_cliente.Name = "nom_cliente";
            // 
            // ape_cliente
            // 
            this.ape_cliente.DataPropertyName = "ape_cliente";
            this.ape_cliente.HeaderText = "Apellido";
            this.ape_cliente.Name = "ape_cliente";
            // 
            // dni_cliente
            // 
            this.dni_cliente.DataPropertyName = "dni_cliente";
            this.dni_cliente.HeaderText = "DNI";
            this.dni_cliente.Name = "dni_cliente";
            // 
            // correo_cliente
            // 
            this.correo_cliente.DataPropertyName = "correo_cliente";
            this.correo_cliente.HeaderText = "Correo";
            this.correo_cliente.Name = "correo_cliente";
            // 
            // dir_cliente
            // 
            this.dir_cliente.DataPropertyName = "dir_cliente";
            this.dir_cliente.HeaderText = "Direccion";
            this.dir_cliente.Name = "dir_cliente";
            // 
            // tel_cliente
            // 
            this.tel_cliente.DataPropertyName = "tel_cliente";
            this.tel_cliente.HeaderText = "Telefono";
            this.tel_cliente.Name = "tel_cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre o Apellido de Cliente";
            // 
            // txtCad
            // 
            this.txtCad.Location = new System.Drawing.Point(218, 26);
            this.txtCad.Name = "txtCad";
            this.txtCad.Size = new System.Drawing.Size(368, 20);
            this.txtCad.TabIndex = 2;
            this.txtCad.TextChanged += new System.EventHandler(this.txtCad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(880, 413);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 26);
            this.lblRegistros.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(610, 474);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(104, 37);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(720, 474);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 37);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(830, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 535);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCliente);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_cliente;
    }
}