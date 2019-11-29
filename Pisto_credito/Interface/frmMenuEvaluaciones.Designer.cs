namespace Pisto_credito.Interface
{
    partial class frmMenuEvaluaciones
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
            this.btn_Evaluacion1 = new System.Windows.Forms.Button();
            this.btn_Evaluacion2 = new System.Windows.Forms.Button();
            this.btn_Evaluacion3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Evaluacion1
            // 
            this.btn_Evaluacion1.Location = new System.Drawing.Point(91, 161);
            this.btn_Evaluacion1.Name = "btn_Evaluacion1";
            this.btn_Evaluacion1.Size = new System.Drawing.Size(191, 51);
            this.btn_Evaluacion1.TabIndex = 0;
            this.btn_Evaluacion1.Text = "Evaluacion 1";
            this.btn_Evaluacion1.UseVisualStyleBackColor = true;
            this.btn_Evaluacion1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Evaluacion2
            // 
            this.btn_Evaluacion2.Location = new System.Drawing.Point(324, 161);
            this.btn_Evaluacion2.Name = "btn_Evaluacion2";
            this.btn_Evaluacion2.Size = new System.Drawing.Size(191, 51);
            this.btn_Evaluacion2.TabIndex = 1;
            this.btn_Evaluacion2.Text = "Evaluacion 2";
            this.btn_Evaluacion2.UseVisualStyleBackColor = true;
            this.btn_Evaluacion2.Click += new System.EventHandler(this.btn_Evaluacion2_Click);
            // 
            // btn_Evaluacion3
            // 
            this.btn_Evaluacion3.Location = new System.Drawing.Point(550, 161);
            this.btn_Evaluacion3.Name = "btn_Evaluacion3";
            this.btn_Evaluacion3.Size = new System.Drawing.Size(191, 51);
            this.btn_Evaluacion3.TabIndex = 2;
            this.btn_Evaluacion3.Text = "Evaluacion 3";
            this.btn_Evaluacion3.UseVisualStyleBackColor = true;
            this.btn_Evaluacion3.Click += new System.EventHandler(this.btn_Evaluacion3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "EVALUACIONES";
            // 
            // frmMenuEvaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Evaluacion3);
            this.Controls.Add(this.btn_Evaluacion2);
            this.Controls.Add(this.btn_Evaluacion1);
            this.Name = "frmMenuEvaluaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluaciones";
            this.Load += new System.EventHandler(this.frmMenuEvaluaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Evaluacion1;
        private System.Windows.Forms.Button btn_Evaluacion2;
        private System.Windows.Forms.Button btn_Evaluacion3;
        private System.Windows.Forms.Label label2;
    }
}