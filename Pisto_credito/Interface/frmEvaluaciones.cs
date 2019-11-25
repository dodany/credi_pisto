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
    public partial class frmEvaluaciones : Form
    {

        clConexion cl = new clConexion();
        public frmEvaluaciones()
        {
            InitializeComponent();
        }

        private void frmEvaluaciones_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                consultaEvaluaciones();
            }
            catch (Exception)
            {
                MessageBox.Show("Evaluacion no encontrada, ingrese correctamente el dpi del prospecto. ", "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int consultaID()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(txt_dpi.Text);
            datos.Add("@dpi");

            DataTable dt = new DataTable();
            dt = cl.SelectWithParameters("sp_prospecto", 13, parametros, datos);

            DataTableReader reader = dt.CreateDataReader();
            reader.Read();
            int idProspecto = Convert.ToInt32(reader["idProspecto"]);
            return idProspecto;
        }


        public void consultaEvaluaciones()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(consultaID());
            datos.Add("@idProspecto");

            dtgConsulta1.DataSource = cl.SelectWithParameters("sp_prospecto", 11, parametros, datos);
            dtgConsulta2.DataSource = cl.SelectWithParameters("sp_prospecto", 14, parametros, datos);
            dtgConsulta3.DataSource = cl.SelectWithParameters("sp_prospecto", 15, parametros, datos);
        }


    }
}