using COBRANZAS.AdminDB;
using COBRANZAS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES
{
   public class TAD_Clientes
    {
        TParamSQL objParamSQL = new TParamSQL();
        List<TModelsClientes> lstClientes = new List<TModelsClientes>();

        public TAD_Clientes()
        {

        }

        //Consulta la informnacion de un cliente por medio de su id
        public TModelsClientes Consultar(int Id)
        {
            DataTable dtClientes = new DataTable();
            TModelsClientes objClientes = new TModelsClientes();
            using (SqlConnection con = new SqlConnection(objParamSQL.getStringCon()))
            {
               try
                {
                    con.Open();
                    SqlCommand  query = new SqlCommand($"SELECT * FROM CLIENTES WHERE ID = {Id}", con);
                    dtClientes.Load(query.ExecuteReader());
                    con.Close();
                    if(dtClientes.Rows.Count > 0)
                    {
                        foreach(DataRow fila in dtClientes.Rows)
                        {
                            objClientes.Id = Convert.ToInt32(fila["ID"].ToString());
                            objClientes.Identidad = fila["IDENTIDAD"].ToString();
                            objClientes.Nombre = fila["NOMBRE"].ToString();
                            objClientes.Direccion = fila["DIRECCION"].ToString();
                            objClientes.Telefono = fila["TELEFONO"].ToString();
                            objClientes.Correo = fila["CORREO"].ToString();
                            objClientes.Municipio = fila["MUNICIPIO"].ToString();
                            objClientes.Usuario_Creacion = fila["USUARIO_CREACION"].ToString();
                            objClientes.Ususario_Modificacion = fila["USUARIO_MODIFICACION"].ToString();
                            DateTime Fecha_Creacion = new DateTime(); ;
                            objClientes.Fecha_Creacion = (DateTime.TryParse(fila["FECHA_CREACION"].ToString(), out Fecha_Creacion) ? Fecha_Creacion : Fecha_Creacion);
                            objClientes.Fecha_Creacion.ToString();
                            DateTime FechaNac = new DateTime();
                            objClientes.Fecha_Nacimineto = (DateTime.TryParse(fila["FECHA_NACIMIENTO"].ToString(), out FechaNac) ? FechaNac : FechaNac);
                        }
                    }
                }
                catch(Exception Err)
                {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}");
                }
            }


            return objClientes;
        }

        //Devuelve la lista de clientes..
        public List<TModelsClientes> GetClientes()
        {
            List<TModelsClientes> Clientes = new List<TModelsClientes>();

            using(SqlConnection con = new SqlConnection(objParamSQL.getStringCon()) )
            {
                try
                {
                    con.Open();
                    SqlCommand query = new SqlCommand("SP_LISTAR_CLIENTES", con);
                    DataTable dtDatos = new DataTable();
                    dtDatos.Load(query.ExecuteReader());

                    if(dtDatos.Rows.Count > 0)
                    {
                        foreach(DataRow fila in dtDatos.Rows)
                        {
                            Clientes.Add(new TModelsClientes { 
                                Id = (int)fila["ID"],
                                Identidad = fila["IDENTIDAD"].ToString(),
                                Nombre = fila["NOMBRE"].ToString(),
                                Direccion = fila["DIRECCION"].ToString(),
                                Telefono = fila["TELEFONO"].ToString(),
                                Correo = fila["CORREO"].ToString(),
                                Municipio = fila["MUNICIPIO"].ToString(),
                                Fecha_Nacimineto = (DateTime)fila["FECHA_NACIMIENTO"],
                                //Fecha_Creacion = (DateTime)fila["FECHA_CREACION"],
                                //Fecha_Modificacion = (DateTime)fila["FECHA_MODIFICACION"],
                                Usuario_Creacion = fila["USUARIO_CREACION"].ToString(),
                                Ususario_Modificacion = fila["USUARIO_MODIFICACION"].ToString()
                            });
                        }
                        
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show($"la operacion no se pudo completar cominicarse con Soporte IT \n {err.Message}");
                }
            }
            return Clientes;
        }

        //Guarda un cliente en la base de datos
        public bool Guardar(TModelsClientes prmCliente, string prmUsusario)
        {
            bool valResult = false;

            using (SqlConnection con = new SqlConnection(objParamSQL.getStringCon()))
            {
                try
                {
                    con.Open();
                    SqlCommand objsql = new SqlCommand("SP_INSERTAR_CLIENTES", con);
                    objsql.CommandType = CommandType.StoredProcedure;
                    objsql.CommandText = "SP_INSERTAR_CLIENTES";
                    objsql.Parameters.AddWithValue("@prmIdentidad", prmCliente.Identidad);
                    objsql.Parameters.AddWithValue("@prmNombre", prmCliente.Nombre);
                    objsql.Parameters.AddWithValue("@prmDireccion", prmCliente.Direccion);
                    objsql.Parameters.AddWithValue("@prmTelefono", prmCliente.Telefono);
                    objsql.Parameters.AddWithValue("@prmCorreo", prmCliente.Correo);
                    objsql.Parameters.AddWithValue("@prmMunicipio", prmCliente.Municipio);
                    objsql.Parameters.AddWithValue("@prmFecha_Nacimineto", prmCliente.Fecha_Nacimineto);
                    objsql.Parameters.AddWithValue("@UsuarioCreacion", prmUsusario);
                    objsql.Parameters.AddWithValue("@RESULT", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    objsql.ExecuteNonQuery();
                    int Num = (int)objsql.Parameters["@RESULT"].Value;

                    if (Num == 1)
                        valResult = true;
                        //MessageBox.Show(Num);
                }
                catch(Exception Err)
                {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}");
                }
            }
                return valResult;
        }

        public bool Actualizar(TModelsClientes prmCliente, string prmUsusario)
        {
            bool valResult = false;

            using (SqlConnection con = new SqlConnection(objParamSQL.getStringCon()))
            {
                try
                {
                    con.Open();
                    SqlCommand objsql = new SqlCommand("SP_ACTUALIZAR_CLIENTES", con);
                    objsql.CommandType = CommandType.StoredProcedure;
                    objsql.CommandText = "SP_ACTUALIZAR_CLIENTES";
                    objsql.Parameters.AddWithValue("@prmID", prmCliente.Id);
                    objsql.Parameters.AddWithValue("@prmIdentidad", prmCliente.Identidad);
                    objsql.Parameters.AddWithValue("@prmNombre", prmCliente.Nombre);
                    objsql.Parameters.AddWithValue("@prmDireccion", prmCliente.Direccion);
                    objsql.Parameters.AddWithValue("@prmTelefono", prmCliente.Telefono);
                    objsql.Parameters.AddWithValue("@prmCorreo", prmCliente.Correo);
                    objsql.Parameters.AddWithValue("@prmMunicipio", prmCliente.Municipio);
                    objsql.Parameters.AddWithValue("@prmFecha_Nacimineto", prmCliente.Fecha_Nacimineto);
                    objsql.Parameters.AddWithValue("@UsuarioCreacion", prmUsusario);
                    //objsql.Parameters.AddWithValue("@prmFecha_Nacimineto", prmCliente.Fecha_Modificacion);
                    //objsql.Parameters.AddWithValue("@UsuarioCreacion", prmUsusario);
                    objsql.Parameters.AddWithValue("@RESULT", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    objsql.ExecuteNonQuery();
                    int Num = (int)objsql.Parameters["@RESULT"].Value;

                    if (Num == 1)
                        valResult = true;
                    //MessageBox.Show(Num);
                }
                catch (Exception Err)
                {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}");
                }
            }
            return valResult;
        }

        public bool Anular( int IdCliente)
        {
            return false;
        }
    }
}
