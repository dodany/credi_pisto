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
    public partial class frmEvaluacion2 : Form
    {

        clConexion cl = new clConexion();
        private int id;
        public String DPI;

        public frmEvaluacion2()
        {
            InitializeComponent();
        }

        private void frmEvaluacion2_Load(object sender, EventArgs e)
        {
            llenarDTG_Prospecto();
            btn_Aprobar.Enabled = false;
            btn_Continuar.Enabled = false;
        }

        private void btn_Aprobar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro que la informacion es veridica y aprobar esta evaluación?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {
                    aprobarEvaluacion();
                    btn_Continuar.Enabled = true;
                    llenarDTG_Prospecto();
                    MessageBox.Show("La evaluación ha sido aprobada correctamente. ", "Evaluacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("¡Error! La operacion no se ha completado con exito!",
                 "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_desaprobar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Desea desaprobar la evaluación?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {
                    desaprobarEvaluacion();
                    llenarDTG_Prospecto();
                    MessageBox.Show("La evaluación ha sido cancelada, la solicitud ha sido rechazada. ", "Evaluacion Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("¡Error! La operacion no se ha completado con exito!",
                 "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            verificarAprobacion();
        }


        public void verificarAprobacion()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            parametros.Add(txt_idProspecto.Text);
            datos.Add("@idProspecto");
            //Program.DPI = txt_idProspecto.Text;
            DataTable dt = new DataTable();

            dt = cl.SelectWithParameters("sp_evaluacion2",9, parametros, datos);

            
            if (dt.Rows.Count > 0)
            {
                DataTableReader reader = dt.CreateDataReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    


                    bool verificacion = Convert.ToBoolean(reader["verificacion"]);
                    if (verificacion == true)
                    {
                        btn_Continuar.Enabled = true;
                        try
                        {
                            DialogResult result1 = MessageBox.Show("¿Desea continuar con el proceso de evaluación?",
                                 "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                            if (result1 == DialogResult.Yes)
                            {
                                iniciarEvaluacion3();
                                this.Close();
                                MessageBox.Show("La Evaluacion 2 ha sido terminada con exito.", "Evaluacion Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else{}

                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("¡Error! La operacion no se ha completado con exito!",
                             "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else {
                        MessageBox.Show("xd");
                    }
                }
            }
        }
        public void aprobarEvaluacion()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(txt_idProspecto.Text);


            cl.SelectWithParameters("sp_evaluacion2",6, parametro, dato);
        }

        public void desaprobarEvaluacion()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@idProspecto");
            parametro.Add(txt_idProspecto.Text);

            cl.SelectWithParameters("sp_evaluacion2",8, parametro, dato);
        }

        public void llenarDTG_Prospecto()
        {
            ArrayList parametro = new ArrayList();
            ArrayList dato = new ArrayList();

            dato.Add("@dpi");
            parametro.Add(DPI);

            dtgProspecto.DataSource = cl.SelectWithParameters("sp_evaluacion2",4, parametro, dato);
        }

        private void dtgProspecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void mostrarDatosParaEditar()
        {
            DataGridViewRow row = dtgProspecto.CurrentRow;

            txt_dpi.Text = Convert.ToString(row.Cells["dpi"].Value);
            txt_idProspecto.Text = Convert.ToString(row.Cells["idProspecto"].Value);
            txt_Domicilio.Text = Convert.ToString(row.Cells["domicilio"].Value);
            txt_Trabajo.Text = Convert.ToString(row.Cells["trabajo"].Value);
            txt_telTrabajo.Text = Convert.ToString(row.Cells["telTrabajo"].Value);
            txt_telDomicilio.Text = Convert.ToString(row.Cells["telDomicilio"].Value);
        }

        private void dtgProspecto_SelectionChanged(object sender, EventArgs e)
        {
            mostrarDatosParaEditar();
        }

        private void btn_VerficarDomicilio_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro que la locación del prospecto es válida?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {
                    cl.Select("sp_evaluacion2", 13);
                    
                   // btn_Aprobar.Enabled = true;
                    MessageBox.Show("El domicilio del prospecto ha sido verificado.", "Verificacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {}
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("¡Error! La operacion no se ha completado con exito!",
                 "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_VerificarTrabajo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro que los datos donde labora el prospecto son válidos?",
                     "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result1 == DialogResult.Yes)
                {
                    cl.Select("sp_evaluacion2", 12);
                    btn_Aprobar.Enabled = true;
                    // btn_Aprobar.Enabled = true;
                    MessageBox.Show("Los datos han sido verificados con éxito.", "Verificacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("¡Error! La operacion no se ha completado con exito!",
                 "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                editarDatosProspecto();
            }
            catch
            {
                MessageBox.Show("Seleccione una fila para poder editarla",
                " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            llenarDTG_Prospecto();
        }
        public void editarDatosProspecto()
        {
            ArrayList parametros = new ArrayList();
            ArrayList datos = new ArrayList();

            datos.Add("@idProspecto");            
            datos.Add("@telDomicilio");
            datos.Add("@telTrabajo");           
            datos.Add("@Trabajo");
            datos.Add("@Domicilio");

            parametros.Add(ObtenerId());
            parametros.Add(txt_telDomicilio.Text);
            parametros.Add(txt_telTrabajo.Text);
            parametros.Add(txt_Trabajo.Text);
            parametros.Add(txt_Domicilio.Text);
           
            
            try
            {
            cl.SelectWithParameters("sp_evaluacion2",14,parametros, datos);
                
                // MessageBox.Show("El registro se ha editado correctamente ", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Seleccione una fila para poder editarla",
                  " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        public int ObtenerId()
        {
            DataGridViewRow row = dtgProspecto.CurrentRow;
            if (row != null)
            {
                id = Convert.ToInt32(row.Cells["idProspecto"].Value);
            }
            return id;
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
    }

}
