using System;
using Pisto_credito.src.BD;
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
    public partial class frmProspecto : Form
    {
        clConexion cl = new clConexion();
        public int id;
        public frmProspecto()
        {
            InitializeComponent();
        }


        
        private void agregarProspecto()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

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
                cl.Insert("sp_prospecto", 0, parametros, datos, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Rellene correctamente los campos.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProspecto_Load(object sender, EventArgs e)
        {
            llenarCombo();
            dtgProspecto.DataSource = cl.Select("sp_prospecto", 1);
            cmb_producto.Text = "Elegir una opcion";
        }

      
        private void llenarCombo()
        {
            cmb_producto.DataSource = cl.Select("sp_prospecto", 6);
            cmb_producto.ValueMember = "idProducto";
            cmb_producto.DisplayMember = "nombre";
        }
        private void txt_producto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_tel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarProspecto();
            dtgProspecto.DataSource = cl.Select("sp_prospecto", 1);
        }


      


     


        public void eliminarProspecto()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(ObtenerId());
            datos.Add("@idProspecto");
            cl.SelectWithParameters("sp_prospecto", 3, parametros, datos);
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

        private void dtgProspecto_SelectionChanged(object sender, EventArgs e)
        {
            mostrarDatosParaEditar();
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


        private void mostrarDatosParaEditar()
        {


            DataGridViewRow row = dtgProspecto.CurrentRow;

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que desea eliminar este registro?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {

                    eliminarProspecto();
                    dtgProspecto.DataSource = cl.Select("sp_prospecto", 1);
                    MessageBox.Show("El registro se ha eliminado correctamente ", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("¡Error! La operacion no ha se completado con exito!",
                 "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
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

        private void dtgProspecto_SelectionChanged_1(object sender, EventArgs e)
        {
            mostrarDatosParaEditar();
        }
    }
}
