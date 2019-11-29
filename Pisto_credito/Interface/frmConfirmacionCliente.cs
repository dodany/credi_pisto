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
    public partial class frmConfirmacionCliente : Form
    {

        clConexion cl = new clConexion();
        public frmConfirmacionCliente()
        {
            InitializeComponent();
        }

        private void frmConfirmacionCliente_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Ingrese la cantidad que el prospecto solicita", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ingresoCantidad();
            }
            catch (Exception)
            {
                MessageBox.Show("El dato ingresado no es válido, ingrese el dato nuevamente. ¡Este campo es de mucha importancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void ingresoCantidad()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();


            parametro.Add(txt_idProspecto.Text);
            parametro.Add(textBox1.Text);

            dato.Add("@idProspecto");
            dato.Add("@cantidad");

            cl.SelectWithParameters("sp_cliente",5,parametro,dato);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que desea eliminar este registro?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {
                    frmCliente frmClient = new frmCliente();
                    frmClient.Show();
                    this.Hide();         

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
    }
            
}
