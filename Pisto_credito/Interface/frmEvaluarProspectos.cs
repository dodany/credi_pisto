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
        //public String DPI;

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
            frmEvaluacion1 frmEvaluar = new frmEvaluacion1();
            frmEvaluar.DPI = txt_dpi.Text;
            dtg_Evaluacion.DataSource = cl.SelectWithParameters("sp_prospecto",8,parametros,datos);
            
        }
        private void frmEvaluarProspectos_Load(object sender, EventArgs e)
        {
            mdiObj2 = this;
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {    consultaProspecto();

                DataGridViewRow row = dtg_Evaluacion.CurrentRow;
                txt_idProspecto.Text = Convert.ToString(row.Cells["idProspecto"].Value);
            }
            catch {

                MessageBox.Show("El prospecto no ha sido encontrado en la base de datos. Ingrese nuevamente el dato requerido","Prospecto no encontrado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
           
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
                            iniciarEvaluacion3();
                            
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
                        iniciarEvaluacion1();

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
        public void iniciarEvaluacion1()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(ObtenerId());
          
            cl.Insert("sp_evaluacion1", 0, parametro, dato, false);
            frmEvaluacion1 frmEvalua1 = new frmEvaluacion1();
            frmEvalua1.DPI = txt_dpi.Text;
            frmEvalua1.Show();
        }
        public void iniciarEvaluacion2()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(ObtenerId());

            cl.Insert("sp_evaluacion2", 0, parametro, dato, false);
            frmEvaluacion2 frmEvalua2 = new frmEvaluacion2();
            frmEvalua2.DPI = txt_dpi.Text;
            frmEvalua2.Show();
        }
        
        public void iniciarEvaluacion3()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(ObtenerId());

            cl.Insert("sp_evaluacion3", 0, parametro, dato, false);
            frmEvaluacion3 frmEvalua3 = new frmEvaluacion3();
            frmEvalua3.DPI = txt_dpi.Text;
            frmEvalua3.idProspect = Convert.ToInt32(txt_idProspecto.Text);
            frmEvalua3.Show();
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

        private void txt_idProspecto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
