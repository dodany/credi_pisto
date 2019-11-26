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
    public partial class frmProducto : Form
    {

        clConexion cl = new clConexion();
        public int id;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void agregarProducto()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            datos.Add("@nombre");
            datos.Add("@cantidadMax");
            datos.Add("@cantidadMin");
            datos.Add("@tasaInteres");
            datos.Add("@plazo");

            parametros.Add(txt_nombre.Text);
            parametros.Add(txt_cantidadMax.Text);
            parametros.Add(txt_cantidadMin.Text);
            parametros.Add(txt_tasaInteres.Text);
            parametros.Add(txt_plazo.Text);

            cl.Insert("sp_producto",0,parametros,datos,false);
          
        }

        private void editarProducto()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            datos.Add("@idProducto");
            datos.Add("@nombre");
            datos.Add("@cantidadMax");
            datos.Add("@cantidadMin");
            datos.Add("@tasaInteres");
            datos.Add("@plazo");

            parametros.Add(ObtenerId());
            parametros.Add(txt_nombre.Text);
            parametros.Add(txt_cantidadMax.Text);
            parametros.Add(txt_cantidadMin.Text);
            parametros.Add(txt_tasaInteres.Text);
            parametros.Add(txt_plazo.Text);

            cl.Insert("sp_producto", 2, parametros, datos, false);

        }
        public int ObtenerId()
        {

            DataGridViewRow row = dtg_Producto.CurrentRow; 
            if (row != null)
            {
                id = Convert.ToInt32(row.Cells["idProducto"].Value);
            }
            return id;
        }

        public void eliminarProducto()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();


            parametros.Add(ObtenerId());

            datos.Add("@idProducto");

            cl.SelectWithParameters("sp_producto", 3, parametros, datos);
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            
            dtg_Producto.DataSource = cl.Select("sp_producto", 1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que desea eliminar este registro?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {

                    eliminarProducto();
                    dtg_Producto.DataSource = cl.Select("sp_producto", 1);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
              editarProducto();
            }
            catch
            {
                MessageBox.Show("Seleccione una fila para poder editarla",
                " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dtg_Producto.DataSource = cl.Select("sp_producto", 1);
        }

        private void mostrarDatosParaEditar()
        {

            DataGridViewRow row = dtg_Producto.CurrentRow;

            txt_nombre.Text = Convert.ToString(row.Cells["nombre"].Value);
            txt_cantidadMax.Text = Convert.ToString(row.Cells["cantidadMax"].Value);
            txt_cantidadMin.Text = Convert.ToString(row.Cells["cantidadMin"].Value);
            txt_tasaInteres.Text = Convert.ToString(row.Cells["tasaInteres"].Value);
            txt_plazo.Text = Convert.ToString(row.Cells["plazo"].Value);


        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                agregarProducto();
                dtg_Producto.DataSource = cl.Select("sp_producto", 1);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido realizar la operacion. Por favor rellene todos los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dtg_Producto.DataSource = cl.Select("sp_producto",1);
        }

        private void dtg_Producto_SelectionChanged(object sender, EventArgs e)
        {
            mostrarDatosParaEditar();
        }
    }
}
