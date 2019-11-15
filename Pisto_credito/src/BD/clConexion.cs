using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Collections;

namespace Pisto_credito.src.BD
{
    class clConexion
    {

        public  String connectionString()
        {
            return "Data Source = ICONC220\\SQLEXPRESS;"
            + "Initial Catalog = CrediDB; Integrated Security = True";
        }
        /// <summary>
        /// SQL CONEXION
        /// </summary>
        /// <returns></returns>
        public  SqlConnection Conn()
        {
            SqlConnection cn = new SqlConnection("Data Source = ICONC220\\SQLEXPRESS;"
            + "Initial Catalog = CrediDB; Integrated Security = True");
            //cn.Open();

            return cn;
        }

        /// <summary>
        /// FUNCIÓN PARA REALIZAR CONSULTAS (Select)
        /// </summary>
        /// <param name="strSP"></param>
        /// <param name="intOPcion"></param>
        /// <returns> dt FILL con los DATOS </returns>
        public  DataTable Select(String strSP, 
                                       int intOPcion)
        {
            DataTable dt = new DataTable("Consulta");
            
            try
            {
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter dta = new SqlDataAdapter();

                con = Conn();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSP;
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@Opcion", intOPcion);
                dta.SelectCommand = cmd;
                dta.Fill(dt);

                //Cerrando todas las conexion
                con.Close();
                cmd.Dispose();
                dta.Dispose();

            } catch (IOException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }

            return dt;
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSP"></param>
        /// <param name="intOPcion"></param>
        /// <param name="arlParametros"></param>
        /// <param name="arlDatos"></param>
        /// <returns></returns>
        public DataTable SelectWithParameters(String strSP,
                                          int intOPcion,
                                           ArrayList arlParametros,
                                         ArrayList arlDatos)
        {
            DataTable dt = new DataTable("Consulta");

            try
            {
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter dta = new SqlDataAdapter();

                con = Conn();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSP;
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@Opcion", intOPcion);
                

                for (int i = 0; i <= arlParametros.Count - 1; i++)
                {
                    cmd.Parameters.AddWithValue( arlDatos[i].ToString(), arlParametros[i].ToString());
                }


                cmd.ExecuteNonQuery();
                dta.SelectCommand = cmd;
                dta.Fill(dt);

                //Cerrando todas las conexion
                con.Close();
                cmd.Dispose();
                dta.Dispose();

            }
            catch (IOException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }

            return dt;

        }



        /// <summary>
        /// FUNCIÓN QUE INSERTA LOS VALORES Y TAMBIÉN DEVUELVE EL VALOR MAXIMO INSERTADO
        /// </summary>
        /// <param name="strSP"></param>
        /// <param name="intOpcion"></param>
        /// <param name="arlParametros"></param>
        /// <param name="arlDatos"></param>
        /// <param name="blnId"></param>
        /// <returns>DOUBLE -- EL VALOR MAXIMO INSERTADO</returns>
        /// 

        public  Double Insert ( String strSP , 
                                       int intOpcion,  
                                       ArrayList arlParametros,
                                       ArrayList arlDatos,
                                       Boolean blnId)
        {
            

            try
            {

                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter dta = new SqlDataAdapter();

                con = Conn();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSP;
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@Opcion",intOpcion);


                for ( int i=0; i <= arlParametros.Count -1; i++)
                {
                    cmd.Parameters.AddWithValue(arlDatos[i].ToString(), arlParametros[i].ToString() );
                }

                cmd.ExecuteNonQuery();

                // INICIO CONSULTA DEL ID -- SI SE NECESITA
                if (blnId)
                {

                    try
                    {
                        DataTable dt = new DataTable("Consulta");

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Opcion", intOpcion);
                        dta.SelectCommand = cmd;
                        dta.Fill(dt);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            return  Double.Parse(reader.GetString(0));
                        }                        
                        else
                        {
                            return 0;
                        }                        
                    }
                    catch (IOException e)
                    {
                        if (e.Source != null)
                            Console.WriteLine("IOException source: {0}", e.Source);
                        throw;

                    }                    

                }
                // FIN CONSULTA DEL ID -- SI SE NECESITA

                //Cerrando todas las conexion
                con.Close();
                cmd.Dispose();
                dta.Dispose();

                return 0;

            }
            catch (IOException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
                
            }
            
        }

    }
}
