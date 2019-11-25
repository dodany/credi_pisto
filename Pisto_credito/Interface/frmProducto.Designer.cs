namespace Pisto_credito
{
    partial class frmProducto
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
            this.dtg_Producto = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txt_tasaInteres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantidadMin = new System.Windows.Forms.TextBox();
            this.txt_cantidadMax = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Producto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Producto
            // 
            this.dtg_Producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.cantidadMax,
            this.cantidadMin,
            this.tasaInteres});
            this.dtg_Producto.Location = new System.Drawing.Point(108, 262);
            this.dtg_Producto.Name = "dtg_Producto";
            this.dtg_Producto.ReadOnly = true;
            this.dtg_Producto.Size = new System.Drawing.Size(531, 156);
            this.dtg_Producto.TabIndex = 35;
            this.dtg_Producto.SelectionChanged += new System.EventHandler(this.dtg_Producto_SelectionChanged);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 70;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre:";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidadMax
            // 
            this.cantidadMax.DataPropertyName = "cantidadMax";
            this.cantidadMax.HeaderText = "Cantidad Max.";
            this.cantidadMax.Name = "cantidadMax";
            this.cantidadMax.ReadOnly = true;
            // 
            // cantidadMin
            // 
            this.cantidadMin.DataPropertyName = "cantidadMin";
            this.cantidadMin.HeaderText = "Cantidad Min";
            this.cantidadMin.Name = "cantidadMin";
            this.cantidadMin.ReadOnly = true;
            // 
            // tasaInteres
            // 
            this.tasaInteres.DataPropertyName = "tasaInteres";
            this.tasaInteres.HeaderText = "Tasa de Interes";
            this.tasaInteres.Name = "tasaInteres";
            this.tasaInteres.ReadOnly = true;
            this.tasaInteres.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "PRODUCTOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txt_tasaInteres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cantidadMin);
            this.groupBox1.Controls.Add(this.txt_cantidadMax);
            this.groupBox1.Location = new System.Drawing.Point(66, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 146);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(496, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 56);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txt_tasaInteres
            // 
            this.txt_tasaInteres.Location = new System.Drawing.Point(368, 71);
            this.txt_tasaInteres.Name = "txt_tasaInteres";
            this.txt_tasaInteres.Size = new System.Drawing.Size(81, 20);
            this.txt_tasaInteres.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad Min. :";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(137, 27);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(223, 20);
            this.txt_nombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad Max. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tasa de Interes:";
            // 
            // txt_cantidadMin
            // 
            this.txt_cantidadMin.Location = new System.Drawing.Point(140, 112);
            this.txt_cantidadMin.Name = "txt_cantidadMin";
            this.txt_cantidadMin.Size = new System.Drawing.Size(116, 20);
            this.txt_cantidadMin.TabIndex = 9;
            // 
            // txt_cantidadMax
            // 
            this.txt_cantidadMax.Location = new System.Drawing.Point(140, 67);
            this.txt_cantidadMax.Name = "txt_cantidadMax";
            this.txt_cantidadMax.Size = new System.Drawing.Size(120, 20);
            this.txt_cantidadMax.TabIndex = 10;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(461, 444);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(143, 43);
            this.btnReporte.TabIndex = 43;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(653, 507);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 28);
            this.button5.TabIndex = 42;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(298, 444);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(143, 43);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(137, 444);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 43);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 553);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtg_Producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Producto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaInteres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tasaInteres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantidadMin;
        private System.Windows.Forms.TextBox txt_cantidadMax;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}