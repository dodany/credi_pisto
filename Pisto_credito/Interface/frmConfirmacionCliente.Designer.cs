namespace Pisto_credito.Interface
{
    partial class frmConfirmacionCliente
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
            this.label13 = new System.Windows.Forms.Label();
            this.txt_idProspecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidadMin = new System.Windows.Forms.Label();
            this.lblCantidadMax = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Id Cliente :";
            // 
            // txt_idProspecto
            // 
            this.txt_idProspecto.Location = new System.Drawing.Point(104, 21);
            this.txt_idProspecto.Name = "txt_idProspecto";
            this.txt_idProspecto.ReadOnly = true;
            this.txt_idProspecto.Size = new System.Drawing.Size(102, 20);
            this.txt_idProspecto.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "CONFIRMACION";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Cantidad del Credito";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 55;
            this.button1.Text = "Aceptar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(69, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 94);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 57;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCantidadMax);
            this.groupBox2.Controls.Add(this.lblCantidadMin);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Location = new System.Drawing.Point(459, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 93);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCantidadMin
            // 
            this.lblCantidadMin.AutoSize = true;
            this.lblCantidadMin.Location = new System.Drawing.Point(30, 44);
            this.lblCantidadMin.Name = "lblCantidadMin";
            this.lblCantidadMin.Size = new System.Drawing.Size(72, 13);
            this.lblCantidadMin.TabIndex = 1;
            this.lblCantidadMin.Text = "Cantidad Min.";
            this.lblCantidadMin.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCantidadMax
            // 
            this.lblCantidadMax.AutoSize = true;
            this.lblCantidadMax.Location = new System.Drawing.Point(30, 67);
            this.lblCantidadMax.Name = "lblCantidadMax";
            this.lblCantidadMax.Size = new System.Drawing.Size(75, 13);
            this.lblCantidadMax.TabIndex = 2;
            this.lblCantidadMax.Text = "Cantidad Max.";
            this.lblCantidadMax.Click += new System.EventHandler(this.label5_Click);
            // 
            // frmConfirmacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_idProspecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmConfirmacionCliente";
            this.Text = "Confirmacion Cliente";
            this.Load += new System.EventHandler(this.frmConfirmacionCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txt_idProspecto;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblCantidadMax;
        public System.Windows.Forms.Label lblCantidadMin;
        public System.Windows.Forms.Label lblNombre;
    }
}