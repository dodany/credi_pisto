namespace Pisto_credito.Interface
{
    partial class frmEvaluaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgConsulta3 = new System.Windows.Forms.DataGridView();
            this.dtgConsulta2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgConsulta1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idEvaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEvaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProspecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgConsulta3);
            this.groupBox1.Controls.Add(this.dtgConsulta2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtgConsulta1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_dpi);
            this.groupBox1.Location = new System.Drawing.Point(46, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Evaluaciones";
            // 
            // dtgConsulta3
            // 
            this.dtgConsulta3.AllowUserToAddRows = false;
            this.dtgConsulta3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsulta3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dtgConsulta3.Location = new System.Drawing.Point(73, 230);
            this.dtgConsulta3.Name = "dtgConsulta3";
            this.dtgConsulta3.ReadOnly = true;
            this.dtgConsulta3.Size = new System.Drawing.Size(629, 73);
            this.dtgConsulta3.TabIndex = 5;
            // 
            // dtgConsulta2
            // 
            this.dtgConsulta2.AllowUserToAddRows = false;
            this.dtgConsulta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsulta2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgConsulta2.Location = new System.Drawing.Point(73, 151);
            this.dtgConsulta2.Name = "dtgConsulta2";
            this.dtgConsulta2.ReadOnly = true;
            this.dtgConsulta2.Size = new System.Drawing.Size(629, 73);
            this.dtgConsulta2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar Evaluacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgConsulta1
            // 
            this.dtgConsulta1.AllowUserToAddRows = false;
            this.dtgConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsulta1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvaluacion,
            this.fechaEvaluacion,
            this.idProspecto,
            this.Verificacion});
            this.dtgConsulta1.Location = new System.Drawing.Point(73, 72);
            this.dtgConsulta1.Name = "dtgConsulta1";
            this.dtgConsulta1.ReadOnly = true;
            this.dtgConsulta1.Size = new System.Drawing.Size(629, 73);
            this.dtgConsulta1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DPI Prospecto:";
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(324, 30);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(100, 20);
            this.txt_dpi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "EVALUACIONES";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idEvaluacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID Evaluacion ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha de Evaluacion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 170;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idProspecto";
            this.dataGridViewTextBoxColumn7.HeaderText = "idProspecto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 140;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "verificacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Verificacion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.Width = 140;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEvaluacion";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Evaluacion ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fechaEvaluacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha de Evaluacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idProspecto";
            this.dataGridViewTextBoxColumn3.HeaderText = "idProspecto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "verificacion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Verificacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // idEvaluacion
            // 
            this.idEvaluacion.DataPropertyName = "idEvaluacion";
            this.idEvaluacion.HeaderText = "ID Evaluacion ";
            this.idEvaluacion.Name = "idEvaluacion";
            this.idEvaluacion.ReadOnly = true;
            this.idEvaluacion.Width = 140;
            // 
            // fechaEvaluacion
            // 
            this.fechaEvaluacion.DataPropertyName = "fechaEvaluacion";
            this.fechaEvaluacion.HeaderText = "Fecha de Evaluacion";
            this.fechaEvaluacion.Name = "fechaEvaluacion";
            this.fechaEvaluacion.ReadOnly = true;
            this.fechaEvaluacion.Width = 170;
            // 
            // idProspecto
            // 
            this.idProspecto.DataPropertyName = "idProspecto";
            this.idProspecto.HeaderText = "idProspecto";
            this.idProspecto.Name = "idProspecto";
            this.idProspecto.ReadOnly = true;
            this.idProspecto.Width = 140;
            // 
            // Verificacion
            // 
            this.Verificacion.DataPropertyName = "verificacion";
            this.Verificacion.HeaderText = "Verificacion";
            this.Verificacion.Name = "Verificacion";
            this.Verificacion.ReadOnly = true;
            this.Verificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Verificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Verificacion.Width = 140;
            // 
            // frmEvaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEvaluaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluaciones";
            this.Load += new System.EventHandler(this.frmEvaluaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgConsulta1;
        private System.Windows.Forms.DataGridView dtgConsulta3;
        private System.Windows.Forms.DataGridView dtgConsulta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProspecto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Verificacion;
    }
}