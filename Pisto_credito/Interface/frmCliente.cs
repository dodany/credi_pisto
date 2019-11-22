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

        private void Clientes_Load(object sender, EventArgs e)
        {
            dtgProspecto.DataSource = cl.Select("sp_cliente", 1);
        }

        private void dtgProspecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
