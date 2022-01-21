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
    }
}
