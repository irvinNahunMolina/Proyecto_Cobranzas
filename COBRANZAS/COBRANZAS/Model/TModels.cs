using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBRANZAS.Model
{
   public class TModelsClientes
    {
       public int Id { set; get; }
       public  string Identidad { set; get; }
       public  string Nombre { set; get; }
       public  string Direccion { set; get; }
       public  string Telefono { set; get; }
       public  string Correo { set; get; }
       public  string Municipio { set; get; }
       public  DateTime Fecha_Nacimineto { set; get; }
       public  DateTime Fecha_Creacion { set; get; }
       public  DateTime Fecha_Modificacion { set; get; }
       public  string Usuario_Creacion { set; get; }
       public  string Ususario_Modificacion { set; get; }


    }
}
