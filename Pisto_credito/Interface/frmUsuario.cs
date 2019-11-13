using Pisto_credito.src.BD;
using System;
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



       


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            //consultaUsuarios();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
