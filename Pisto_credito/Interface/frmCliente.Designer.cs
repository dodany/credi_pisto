namespace Pisto_credito
{
    partial class frmCliente
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
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pagos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(806, 589);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(143, 43);
            this.btnReporte.TabIndex = 49;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1135, 567);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 32);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombre,
            this.dpi,
            this.nit,
            this.correo1,
            this.correo2,
            this.tel1,
            this.tel2,
            this.domicilio,
            this.telDomicilio,
            this.trabajo,
            this.telTrabajo,
            this.idProducto,
            this.edad,
            this.estado});
            this.dtgCliente.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgCliente.Location = new System.Drawing.Point(70, 143);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.Size = new System.Drawing.Size(1198, 358);
            this.dtgCliente.TabIndex = 45;
            this.dtgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProspecto_CellContentClick);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombres:";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // dpi
            // 
            this.dpi.DataPropertyName = "dpi";
            this.dpi.HeaderText = "DPI:";
            this.dpi.Name = "dpi";
            this.dpi.ReadOnly = true;
            this.dpi.Width = 80;
            // 
            // nit
            // 
            this.nit.DataPropertyName = "nit";
            this.nit.HeaderText = "Nit:";
            this.nit.Name = "nit";
            this.nit.ReadOnly = true;
            this.nit.Width = 80;
            // 
            // correo1
            // 
            this.correo1.DataPropertyName = "correo1";
            this.correo1.HeaderText = "Correo 1";
            this.correo1.Name = "correo1";
            this.correo1.ReadOnly = true;
            // 
            // correo2
            // 
            this.correo2.DataPropertyName = "correo2";
            this.correo2.HeaderText = "Correo 2";
            this.correo2.Name = "correo2";
            this.correo2.ReadOnly = true;
            // 
            // tel1
            // 
            this.tel1.DataPropertyName = "tel1";
            this.tel1.HeaderText = "Telefono 1";
            this.tel1.Name = "tel1";
            this.tel1.ReadOnly = true;
            // 
            // tel2
            // 
            this.tel2.DataPropertyName = "tel2";
            this.tel2.HeaderText = "Telefono 2";
            this.tel2.Name = "tel2";
            this.tel2.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // telDomicilio
            // 
            this.telDomicilio.DataPropertyName = "telDomicilio";
            this.telDomicilio.HeaderText = "Tel. Domicilio";
            this.telDomicilio.Name = "telDomicilio";
            this.telDomicilio.ReadOnly = true;
            // 
            // trabajo
            // 
            this.trabajo.DataPropertyName = "trabajo";
            this.trabajo.HeaderText = "Trabajo";
            this.trabajo.Name = "trabajo";
            this.trabajo.ReadOnly = true;
            // 
            // telTrabajo
            // 
            this.telTrabajo.DataPropertyName = "telTrabajo";
            this.telTrabajo.HeaderText = "Tel. Trabajo";
            this.telTrabajo.Name = "telTrabajo";
            this.telTrabajo.ReadOnly = true;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 80;
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 60;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "CLIENTES";
            // 
            // btn_Pagos
            // 
            this.btn_Pagos.Location = new System.Drawing.Point(561, 556);
            this.btn_Pagos.Name = "btn_Pagos";
            this.btn_Pagos.Size = new System.Drawing.Size(204, 43);
            this.btn_Pagos.TabIndex = 50;
            this.btn_Pagos.Text = "Plan de Pagos ";
            this.btn_Pagos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1193, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Pagos);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.label1);
            this.Name = "frmCliente";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btn_Pagos;
        public System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Button button1;
    }
}