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

namespace Pisto_credito.Interface
{
    public partial class frmEvaluacion1 : Form
    {
        clConexion cl = new clConexion();
        public int id;
        public frmEvaluacion1()
        {
            InitializeComponent();
        }

        private void frmEvaluacion1_Load(object sender, EventArgs e)
        {
            llenarDTG_Prospecto();
            llenarCombo();
            //dtgProspecto.DataSource = cl.SelectWithParameters("sp_evaluacion1",9,parametro,dato);
            //dtgProspecto.DataSource = llenarDTG_Prospecto();
        }

        public void llenarDTG_Prospecto()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@dpi");
            parametro.Add(Program.DPI);

            dtgProspecto.DataSource = cl.SelectWithParameters("sp_Evaluacion1",9,parametro,dato);
            //frmEvaluarProspectos frmEvaluarProspecto = new frmEvaluarProspectos();
            //frmEvaluarProspecto.consultaProspecto();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro que la informacion es veridica y aprobar esta evaluación?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {

                    aprobarEvaluacion();
                    MessageBox.Show("La evaluación ha sido aprobada correctamente. ", "Evaluacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void aprobarEvaluacion()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(txt_idProspecto.Text);
         

            cl.SelectWithParameters("sp_evaluacion1", 5, parametro, dato);
        }

        public void desaprobarEvaluacion()
        {

            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(txt_idProspecto.Text);

            cl.SelectWithParameters("sp_evaluacion1", 8, parametro, dato);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Desea desaprobar la evaluación?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {

                    desaprobarEvaluacion();
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
        private void mostrarDatosParaEditar()
        {
            DataGridViewRow row = dtgProspecto.CurrentRow;

            txt_idProspecto.Text = Convert.ToString(row.Cells["idProspecto"].Value);
            txt_nombre.Text = Convert.ToString(row.Cells["nombre"].Value);
            txt_nit.Text = Convert.ToString(row.Cells["nit"].Value);
            txt_dpi.Text = Convert.ToString(row.Cells["dpi"].Value);
            txt_edad.Text = Convert.ToString(row.Cells["edad"].Value);
            txt_correo1.Text = Convert.ToString(row.Cells["correo1"].Value);
            txt_correo2.Text = Convert.ToString(row.Cells["correo2"].Value);
            txt_tel1.Text = Convert.ToString(row.Cells["tel1"].Value);
            txt_tel2.Text = Convert.ToString(row.Cells["tel2"].Value);
            txt_telDomicilio.Text = Convert.ToString(row.Cells["telDomicilio"].Value);
            txt_telTrabajo.Text = Convert.ToString(row.Cells["telTrabajo"].Value);
            cmb_producto.Text = Convert.ToString(row.Cells["idProducto"].Value);

        }

        private void llenarCombo()
        {
            cmb_producto.DataSource = cl.Select("sp_prospecto", 6);
            cmb_producto.ValueMember = "idProducto";
            cmb_producto.DisplayMember = "nombre";
        }
        private void dtgProspecto_SelectionChanged(object sender, EventArgs e)
        {
            mostrarDatosParaEditar();
        }

        private void txt_idProspecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgProspecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                editarProspecto();
            }
            catch
            {
                MessageBox.Show("Seleccione una fila para poder editarla",
                " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            dtgProspecto.DataSource = cl.Select("sp_prospecto", 1);
        }
        public void editarProspecto()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            datos.Add("@idProspecto");
            datos.Add("@nombre");
            datos.Add("@dpi");
            datos.Add("@nit");
            datos.Add("@edad");
            datos.Add("@correo1");
            datos.Add("@correo2");
            datos.Add("@tel1");
            datos.Add("@tel2");
            datos.Add("@telDomicilio");
            datos.Add("@telTrabajo");
            datos.Add("@idProducto");

            parametros.Add(ObtenerId());
            parametros.Add(txt_nombre.Text);
            parametros.Add(txt_dpi.Text);
            parametros.Add(txt_nit.Text);
            parametros.Add(txt_edad.Text);
            parametros.Add(txt_correo1.Text);
            parametros.Add(txt_correo2.Text);
            parametros.Add(txt_tel1.Text);
            parametros.Add(txt_tel2.Text);
            parametros.Add(txt_telDomicilio.Text);
            parametros.Add(txt_telTrabajo.Text);
            parametros.Add(cmb_producto.SelectedValue);
            try
            {
                cl.SelectWithParameters("sp_prospecto", 2, parametros, datos);
                // MessageBox.Show("El registro se ha editado correctamente ", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Seleccione una fila para poder editarla",
                  " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        public int ObtenerId()
            {
                DataGridViewRow row = dtgProspecto.CurrentRow;
                if (row != null)
                {
                    id = Convert.ToInt32(row.Cells["idProspecto"].Value);
                }
                return id;
            }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            frmEvaluacion2 frmEvaluar = new frmEvaluacion2();
            frmEvaluar.Show();
            this.Hide();
        }
    }
}
