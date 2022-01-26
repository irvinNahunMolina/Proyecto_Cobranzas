using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COBRANZAS.CLIENTES;
using COBRANZAS.Model;

namespace COBRANZAS.CLIENTES
{
    public partial class frmClientes : MaterialForm
    {
        TCN_Clientes objCN_Clientes = new TCN_Clientes();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var cliente = objCN_Clientes.consultar(txtCliente.Text);
            txtNombre.Text = cliente.Nombre;
            txtIdentidad.Text = cliente.Identidad;

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            TModelsClientes cliente = new TModelsClientes();

            cliente.Identidad = txtIdentidad.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = "Col. Villas Del Carmen";
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Municipio = txtMunicipio.Text;
            DateTime fechaNac = new DateTime(1991, 12, 01);
            cliente.Fecha_Nacimineto = fechaNac;
            this.objCN_Clientes.insertar(cliente, "Sistema");
        }
    }
}
