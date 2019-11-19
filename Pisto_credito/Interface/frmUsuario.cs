using Pisto_credito.src.BD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisto_credito.Interface
{
    public partial class frmUsuario : Form
    {

        clConexion cl = new clConexion();
        public int id;

        public frmUsuario()
        {
            InitializeComponent();
        }


        private void consultaUsuarios()
        {
            DataTable dt = new DataTable();
            dt = cl.Select("sp_usuario", 2);

            if (dt.Rows.Count > 0)
            {
                DataTableReader reader = dt.CreateDataReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    String pass = reader["pass"].ToString();

                    Console.WriteLine("Usuario ->" + pass);
                }
            }
        }


        private void agregarUsuario()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();


            datos.Add("@nombre");
            datos.Add("@usuario");
            datos.Add("@correo");
            datos.Add("@pass");
            datos.Add("@idRol");

            parametros.Add(txt_nombre.Text);
            parametros.Add(txt_usuario.Text);
            parametros.Add(txt_correo.Text);
            parametros.Add(txt_contraseña.Text);
            parametros.Add(cmb_idRol.SelectedValue);

            cl.Insert("sp_usuario", 0, parametros, datos, false);

        }

        public void eliminarUsuario()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(ObtenerId());
            datos.Add("@idUsuario");
            cl.SelectWithParameters("sp_usuario", 4, parametros, datos);
        }
        public int ObtenerId() {

            DataGridViewRow row = dtgUsuario.CurrentRow;
            if (row != null)
            {
                id = Convert.ToInt32(row    .Cells["idUsuario"].Value);
            }
            return id;
        }

        public void editarUsuario()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(ObtenerId());
            parametros.Add(txt_nombre.Text);
            parametros.Add(txt_usuario.Text);
            parametros.Add(txt_correo.Text);
            parametros.Add(txt_contraseña.Text);
            parametros.Add(cmb_idRol.SelectedValue);
           
            datos.Add("@idUsuario");
            datos.Add("@nombre");
            datos.Add("@usuario");
            datos.Add("@correo");
            datos.Add("@pass");
            datos.Add("@idRol");

            try
            {
                cl.SelectWithParameters("sp_usuario", 3, parametros, datos);
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
            DataGridViewRow row = dtgUsuario.CurrentRow;

            txt_nombre.Text = Convert.ToString(row.Cells["nombre"].Value);
            txt_correo.Text = Convert.ToString(row.Cells["correo"].Value);
            txt_usuario.Text = Convert.ToString(row.Cells["usuario"].Value);
            txt_contraseña.Text = Convert.ToString(row.Cells["pass"].Value);
            cmb_idRol.Text = Convert.ToString(row.Cells["idRol"].Value);

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            llenarCombo();
            dtgUsuario.DataSource = cl.Select("sp_usuario", 2);
            cmb_idRol.Text = "Elegir una opcion";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarUsuario();
            dtgUsuario.DataSource = cl.Select("sp_usuario", 2);
        }

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que desea eliminar este registro?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result1 == DialogResult.Yes)
                {
                    eliminarUsuario();
                    dtgUsuario.DataSource = cl.Select("sp_usuario", 2);
                    MessageBox.Show("El registro se ha eliminado correctamente ", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }

            }
            catch(System.Data.SqlClient.SqlException) {
                MessageBox.Show("¡Error! La operacion no se ha completado con exito!",
                 "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void llenarCombo()
        {
            cmb_idRol.DataSource = cl.Select("sp_usuario", 6);
            cmb_idRol.ValueMember = "idRol";
            cmb_idRol.DisplayMember = "rol";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
           

           // MessageBox.Show("Seleccione un usuario para poder deshabilitarlo.");
            DialogResult result1 = MessageBox.Show("¿Esta seguro de que desea deshabilitar al usuario "+ObtenerId()+" ?",
                    "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result1 == DialogResult.Yes)
            {
                ArrayList parametros = new ArrayList();
                ArrayList datos = new ArrayList();


                parametros.Add(ObtenerId());

                datos.Add("@idUsuario");
                cl.SelectWithParameters("sp_usuario", 7, parametros, datos);
                
                dtgUsuario.DataSource = cl.Select("sp_usuario", 2);
                MessageBox.Show("El usuario se ha deshabilitado. ", "Usuario Deshabilitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void cmb_idRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
            try
            {
                editarUsuario();
            }
            catch
            {
                MessageBox.Show("Seleccione una fila para poder editarla",
                " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dtgUsuario.DataSource = cl.Select("sp_usuario", 2);
        }

        private void dtgUsuario_SelectionChanged(object sender, EventArgs e)
        {
            mostrarDatosParaEditar();
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("¿Esta seguro de que desea Habilitar al usuario " + ObtenerId() + " ?",
                  "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result1 == DialogResult.Yes)
            {

                ArrayList parametros = new ArrayList();
                ArrayList datos = new ArrayList();


                parametros.Add(ObtenerId());

                datos.Add("@idUsuario");
                cl.SelectWithParameters("sp_usuario", 8, parametros, datos);

                dtgUsuario.DataSource = cl.Select("sp_usuario", 2);
                MessageBox.Show("El usuario se ha habilitado. ", "Usuario Habilitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        private void button1_Click(object sender, EventArgs e)
            {

            }
        
    }
}
