﻿using System;
using Pisto_credito.src.BD;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Pisto_credito.Interface
{
    public partial class frmLogin : Form
    {
        clConexion cl = new clConexion();
        frmMainMenu frmMainMenu = new frmMainMenu();
     

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
                
        }

       

        private void consultaLogin()
        {
            ArrayList parametros = new ArrayList();
            parametros.Add(txtUser.Text);
            parametros.Add(txtPassword.Text);

            ArrayList datos = new ArrayList();
            datos.Add("@usuario");
            datos.Add("@pass");
            

            DataTableReader reader = cl.SelectWithParameters("sp_usuario",5,parametros,datos).CreateDataReader();

          
            if (reader.HasRows)
            {

                reader.Read();
                
                    String pass = reader["pass"].ToString();
                    String usuario = reader["usuario"].ToString();


                if (txtUser.Text == usuario & txtPassword.Text == pass)
                {

                    // frmMainMenu.menuStrip1.Enabled = true; 
                   
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta.",
                    "Error de Inicio de Sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
                   }else
            {
                MessageBox.Show("Sin datos");
            }
                    
            }


            private void btnIngresar_Click(object sender, EventArgs e)
            {
                consultaLogin();
            }
            }



}
