namespace Pisto_credito.Interface
{
    partial class frmGestionPermisos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "PERMISOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRol,
            this.idFuncion,
            this.permiso});
            this.dataGridView1.Location = new System.Drawing.Point(99, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 279);
            this.dataGridView1.TabIndex = 46;
            // 
            // idRol
            // 
            this.idRol.DataPropertyName = "idRol";
            this.idRol.HeaderText = "Rol";
            this.idRol.Name = "idRol";
            // 
            // idFuncion
            // 
            this.idFuncion.DataPropertyName = "idFuncion";
            this.idFuncion.HeaderText = "Funcion";
            this.idFuncion.Name = "idFuncion";
            // 
            // permiso
            // 
            this.permiso.DataPropertyName = "permiso";
            this.permiso.HeaderText = "Permiso";
            this.permiso.Name = "permiso";
            this.permiso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.permiso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmGestionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionPermisos";
            this.Text = "Gestionar Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permiso;
    }
}