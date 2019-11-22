namespace Pisto_credito
{
    partial class frmEvaluarProspectos
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
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_Evaluacion = new System.Windows.Forms.DataGridView();
            this.idProspecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt_idProspecto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Evaluacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(230, 135);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(174, 20);
            this.txt_dpi.TabIndex = 0;
            this.txt_dpi.TextChanged += new System.EventHandler(this.txt_dpi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "EVALUAR PROSPECTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "DPI Prospecto:";
            // 
            // dtg_Evaluacion
            // 
            this.dtg_Evaluacion.AllowUserToAddRows = false;
            this.dtg_Evaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Evaluacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProspecto,
            this.nombre,
            this.dpi,
            this.estado});
            this.dtg_Evaluacion.Location = new System.Drawing.Point(63, 196);
            this.dtg_Evaluacion.Name = "dtg_Evaluacion";
            this.dtg_Evaluacion.ReadOnly = true;
            this.dtg_Evaluacion.Size = new System.Drawing.Size(491, 60);
            this.dtg_Evaluacion.TabIndex = 38;
            this.dtg_Evaluacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Evaluacion_CellContentClick);
            // 
            // idProspecto
            // 
            this.idProspecto.DataPropertyName = "idProducto";
            this.idProspecto.HeaderText = "idProspecto";
            this.idProspecto.Name = "idProspecto";
            this.idProspecto.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // dpi
            // 
            this.dpi.DataPropertyName = "dpi";
            this.dpi.HeaderText = "DPI";
            this.dpi.Name = "dpi";
            this.dpi.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(229, 330);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(165, 42);
            this.btnEvaluar.TabIndex = 39;
            this.btnEvaluar.Text = "Evaluar Prospecto";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(424, 127);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 34);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_idProspecto
            // 
            this.txt_idProspecto.Enabled = false;
            this.txt_idProspecto.Location = new System.Drawing.Point(482, 23);
            this.txt_idProspecto.Name = "txt_idProspecto";
            this.txt_idProspecto.Size = new System.Drawing.Size(102, 20);
            this.txt_idProspecto.TabIndex = 47;
            this.txt_idProspecto.Visible = false;
            this.txt_idProspecto.TextChanged += new System.EventHandler(this.txt_idProspecto_TextChanged);
            // 
            // frmEvaluarProspectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 424);
            this.Controls.Add(this.txt_idProspecto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.dtg_Evaluacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dpi);
            this.Name = "frmEvaluarProspectos";
            this.Text = "Evaluar Prospectos";
            this.Load += new System.EventHandler(this.frmEvaluarProspectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Evaluacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProspecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        public System.Windows.Forms.DataGridView dtg_Evaluacion;
        public System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.TextBox txt_idProspecto;
    }
}