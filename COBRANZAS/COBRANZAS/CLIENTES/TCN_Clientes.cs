using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COBRANZAS.Model;
using COBRANZAS.CLIENTES;
using System.Data;

namespace COBRANZAS.CLIENTES
{
    class TCN_Clientes
    {
        TAD_Clientes objAd_Clientes = new TAD_Clientes();


        public TModelsClientes consultar(string Id)
        {
            var result = int.TryParse(Id, out int valId);

            if (result)
                return objAd_Clientes.Consultar(valId);
            else
                return default;
        }

        public bool insertar(TModelsClientes prmClientes, string prmUsuario)
        {
            return this.objAd_Clientes.Guardar(prmClientes, prmUsuario);
        }
    }
}
