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
using Pisto_credito.src.BD;

namespace Pisto_credito
{
    public partial class frmEvaluarProspectos : Form
    {
        clConexion cl = new clConexion();
        public frmEvaluarProspectos()
        {
            InitializeComponent();
        }

        public void consultaProspecto()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(txt_dpi.Text);
            datos.Add("@dpi");

            cl.SelectWithParameters("sp_prospecto",8,parametros,datos);
        }
        private void frmEvaluarProspectos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultaProspecto();
            dtg_Evaluacion.DataSource = cl.Select("sp_prospecto",1);
        }
    }
}
