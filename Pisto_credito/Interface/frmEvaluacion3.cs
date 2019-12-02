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
    public partial class frmEvaluacion3 : Form
    {
        clConexion cl = new clConexion();
        public String DPI;
        public int idProspect;
        public frmEvaluacion3()
        {
            InitializeComponent();
        }

        private void frmEvaluacion3_Load(object sender, EventArgs e)
        {
            llenarDTG_Prospecto();
            cargarDatos();


        }

        public void llenarDTG_Prospecto()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(idProspect);

            dtgProspecto.DataSource = cl.SelectWithParameters("sp_evaluacion3", 9, parametro, dato);

            dataGridView1.DataSource = cl.SelectWithParameters("sp_evaluacion3", 11, parametro, dato);


        }
        public int ObtenerIDProducto()
        {

            int idProducto;
            DataGridViewRow row = dtgProspecto.CurrentRow;
            idProducto = Convert.ToInt32(row.Cells["idProducto"].Value);//Enviar idProducto del grid hacia la confiramcion de lac cantidad
            return idProducto;
        }
        private void btn_Aprobar_Click(object sender, EventArgs e)
        {
           



            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro que la informacion es veridica y aprobar esta evaluación? El prospecto sera ingresado como nuevo cliente.",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {
                    //try {  try { } } catch { }

                   
                    aprobarEvaluacion();
                    //frmCliente frmClientes = new frmCliente();
                    //frmClientes.Show();
                    agregarCliente();
                    crearPlanPago();
                    //frmClientes.dtgCliente.DataSource = cl.Select("sp_Cliente", 1);


                    // llenarDTG_Prospecto();
                    MessageBox.Show("La evaluación ha sido aprobada correctamente. El proceso de evaluaciones ha sido completado con éxito, el credito está aprobado. ", "Evaluaciones Completadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmConfirmacionCliente frmConfirmacion = new frmConfirmacionCliente();
                    frmConfirmacion.txt_idProspecto.Text = txt_idProspecto.Text;
                  

                    frmConfirmacion.idProducto = ObtenerIDProducto();

                    frmConfirmacion.Show();
                    //MessageBox.Show("Ingrese la cantidad que el prospecto solicita", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /// <summary>
        /// 
        /// </summary>
        /// 

        public void crearPlanPago()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idCliente");
            dato.Add("@idProducto");
            parametro.Add(txt_idProspecto.Text);
            parametro.Add(ObtenerIDProducto());
            


            cl.Insert("sp_planPagos", 0, parametro, dato, false);
        }
        public void aprobarEvaluacion()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(txt_idProspecto.Text);


            cl.SelectWithParameters("sp_evaluacion3", 7, parametro, dato);
        }

        public void desaprobarEvaluacion()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(txt_idProspecto.Text);

            cl.SelectWithParameters("sp_evaluacion3", 8, parametro, dato);
        }

        private void btn_desaprobar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Desea desaprobar la evaluación?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {
                    desaprobarEvaluacion();
                    //llenarDTG_Prospecto();
                    MessageBox.Show("La evaluación ha sido cancelada, la solicitud ha sido rechazada. ", "Evaluacion Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txt_idProspecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarDatos()
        {
           
            DataGridViewRow row = dtgProspecto.CurrentRow;

            txt_Edad.Text = Convert.ToString(row.Cells["edad"].Value);
            txt_idProspecto.Text = Convert.ToString(row.Cells["idProspecto"].Value);
           


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }
        private void guardarDatos()
        {
          

            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            datos.Add("@edad");
            datos.Add("@hijos");
            datos.Add("@sueldo");

            parametros.Add(txt_Edad.Text);
            parametros.Add(txt_Hijos.Text);
            parametros.Add(txt_Sueldo.Text);

            try
            {
                if (Convert.ToInt32(txt_Hijos.Text) < 0 || Convert.ToInt32(txt_Sueldo.Text) < 0)
                {
                    MessageBox.Show("No son permitidos los números negativos. ¡Por favor llenarlos correctamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    try { cl.SelectWithParameters("sp_evaluacion3", 10, parametros, datos);
                        //Boton de aprobar evaluacion es aprobado al agregar correctamente los datos solicitados
                        btn_Aprobar.Enabled = true;
                    }
                    catch (Exception) { MessageBox.Show("Los datos ingresados no son válidos, por favor ingresarlos correctamente.", "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
            }
            catch(Exception) { MessageBox.Show("Estos campos son obligatorios. ¡Por favor llenarlos correctamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

           
            llenarDTG_Prospecto();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void agregarCliente()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();
            DataGridViewRow row = dtgProspecto.CurrentRow;


            // datos.Add("@idProspecto"); el Codigo del prospecto tiene que ser igual al de prospecto
            datos.Add("@idProspecto");
            datos.Add("@nombre");
            datos.Add("@dpi");
            datos.Add("@nit");
            datos.Add("@edad");
            datos.Add("@correo1");
            datos.Add("@correo2");
            datos.Add("@tel1");
            datos.Add("@tel2");
            datos.Add("@domicilio");
            datos.Add("@telDomicilio");
            datos.Add("@trabajo");
            datos.Add("@telTrabajo");
            datos.Add("@idProducto");
            datos.Add("@estado");

               int idCliente = Convert.ToInt32(row.Cells["idProspecto"].Value);
               String nombre = Convert.ToString(row.Cells["nombre"].Value);
               String nit = Convert.ToString(row.Cells["nit"].Value);
               String dpi = Convert.ToString(row.Cells["eldpi"].Value);
               int edad = Convert.ToInt32(row.Cells["edad"].Value);
               String correo1 = Convert.ToString(row.Cells["correo1"].Value);
               String correo2 = Convert.ToString(row.Cells["correo2"].Value);
               int tel1 = Convert.ToInt32(row.Cells["tel1"].Value);
               int tel2 = Convert.ToInt32(row.Cells["tel2"].Value);
               int telDomicilio  = Convert.ToInt32(row.Cells["telDomicilio"].Value);
               int telTrabajo = Convert.ToInt32(row.Cells["telTrabajo"].Value);
               int idProducto = Convert.ToInt32(row.Cells["idProducto"].Value);
               String domicilio = Convert.ToString(row.Cells["domicilio"].Value);
               String trabajo = Convert.ToString(row.Cells["trabajo"].Value);
               String estado = Convert.ToString(row.Cells["estado"].Value);
            //parametros.Add(cl.Select("sp_prospecto",7));

            parametros.Add(idCliente);
            parametros.Add(nombre);
            parametros.Add(dpi);
            parametros.Add(nit);
            parametros.Add(edad);
            parametros.Add(correo1);
            parametros.Add(correo2);
            parametros.Add(tel1);
            parametros.Add(tel2);
            parametros.Add(domicilio);
            parametros.Add(telDomicilio);
            parametros.Add(trabajo);
            parametros.Add(telTrabajo);
            parametros.Add(idProducto);     
            parametros.Add(estado);

            try
            {
                cl.Insert("sp_cliente",4, parametros, datos, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Rellene correctamente los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgProspecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Sueldo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Sueldo_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
