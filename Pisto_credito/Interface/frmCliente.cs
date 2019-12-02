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
    public partial class frmCliente : Form
    {
        clConexion cl = new clConexion();
        private int id;

        public frmCliente()
        {
            InitializeComponent();
        }

      
        private void dtgProspecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            dtgCliente.DataSource = cl.Select("sp_Cliente",1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgCliente.DataSource = cl.Select("sp_Cliente", 1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que desea eliminar este registro?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result1 == DialogResult.Yes)
                {
                    eliminarCliente();
                    dtgCliente.DataSource = cl.Select("sp_Cliente", 1);
                    MessageBox.Show("El registro se ha eliminado correctamente ", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("¡Error! La operacion no se ha completado con exito!",
                 "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void eliminarCliente()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();


            parametros.Add(ObtenerId());
            datos.Add("@idCliente");
            cl.SelectWithParameters("sp_cliente",3, parametros, datos);     
        }

        public int ObtenerId()
        {

            DataGridViewRow row = dtgCliente.CurrentRow;
            if (row != null)
            {
                id = Convert.ToInt32(row.Cells["idCliente"].Value);
            }
            return id;
        }
    }
}
