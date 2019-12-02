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

namespace Pisto_credito
{
    public partial class frmPlanPagos : Form
    {
        clConexion cl = new clConexion();
        public frmPlanPagos()
        {
            InitializeComponent();
        }

        private void frmPlanPagos_Load(object sender, EventArgs e)
        {

        }
        private void calculoCuota()
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                consultaCliente();

                             
            }
            catch
            {

                MessageBox.Show("El prospecto no ha sido encontrado en la base de datos. Ingrese nuevamente el dato requerido", "Prospecto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void consultaCliente()
        {
            int idCliente;
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(txt_DPI.Text);
            datos.Add("@dpi");


            DataTable dt = new DataTable();
            dt = cl.SelectWithParameters("sp_planPagos",4,parametros,datos);

            if (dt.Rows.Count > 0)
            {
                DataTableReader reader = dt.CreateDataReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    idCliente = Convert.ToInt32(reader["idCliente"]);

                    Console.WriteLine("Usuario ->" + idCliente);

                    parametros.Add(idCliente);
                    datos.Add("@idCliente");
                    dtgPagos.DataSource = cl.SelectWithParameters("sp_planPagos",5, parametros, datos);
                }
            }
          
        }
    }
}
