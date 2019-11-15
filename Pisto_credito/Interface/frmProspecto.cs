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
        public frmProspecto()
        {
            InitializeComponent();
        }
        /*
        private void agregarProspecto()
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
        */
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProspecto_Load(object sender, EventArgs e)
        {

        }
    }
}
