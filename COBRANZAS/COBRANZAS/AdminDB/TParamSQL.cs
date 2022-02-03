using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace COBRANZAS.AdminDB
{
    public class TParamSQL
    {
        private SqlConnectionStringBuilder objBuilder = new SqlConnectionStringBuilder();

        public TParamSQL()
        {
            objBuilder.DataSource = "DESKTOP-MIE85AK";
            objBuilder.InitialCatalog = "PROYECTO_CSHARP";
            objBuilder.UserID = "sa";
            objBuilder.Password = "itempo%123";
        }

        // Retorna la cadena de conexion a la base de datos.
        public string  getStringCon()
        {
            return objBuilder.ConnectionString;
        }
    }
}
