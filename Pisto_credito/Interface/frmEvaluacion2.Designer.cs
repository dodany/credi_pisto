namespace Pisto_credito.Interface
{
    partial class frmEvaluacion2
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
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.btn_Aprobar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_idProspecto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgProspecto = new System.Windows.Forms.DataGridView();
            this.idProspecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Domicilio = new System.Windows.Forms.TextBox();
            this.txt_Trabajo = new System.Windows.Forms.TextBox();
            this.btn_VerficarDomicilio = new System.Windows.Forms.Button();
            this.btn_VerificarTrabajo = new System.Windows.Forms.Button();
            this.txt_telTrabajo = new System.Windows.Forms.TextBox();
            this.txt_telDomicilio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProspecto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "EVALUACION 2";
            // 
            // btn_desaprobar
            // 
            this.btn_desaprobar.Location = new System.Drawing.Point(445, 447);
            this.btn_desaprobar.Name = "btn_desaprobar";
            this.btn_desaprobar.Size = new System.Drawing.Size(186, 55);
            this.btn_desaprobar.TabIndex = 45;
            this.btn_desaprobar.Text = "Desaprobar Evaluacion";
            this.btn_desaprobar.UseVisualStyleBackColor = true;
            this.btn_desaprobar.Visible = false;
            this.btn_desaprobar.Click += new System.EventHandler(this.btn_desaprobar_Click);
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(361, 508);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(148, 45);
            this.btn_Continuar.TabIndex = 44;
            this.btn_Continuar.Text = "Continuar Evaluando";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // btn_Aprobar
            // 
            this.btn_Aprobar.Location = new System.Drawing.Point(243, 447);
            this.btn_Aprobar.Name = "btn_Aprobar";
            this.btn_Aprobar.Size = new System.Drawing.Size(186, 55);
            this.btn_Aprobar.TabIndex = 43;
            this.btn_Aprobar.Text = "Aprobar Evaluacion";
            this.btn_Aprobar.UseVisualStyleBackColor = true;
            this.btn_Aprobar.Visible = false;
            this.btn_Aprobar.Click += new System.EventHandler(this.btn_Aprobar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(591, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Id Prospecto:";
            // 
            // txt_idProspecto
            // 
            this.txt_idProspecto.Location = new System.Drawing.Point(668, 21);
            this.txt_idProspecto.Name = "txt_idProspecto";
            this.txt_idProspecto.ReadOnly = true;
            this.txt_idProspecto.Size = new System.Drawing.Size(102, 20);
            this.txt_idProspecto.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Domicilio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Trabajo:";
            // 
            // dtgProspecto
            // 
            this.dtgProspecto.AllowUserToAddRows = false;
            this.dtgProspecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProspecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProspecto,
            this.nombre,
            this.telTrabajo,
            this.telDomicilio,
            this.trabajo,
            this.domicilio});
            this.dtgProspecto.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgProspecto.Location = new System.Drawing.Point(59, 330);
            this.dtgProspecto.Name = "dtgProspecto";
            this.dtgProspecto.ReadOnly = true;
            this.dtgProspecto.Size = new System.Drawing.Size(760, 71);
            this.dtgProspecto.TabIndex = 51;
            this.dtgProspecto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProspecto_CellContentClick);
            this.dtgProspecto.SelectionChanged += new System.EventHandler(this.dtgProspecto_SelectionChanged);
            // 
            // idProspecto
            // 
            this.idProspecto.DataPropertyName = "idProspecto";
            this.idProspecto.HeaderText = "idProspecto";
            this.idProspecto.Name = "idProspecto";
            this.idProspecto.ReadOnly = true;
            this.idProspecto.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombres:";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 120;
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
            this.trabajo.Width = 120;
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            this.domicilio.Width = 120;
            // 
            // txt_Domicilio
            // 
            this.txt_Domicilio.Location = new System.Drawing.Point(146, 52);
            this.txt_Domicilio.Name = "txt_Domicilio";
            this.txt_Domicilio.Size = new System.Drawing.Size(256, 20);
            this.txt_Domicilio.TabIndex = 52;
            // 
            // txt_Trabajo
            // 
            this.txt_Trabajo.Location = new System.Drawing.Point(146, 128);
            this.txt_Trabajo.Name = "txt_Trabajo";
            this.txt_Trabajo.Size = new System.Drawing.Size(256, 20);
            this.txt_Trabajo.TabIndex = 53;
            // 
            // btn_VerficarDomicilio
            // 
            this.btn_VerficarDomicilio.Location = new System.Drawing.Point(461, 68);
            this.btn_VerficarDomicilio.Name = "btn_VerficarDomicilio";
            this.btn_VerficarDomicilio.Size = new System.Drawing.Size(159, 42);
            this.btn_VerficarDomicilio.TabIndex = 54;
            this.btn_VerficarDomicilio.Text = "Domicilio Verificado";
            this.btn_VerficarDomicilio.UseVisualStyleBackColor = true;
            this.btn_VerficarDomicilio.Click += new System.EventHandler(this.btn_VerficarDomicilio_Click);
            // 
            // btn_VerificarTrabajo
            // 
            this.btn_VerificarTrabajo.Location = new System.Drawing.Point(461, 142);
            this.btn_VerificarTrabajo.Name = "btn_VerificarTrabajo";
            this.btn_VerificarTrabajo.Size = new System.Drawing.Size(159, 42);
            this.btn_VerificarTrabajo.TabIndex = 55;
            this.btn_VerificarTrabajo.Text = "Trabajo Verificado";
            this.btn_VerificarTrabajo.UseVisualStyleBackColor = true;
            this.btn_VerificarTrabajo.Click += new System.EventHandler(this.btn_VerificarTrabajo_Click);
            // 
            // txt_telTrabajo
            // 
            this.txt_telTrabajo.Location = new System.Drawing.Point(232, 154);
            this.txt_telTrabajo.Name = "txt_telTrabajo";
            this.txt_telTrabajo.Size = new System.Drawing.Size(119, 20);
            this.txt_telTrabajo.TabIndex = 59;
            // 
            // txt_telDomicilio
            // 
            this.txt_telDomicilio.Location = new System.Drawing.Point(232, 78);
            this.txt_telDomicilio.Name = "txt_telDomicilio";
            this.txt_telDomicilio.Size = new System.Drawing.Size(119, 20);
            this.txt_telDomicilio.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Tel. Trabajo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Tel. Domicilio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_VerficarDomicilio);
            this.groupBox1.Controls.Add(this.txt_telTrabajo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_telDomicilio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Domicilio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Trabajo);
            this.groupBox1.Controls.Add(this.btn_VerificarTrabajo);
            this.groupBox1.Location = new System.Drawing.Point(59, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 219);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificar Datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Guardar Cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(668, 57);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.ReadOnly = true;
            this.txt_dpi.Size = new System.Drawing.Size(102, 20);
            this.txt_dpi.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "DPI:";
            // 
            // frmEvaluacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.txt_dpi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgProspecto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_idProspecto);
            this.Controls.Add(this.btn_desaprobar);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.btn_Aprobar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEvaluacion2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluacion 2";
            this.Load += new System.EventHandler(this.frmEvaluacion2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProspecto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_desaprobar;
        private System.Windows.Forms.Button btn_Continuar;
        private System.Windows.Forms.Button btn_Aprobar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_idProspecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgProspecto;
        private System.Windows.Forms.TextBox txt_Domicilio;
        private System.Windows.Forms.TextBox txt_Trabajo;
        private System.Windows.Forms.Button btn_VerficarDomicilio;
        private System.Windows.Forms.Button btn_VerificarTrabajo;
        private System.Windows.Forms.TextBox txt_telTrabajo;
        private System.Windows.Forms.TextBox txt_telDomicilio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProspecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
    }
}