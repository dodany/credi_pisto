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
        public int idProducto;
        public int cantidadMax;
        public int cantidadMin;
        clConexion cl = new clConexion();
        public frmConfirmacionCliente()
        {
            InitializeComponent();
        }

        private void frmConfirmacionCliente_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Ingrese la cantidad que el prospecto solicita", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            enviarInfoProducto();
            button2.Enabled = false;

        }

        public void enviarInfoProducto()
        {
           

            //Enviar informacion del producto a la confirmacion del credito+
            //Cambiar modificadores de acceso a las etiquetas


            frmConfirmacionCliente frmConfirmacion = new frmConfirmacionCliente();


            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();
            DataTable dt = new DataTable();

            datos.Add("@idProducto");

            parametros.Add(idProducto);

            dt = cl.SelectWithParameters("sp_cliente", 8, parametros, datos);

            if (dt.Rows.Count > 0)
            {
                DataTableReader reader = dt.CreateDataReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    String nombres = reader["nombre"].ToString();
                   cantidadMax = Convert.ToInt32(reader["cantidadMax"]);
                   cantidadMin = Convert.ToInt32(reader["cantidadMin"]);


                  lblNombre.Text = "Nombre: " + nombres;
                  lblCantidadMin.Text = "Cantidad Max: " + cantidadMin;
                  lblCantidadMax.Text = "Cantidad Min: " + cantidadMax;
                }
            }
            //Crear instacia del form Confirmacion de cliente
            //Hacer consulta de la informacion 
            //Declarar un reader
            //Enviar esos datos a las etiquetas



        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    (Convert.ToInt32(textBox1.Text) <= cantidadMax) && (Convert.ToInt32(textBox1.Text) >= cantidadMin))
                {
                    ingresoCantidad();
                    button2.Enabled = true;
                }
                else {
                    MessageBox.Show("La cantidad ingresada no está dentro de el rango del producto.","Cantidad no válida",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

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
                DialogResult result1 = MessageBox.Show("¿Esta seguro que la cantidad es correcta?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {
                    frmCliente frmClient = new frmCliente();
                    frmClient.Show();
                    this.Hide();         

                    MessageBox.Show("El dato se ha ingresado correctamente ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
            
}
