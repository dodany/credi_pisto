using Pisto_credito.src.BD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisto_credito.Interface
{
    public partial class frmListaProspectos : Form
    {
        clConexion cl = new clConexion();
        public frmListaProspectos()
        {
            InitializeComponent();
        }

        private void btn_Evaluar_Click(object sender, EventArgs e)
        {
          

            try
            {
                
               frmEvaluarProspectos frmEvaluar = new frmEvaluarProspectos();
                frmEvaluar.Show();
                frmEvaluar.txt_dpi.Text = (dtg_Prospectos.Rows[dtg_Prospectos.CurrentRow.Index].Cells[2].Value.ToString());
               
            
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el prospecto a evaluar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
       
       

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaProspectos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Evaluacion 1")
            {
                dtg_Prospectos.DataSource = cl.Select("sp_evaluacion1", 12);
            }
            else if (label1.Text == "Evaluacion 2")
            {
                dtg_Prospectos.DataSource = cl.Select("sp_evaluacion2", 16);
            }
            else if (label1.Text == "Evaluacion 3")
            {
                dtg_Prospectos.DataSource = cl.Select("sp_evaluacion3", 12);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMenuEvaluaciones frmEvaluacion = new frmMenuEvaluaciones();
            frmEvaluacion.Show();
            this.Hide();
        }
    }
}


