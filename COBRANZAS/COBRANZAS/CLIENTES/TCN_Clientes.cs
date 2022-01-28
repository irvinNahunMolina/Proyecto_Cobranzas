using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COBRANZAS.Model;
using COBRANZAS.CLIENTES;
using System.Data;
using System.Windows.Forms;

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

        public bool modificar(TModelsClientes prmClientes, string prmUsuario)
        {
            return this.objAd_Clientes.Actualizar(prmClientes, prmUsuario);
        }

        public bool anular(string prmIDCliente)
        {
            bool resp = false;
            if(int.TryParse(prmIDCliente, out int valid))
            {
                resp = this.objAd_Clientes.Anular(valid);
            }
            else
            {
                MessageBox.Show("El valor de id es invalido.","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            return resp;
        }

        public List<TModelsClientes> GetClientes()
        {
            return this.objAd_Clientes.GetClientes();
        }
    }
}
