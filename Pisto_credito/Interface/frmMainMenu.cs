using System;
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
    public partial class frmMainMenu : Form

    {
        //public String DPI;
        public static frmMainMenu mdiObj;
        public frmMainMenu()
        {
            InitializeComponent();
            

        }

        

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

            menuStrip1.Enabled = false;

            frmLogin frmLogin = new frmLogin();
            frmLogin.MdiParent = this;
           
            frmLogin.Show();
            mdiObj = this;
            




        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmU = new frmUsuario();
            frmU.MdiParent = this;
            frmU.Show();
        }

        private void permisos_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMain = new frmMainMenu();
            this.Hide();
            frmMain.Show();
        }

        private void verProspectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProspecto frmP = new frmProspecto();
            frmP.MdiParent = this;
            frmP.Show();

        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto frmProducto = new frmProducto();
            frmProducto.MdiParent = this;
            frmProducto.Show();
           
        }

        private void verificarProspectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvaluarProspectos frmEvaluar = new frmEvaluarProspectos();
            frmEvaluar.MdiParent = this;
            frmEvaluar.Show();

        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmClientes = new frmCliente();
            frmClientes.MdiParent = this;
            frmClientes.Show();

        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvaluaciones frmEvaluacion = new frmEvaluaciones();
            frmEvaluacion.MdiParent = this;
            frmEvaluacion.Show();

        }

        private void gestionarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionPermisos frmGestionar = new frmGestionPermisos();
            frmGestionar.MdiParent = this;
            frmGestionar.Show();
        }

    }
    
}
