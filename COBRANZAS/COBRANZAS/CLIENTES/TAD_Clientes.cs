using COBRANZAS.AdminDB;
using COBRANZAS.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace COBRANZAS.CLIENTES
{
    class TAD_Clientes
    {
        TModelsClientes objClientes = new TModelsClientes();
        TParamSQL objParamSQL = new TParamSQL();

        public TAD_Clientes()
        {

        }

        public TModelsClientes Consultar(int Id)
        {
            using (SqlConnection con = new SqlConnection(objParamSQL.getStringCon()))
            {
                DataTable dtClientes = new DataTable();

                try
                {
                    con.Open();
                    SqlCommand  query = new SqlCommand($"SELECT * FROM CLIENTES WHERE ID = {Id}");
                    dtClientes.Load(query.ExecuteReader());
                    con.Close();
                    if(dtClientes.Rows.Count > 0)
                    {
                        foreach(DataRow fila in dtClientes)
                        {

                        }
                    }
                }
                catch(Exception err)
                {

                }
            }


            return default;
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
