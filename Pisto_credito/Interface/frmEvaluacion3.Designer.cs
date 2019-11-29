namespace Pisto_credito.Interface
{
    partial class frmEvaluacion3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_desaprobar = new System.Windows.Forms.Button();
            this.btn_Aprobar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_idProspecto = new System.Windows.Forms.TextBox();
            this.txt_Hijos = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Sueldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hijos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProspecto = new System.Windows.Forms.DataGridView();
            this.idProspecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eldpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProspecto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "EVALUACION 3";
            // 
            // btn_desaprobar
            // 
            this.btn_desaprobar.Location = new System.Drawing.Point(458, 366);
            this.btn_desaprobar.Name = "btn_desaprobar";
            this.btn_desaprobar.Size = new System.Drawing.Size(186, 55);
            this.btn_desaprobar.TabIndex = 45;
            this.btn_desaprobar.Text = "Desaprobar Evaluacion";
            this.btn_desaprobar.UseVisualStyleBackColor = true;
            this.btn_desaprobar.Click += new System.EventHandler(this.btn_desaprobar_Click);
            // 
            // btn_Aprobar
            // 
            this.btn_Aprobar.Enabled = false;
            this.btn_Aprobar.Location = new System.Drawing.Point(204, 366);
            this.btn_Aprobar.Name = "btn_Aprobar";
            this.btn_Aprobar.Size = new System.Drawing.Size(186, 55);
            this.btn_Aprobar.TabIndex = 43;
            this.btn_Aprobar.Text = "Aprobar Evaluacion";
            this.btn_Aprobar.UseVisualStyleBackColor = true;
            this.btn_Aprobar.Click += new System.EventHandler(this.btn_Aprobar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(652, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Id Prospecto:";
            // 
            // txt_idProspecto
            // 
            this.txt_idProspecto.Location = new System.Drawing.Point(729, 34);
            this.txt_idProspecto.Name = "txt_idProspecto";
            this.txt_idProspecto.ReadOnly = true;
            this.txt_idProspecto.Size = new System.Drawing.Size(102, 20);
            this.txt_idProspecto.TabIndex = 48;
            this.txt_idProspecto.TextChanged += new System.EventHandler(this.txt_idProspecto_TextChanged);
            // 
            // txt_Hijos
            // 
            this.txt_Hijos.Location = new System.Drawing.Point(204, 182);
            this.txt_Hijos.Name = "txt_Hijos";
            this.txt_Hijos.Size = new System.Drawing.Size(133, 20);
            this.txt_Hijos.TabIndex = 50;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(124, 25);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.ReadOnly = true;
            this.txt_Edad.Size = new System.Drawing.Size(133, 20);
            this.txt_Edad.TabIndex = 51;
            this.txt_Edad.TextChanged += new System.EventHandler(this.txt_Edad_TextChanged);
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(204, 142);
            this.txt_Sueldo.Name = "txt_Sueldo";
            this.txt_Sueldo.Size = new System.Drawing.Size(133, 20);
            this.txt_Sueldo.TabIndex = 52;
            this.txt_Sueldo.BindingContextChanged += new System.EventHandler(this.txt_Sueldo_BindingContextChanged);
            this.txt_Sueldo.TextChanged += new System.EventHandler(this.txt_Sueldo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Hijos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Sueldo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 57;
            this.button1.Text = "Guardar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(124, 26);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(133, 20);
            this.numericUpDown1.TabIndex = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Edad);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(80, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 147);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hijos,
            this.sueldo});
            this.dataGridView1.Location = new System.Drawing.Point(613, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(248, 58);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hijos
            // 
            this.hijos.DataPropertyName = "hijos";
            this.hijos.HeaderText = "Hijos";
            this.hijos.Name = "hijos";
            this.hijos.ReadOnly = true;
            // 
            // sueldo
            // 
            this.sueldo.DataPropertyName = "sueldo";
            this.sueldo.HeaderText = "Sueldo";
            this.sueldo.Name = "sueldo";
            this.sueldo.ReadOnly = true;
            this.sueldo.Width = 105;
            // 
            // dtgProspecto
            // 
            this.dtgProspecto.AccessibleDescription = "  ";
            this.dtgProspecto.AllowUserToAddRows = false;
            this.dtgProspecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProspecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProspecto,
            this.eldpi,
            this.nombre,
            this.nit,
            this.correo1,
            this.correo2,
            this.tel1,
            this.tel2,
            this.telTrabajo,
            this.telDomicilio,
            this.trabajo,
            this.domicilio,
            this.idProducto,
            this.edad,
            this.estado});
            this.dtgProspecto.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgProspecto.Location = new System.Drawing.Point(27, 263);
            this.dtgProspecto.Name = "dtgProspecto";
            this.dtgProspecto.ReadOnly = true;
            this.dtgProspecto.Size = new System.Drawing.Size(834, 71);
            this.dtgProspecto.TabIndex = 61;
            this.dtgProspecto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProspecto_CellContentClick);
            // 
            // idProspecto
            // 
            this.idProspecto.DataPropertyName = "idProspecto";
            this.idProspecto.HeaderText = "idProspecto";
            this.idProspecto.Name = "idProspecto";
            this.idProspecto.ReadOnly = true;
            this.idProspecto.Width = 80;
            // 
            // eldpi
            // 
            this.eldpi.DataPropertyName = "dpi";
            this.eldpi.HeaderText = "DPI";
            this.eldpi.Name = "eldpi";
            this.eldpi.ReadOnly = true;
            this.eldpi.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombres:";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // nit
            // 
            this.nit.DataPropertyName = "nit";
            this.nit.HeaderText = "Nit:";
            this.nit.Name = "nit";
            this.nit.ReadOnly = true;
            this.nit.Visible = false;
            this.nit.Width = 80;
            // 
            // correo1
            // 
            this.correo1.DataPropertyName = "correo1";
            this.correo1.HeaderText = "Correo 1";
            this.correo1.Name = "correo1";
            this.correo1.ReadOnly = true;
            this.correo1.Visible = false;
            // 
            // correo2
            // 
            this.correo2.DataPropertyName = "correo2";
            this.correo2.HeaderText = "Correo 2";
            this.correo2.Name = "correo2";
            this.correo2.ReadOnly = true;
            this.correo2.Visible = false;
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
            this.tel2.Visible = false;
            // 
            // telTrabajo
            // 
            this.telTrabajo.DataPropertyName = "telTrabajo";
            this.telTrabajo.HeaderText = "Tel. Trabajo";
            this.telTrabajo.Name = "telTrabajo";
            this.telTrabajo.ReadOnly = true;
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
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
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
            // frmEvaluacion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 473);
            this.Controls.Add(this.dtgProspecto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Sueldo);
            this.Controls.Add(this.txt_Hijos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_idProspecto);
            this.Controls.Add(this.btn_desaprobar);
            this.Controls.Add(this.btn_Aprobar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEvaluacion3";
            this.Text = "Evaluacion 3";
            this.Load += new System.EventHandler(this.frmEvaluacion3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProspecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_desaprobar;
        private System.Windows.Forms.Button btn_Aprobar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_idProspecto;
        private System.Windows.Forms.TextBox txt_Hijos;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_Sueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hijos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
        private System.Windows.Forms.DataGridView dtgProspecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProspecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn eldpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}