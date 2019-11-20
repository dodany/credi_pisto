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
using Pisto_credito.Interface;
using Pisto_credito.src.BD;

namespace Pisto_credito
{
    public partial class frmEvaluarProspectos : Form
    {
        clConexion cl = new clConexion();
        public int id;
        public static frmEvaluarProspectos mdiObj2;
        public frmEvaluarProspectos()
        {
            InitializeComponent();
        }

        public void consultaProspecto()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(txt_dpi.Text);
            datos.Add("@dpi");
            Program.DPI = txt_dpi.Text;
            dtg_Evaluacion.DataSource = cl.SelectWithParameters("sp_prospecto",8,parametros,datos);
            
        }
        private void frmEvaluarProspectos_Load(object sender, EventArgs e)
        {
            mdiObj2 = this;
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultaProspecto();
           
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            seleccionarEvaluacion();
        }
        private void seleccionarEvaluacion()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(txt_dpi.Text);
            datos.Add("@dpi");
            Program.DPI = txt_dpi.Text;
            DataTable dt = new DataTable();

            dt = cl.SelectWithParameters("sp_prospecto", 8, parametros, datos);

            DataTableReader reader = dt.CreateDataReader();
                if (reader.HasRows)
                {
                    reader.Read();
                     String estado = null;
                            estado = reader["estado"].ToString();

                    if(estado == "La evaluacion 1 fue completada, continúa proceso.")
                    {
                   try
                    {
                        iniciarEvaluacion2();
                        frmEvaluacion2 frmEvalua2 = new frmEvaluacion2();
                        frmEvalua2.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Seleccione el prospecto a evaluar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                
                    }
                    else if (estado == "")
                    {
                        try
                        {
                            iniciarEvaluacion1();
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
        private void iniciarEvaluacion1()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(ObtenerId());
          
            cl.Insert("sp_evaluacion1", 0, parametro, dato, false);
        }
        private void iniciarEvaluacion2()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(ObtenerId());

            cl.Insert("sp_evaluacion2", 0, parametro, dato, false);
        }
        public int ObtenerId()
        {
            DataGridViewRow row = dtg_Evaluacion.CurrentRow;
            if (row != null)
            {
                id = Convert.ToInt32(row.Cells["idProspecto"].Value);
            }
            return id;
        }

        private void txt_dpi_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtg_Evaluacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
