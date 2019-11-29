namespace Pisto_credito.Interface
{
    partial class frmListaProspectos
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_Prospectos = new System.Windows.Forms.DataGridView();
            this.btn_Evaluar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Prospectos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "PROSPECTOS A EVALUAR";
            // 
            // dtg_Prospectos
            // 
            this.dtg_Prospectos.AllowUserToOrderColumns = true;
            this.dtg_Prospectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Prospectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Prospectos.Location = new System.Drawing.Point(40, 177);
            this.dtg_Prospectos.Name = "dtg_Prospectos";
            this.dtg_Prospectos.ReadOnly = true;
            this.dtg_Prospectos.Size = new System.Drawing.Size(452, 354);
            this.dtg_Prospectos.TabIndex = 47;
            this.dtg_Prospectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Evaluar
            // 
            this.btn_Evaluar.Location = new System.Drawing.Point(192, 579);
            this.btn_Evaluar.Name = "btn_Evaluar";
            this.btn_Evaluar.Size = new System.Drawing.Size(137, 39);
            this.btn_Evaluar.TabIndex = 48;
            this.btn_Evaluar.Text = "Evaluar Prospecto";
            this.btn_Evaluar.UseVisualStyleBackColor = true;
            this.btn_Evaluar.Click += new System.EventHandler(this.btn_Evaluar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 26);
            this.button1.TabIndex = 49;
            this.button1.Text = "Menu Evaluaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = " ";
            // 
            // frmListaProspectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Evaluar);
            this.Controls.Add(this.dtg_Prospectos);
            this.Controls.Add(this.label3);
            this.Name = "frmListaProspectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Prospectos a evaluar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaProspectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Prospectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Evaluar;
        public System.Windows.Forms.DataGridView dtg_Prospectos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label1;
    }
}