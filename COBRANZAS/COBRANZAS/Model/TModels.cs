using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBRANZAS.Model
{
   public class TModelsClientes
    {
        int Id { set; get; }
        string Identidad { set; get; }
        string Nombre { set; get; }
        string Direccion { set; get; }
        string Telefono { set; get; }
        string Correo { set; get; }
        string Municipio { set; get; }
        DateTime Fecha_Nacimineto { set; get; }
        string Usuario_Creacion { set; get; }
        string Ususario_Modificacion { set; get; }

    }
}
