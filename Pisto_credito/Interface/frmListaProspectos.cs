using Pisto_credito.src.BD;
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

namespace Pisto_credito.Interface
{
    public partial class frmListaProspectos : Form
    {
        clConexion cl = new clConexion();
        public frmListaProspectos()
        {
            InitializeComponent();
        }

        private void btn_Evaluar_Click(object sender, EventArgs e)
        {
          

            try
            {
                
               frmEvaluarProspectos frmEvaluar = new frmEvaluarProspectos();
                frmEvaluar.Show();
                frmEvaluar.txt_dpi.Text = (dtg_Prospectos.Rows[dtg_Prospectos.CurrentRow.Index].Cells[2].Value.ToString());
               
            
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el prospecto a evaluar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
       
        private void seleccionarEvaluacion()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();


            
            //idPROSPECTO DE LA FILA SELECCIONADA   x
            int idProspecto =  Convert.ToInt32(dtg_Prospectos.Rows[dtg_Prospectos.CurrentRow.Index].Cells[0].Value.ToString());
            parametros.Add(idProspecto);
            datos.Add("@idProspecto");  
            
            DataTable dt = new DataTable();

            dt = cl.SelectWithParameters("sp_evaluacion2",17,parametros, datos);

            DataTableReader reader = dt.CreateDataReader();
            if (reader.HasRows)
            {
                reader.Read();
                String estado = null;
                estado = reader["estado"].ToString();

                if (estado == "La evaluacion 1 fue completada, continúa proceso.")
                {
                    try
                    {
                        //iniciarEvaluacion2();
                        MessageBox.Show("holi 2");
                        frmEvaluacion2 frmEvalua2 = new frmEvaluacion2();
                        frmEvalua2.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    { 
                        MessageBox.Show("Seleccione el prospecto a evaluar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else if (estado == "La evaluacion 2 fue completada, continúa proceso.")
                {
                    try
                    {
                        MessageBox.Show("holi 3");
                        // iniciarEvaluacion3();
                        frmEvaluacion3 frmEvalua3 = new frmEvaluacion3();
                        frmEvalua3.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Seleccione el prospecto a evaluar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else if (estado == "La evaluacion 3 fue completada. Credito Aprobado.")
                {


                    MessageBox.Show("Este prospecto ha concluido con exito el proceso de evaluación y ahora es un cliente. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if (estado == "")
                {
                    try
                    {
                        MessageBox.Show("holi 1");
                        // iniciarEvaluacion1();
                        frmEvaluacion1 frmEvalua1 = new frmEvaluacion1();
                        frmEvalua1.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {
                       
                        MessageBox.Show("Seleccione el prospecto a evaluar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (estado == "Evaluación desaprobada.Solicitud de Credito Denegada.")
                {
                    MessageBox.Show("El proceso del prospecto seleccionado ha sido cancelado, la solicitud del mismo ha sido denegada.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaProspectos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Evaluacion 1")
            {
                dtg_Prospectos.DataSource = cl.Select("sp_evaluacion1", 12);
            }
            else if (label1.Text == "Evaluacion 2")
            {
                dtg_Prospectos.DataSource = cl.Select("sp_evaluacion2", 16);
            }
            else if (label1.Text == "Evaluacion 3")
            {
                dtg_Prospectos.DataSource = cl.Select("sp_evaluacion3", 12);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMenuEvaluaciones frmEvaluacion = new frmMenuEvaluaciones();
            frmEvaluacion.Show();
            this.Hide();
        }
    }
}


