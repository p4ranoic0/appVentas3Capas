namespace Quipu_GUI.ManRepartidor
{
    partial class frmRepartidor
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgRepartidor = new System.Windows.Forms.DataGridView();
            this.id_repartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_repartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_repartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_repartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_repartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_repartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_repartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepartidor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(779, 490);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 37);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(669, 490);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 37);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(559, 490);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(104, 37);
            this.btnInsertar.TabIndex = 12;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(829, 429);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 26);
            this.lblRegistros.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(769, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Registros:";
            // 
            // txtCad
            // 
            this.txtCad.Location = new System.Drawing.Point(223, 48);
            this.txtCad.Name = "txtCad";
            this.txtCad.Size = new System.Drawing.Size(368, 20);
            this.txtCad.TabIndex = 7;
            this.txtCad.TextChanged += new System.EventHandler(this.txtCad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Repartidor";
            // 
            // dtgRepartidor
            // 
            this.dtgRepartidor.AllowUserToAddRows = false;
            this.dtgRepartidor.AllowUserToDeleteRows = false;
            this.dtgRepartidor.AllowUserToOrderColumns = true;
            this.dtgRepartidor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRepartidor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRepartidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRepartidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_repartidor,
            this.nom_repartidor,
            this.ape_repartidor,
            this.dni_repartidor,
            this.correo_repartidor,
            this.tel_repartidor,
            this.fecha_nac,
            this.est_repartidor});
            this.dtgRepartidor.Location = new System.Drawing.Point(51, 105);
            this.dtgRepartidor.Name = "dtgRepartidor";
            this.dtgRepartidor.RowHeadersVisible = false;
            this.dtgRepartidor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRepartidor.Size = new System.Drawing.Size(832, 312);
            this.dtgRepartidor.TabIndex = 5;
            // 
            // id_repartidor
            // 
            this.id_repartidor.DataPropertyName = "id_repartidor";
            this.id_repartidor.HeaderText = "Id";
            this.id_repartidor.Name = "id_repartidor";
            // 
            // nom_repartidor
            // 
            this.nom_repartidor.DataPropertyName = "nom_repartidor";
            this.nom_repartidor.HeaderText = "Nombre";
            this.nom_repartidor.Name = "nom_repartidor";
            // 
            // ape_repartidor
            // 
            this.ape_repartidor.DataPropertyName = "ape_repartidor";
            this.ape_repartidor.HeaderText = "Apellido";
            this.ape_repartidor.Name = "ape_repartidor";
            // 
            // dni_repartidor
            // 
            this.dni_repartidor.DataPropertyName = "dni_repartidor";
            this.dni_repartidor.HeaderText = "DNI";
            this.dni_repartidor.Name = "dni_repartidor";
            // 
            // correo_repartidor
            // 
            this.correo_repartidor.DataPropertyName = "correo_repartidor";
            this.correo_repartidor.HeaderText = "Correo";
            this.correo_repartidor.Name = "correo_repartidor";
            // 
            // tel_repartidor
            // 
            this.tel_repartidor.DataPropertyName = "tel_repartidor";
            this.tel_repartidor.HeaderText = "Telefono";
            this.tel_repartidor.Name = "tel_repartidor";
            // 
            // fecha_nac
            // 
            this.fecha_nac.DataPropertyName = "fecha_nac";
            this.fecha_nac.HeaderText = "Fecha Nacimiento";
            this.fecha_nac.Name = "fecha_nac";
            // 
            // est_repartidor
            // 
            this.est_repartidor.DataPropertyName = "est_repartidor";
            this.est_repartidor.HeaderText = "Estado";
            this.est_repartidor.Name = "est_repartidor";
            // 
            // frmRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 561);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgRepartidor);
            this.Name = "frmRepartidor";
            this.Text = "frmRepartidor";
            this.Load += new System.EventHandler(this.frmRepartidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepartidor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgRepartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_repartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_repartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_repartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_repartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_repartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_repartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn est_repartidor;
    }
}