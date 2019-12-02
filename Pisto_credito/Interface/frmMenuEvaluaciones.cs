using Pisto_credito.src.BD;
using System;
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
    public partial class frmMenuEvaluaciones : Form
    {
        clConexion cl = new clConexion();
        
        public frmMenuEvaluaciones()
        {
            InitializeComponent();
        }
        private void frmMenuEvaluaciones_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmListaProspectos frmList = new frmListaProspectos();
            frmList.Show();
            this.Hide();
            frmList.label1.Text = "Evaluacion 1";
            frmList.dtg_Prospectos.DataSource = cl.Select("sp_evaluacion1",12);
          
           
        }

        private void btn_Evaluacion2_Click(object sender, EventArgs e)
        {
            frmListaProspectos frmList = new frmListaProspectos();
            frmList.Show();
            this.Hide();
            frmList.label1.Text = "Evaluacion 2";
            frmList.dtg_Prospectos.DataSource = cl.Select("sp_evaluacion2", 16);
          

        }

        private void btn_Evaluacion3_Click(object sender, EventArgs e)
        {
            frmListaProspectos frmList = new frmListaProspectos();
            frmList.Show();
            this.Hide();
            frmList.label1.Text = "Evaluacion 3";
            frmList.dtg_Prospectos.DataSource = cl.Select("sp_evaluacion3",12);
           

        }
    }
}
