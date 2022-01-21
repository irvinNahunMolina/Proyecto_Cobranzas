using COBRANZAS.AdminDB;
using COBRANZAS.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES
{
   public class TAD_Clientes
    {
        TModelsClientes objClientes = new TModelsClientes();
        TParamSQL objParamSQL = new TParamSQL();

        public TAD_Clientes()
        {

        }

        public TModelsClientes Consultar(int Id)
        {
            DataTable dtClientes = new DataTable();
            using (SqlConnection con = new SqlConnection(objParamSQL.getStringCon()))
            {
               try
                {
                    con.Open();
                    SqlCommand  query = new SqlCommand($"SELECT * FROM CLIENTES WHERE ID = {Id}");
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
                            //objClientes.Fecha_Nacimineto = fila["FECHA_NACIMIENTO"].ToString();
                            objClientes.Usuario_Creacion = fila["USUARIO_CREACION"].ToString();
                            objClientes.Ususario_Modificacion = fila["USUARIO_MODIFICACION"].ToString();
                        }
                    }
                }
                catch(Exception Err)
                {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}");
                }
            }


            return dtClientes;
        }

        public bool Guardar(TModelsClientes prmCliente)
        {
            return false;
        }

        public bool Actualizar(TModelsClientes prmCliente)
        {
            return false;
        }

        public bool Anular( int IdCliente)
        {
            return false;
        }
    }
}
