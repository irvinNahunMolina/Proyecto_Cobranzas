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
        readonly string Usuario = "Sistema";
        TCN_Clientes objCN_Clientes = new TCN_Clientes();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtCliente.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtIdentidad.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtMunicipio.Text = "";
            dtpFechaNacimiento.Text = "";
            lblCreadoEl.Text = "";
            lblCreadoPor.Text = "";    
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var cliente = objCN_Clientes.consultar(txtCliente.Text);
            txtIdentidad.Text = cliente.Identidad;
            txtNombre.Text = cliente.Nombre;
            txtDireccion.Text = cliente.Direccion;
            txtCorreo.Text = cliente.Correo;
            txtTelefono.Text = cliente.Telefono;
            txtMunicipio.Text = cliente.Municipio;
            dtpFechaNacimiento.Value = cliente.Fecha_Nacimineto;
            lblCreadoEl.Text = $"Creado el: { cliente.Fecha_Creacion }";
            lblCreadoPor.Text = $"Creado Por: { cliente.Usuario_Creacion }";
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            TModelsClientes cliente = new TModelsClientes();

            cliente.Identidad = txtIdentidad.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Municipio = txtMunicipio.Text;
            cliente.Fecha_Nacimineto = dtpFechaNacimiento.Value;
            var resp = this.objCN_Clientes.insertar(cliente, "Sistema");
            if (resp)
             { 
                MessageBox.Show("El cliente se ha guardado con exito");
                Limpiar();
             }
            else
            {
                MessageBox.Show("El cliente no ha Guardado");
            }

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
