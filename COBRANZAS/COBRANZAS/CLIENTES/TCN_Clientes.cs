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
        private readonly int Men_Edad = 18;   // este es una variable que controla la edad del cliente debe ser mayor de edad.

        public TModelsClientes consultar(string Id)
        {
            var result = int.TryParse(Id, out int valId);

            if (result)
                return objAd_Clientes.Consultar(valId);
            else
                return default;
        }

        public string validar(TModelsClientes prmCliente)
        {
            string msj_valid = "";

            if (string.IsNullOrWhiteSpace(prmCliente.Identidad))
                msj_valid += $"-. Es necesario que ingrese el numero de identidad \n";

            if(prmCliente.Identidad.Length != 13)
                msj_valid += $"-. El numero de identidad ingresado es invalido \n";

            if (string.IsNullOrWhiteSpace(prmCliente.Nombre))
                msj_valid += $"-. Es necesario que ingrese el nombre del Cliente \n";

            if (string.IsNullOrWhiteSpace(prmCliente.Direccion))
                msj_valid += $"-. Es necesario que ingrese la direccion del Cliente \n";

            if (string.IsNullOrWhiteSpace(prmCliente.Telefono))
                msj_valid += $"-. Es necesario que ingrese el numero de Telefono \n";

            if (prmCliente.Telefono.Length != 8)
                msj_valid += $"-. El numero de Telefono ingresado es invalido \n";

            if (string.IsNullOrWhiteSpace(prmCliente.Municipio))
                msj_valid += $"-. Es necesario que ingrese el Municipio \n";

            DateTime Fecha_Actual = DateTime.Now;
            DateTime Fecha_Nacimiento = prmCliente.Fecha_Nacimineto;
            if(!((Fecha_Actual.Year - Fecha_Nacimiento.Year) >= this.Men_Edad))
                msj_valid += $"-. El año de nacimiento debe ser menor a año: {Fecha_Actual.Year} Y el cliente debe ser mayor de edad \n";


            return msj_valid;
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
