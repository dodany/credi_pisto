using Pisto_credito.src.BD;
using System;
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
    }
}
