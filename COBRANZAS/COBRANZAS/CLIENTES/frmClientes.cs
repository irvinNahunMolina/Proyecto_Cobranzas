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
        TCN_Clientes objCN_Clientes = new TCN_Clientes(); //Objeto de la capa de negocios(Clientes)

        private int accion;                               // 1.Nuevo 2.Modificar 3.Anular

        public frmClientes()
        {
            InitializeComponent();
            this.accion = 1;  // esta variable cuando inicie el sofware estara en modo Nuevo en opcion 1.
        }

        //Este metodo sirve para limpiar los controladores del formulario clientes
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
            lblModificadoEl.Text = "";
            lblModificadoPor.Text = "";
            this.accion = 1;
            txtCliente.Enabled = true;
            this.CargarGrid();
        }

        // Este metodo Nos carga los clientes en el grid del formulario Clientes
        private void CargarGrid()
        {
            var listclientes = this.objCN_Clientes.GetClientes();
            dgvClientes.DataSource = listclientes;
            this.MarcarClientesDesh();
        }

        //Este metodo nos marca de color rojo los clientes que estan anulados
        private void MarcarClientesDesh()
        {
            int NumFila = 0;
            NumFila = dgvClientes.Rows.Count;
            if(NumFila > 0)
            {
                for(int i=0; i < NumFila; i++)
                {
                    String valActivo = "";
                    valActivo = dgvClientes.Rows[i].Cells["ACTIVO"].Value.ToString();

                    if(valActivo == "False")
                    {
                        dgvClientes.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(245,138,114); 
                    }else
                    {
                        dgvClientes.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(159, 154, 152);
                    }
                }
            }
        }



        //En este boton se consulta los datos de un cliente
        private void materialButton1_Click(object sender, EventArgs e)
        {
            var cliente = objCN_Clientes.consultar(txtCliente.Text);

            txtIdentidad.Text = cliente.Identidad;
            txtNombre.Text = cliente.Nombre;
            txtDireccion.Text = cliente.Direccion;
            txtCorreo.Text = cliente.Correo;
            txtTelefono.Text = cliente.Telefono;
            txtMunicipio.Text = cliente.Municipio;
            dtpFechaNacimiento.Value = cliente.Identidad != null ? cliente.Fecha_Nacimineto : DateTime.Now; // condicion de una linea 
            lblCreadoEl.Text = $"Creado el: { cliente.Fecha_Creacion }";
            lblCreadoPor.Text = $"Creado Por: { cliente.Usuario_Creacion }";
            lblModificadoEl.Text = $"Modificado el: { cliente.Fecha_Modificacion }";
            lblModificadoPor.Text = $"Modificado Por: { cliente.Ususario_Modificacion }";
            this.accion = 2;
            txtCliente.Enabled = false;
        }

        //en este boton se Guardan los datos de un cliente
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

            string msj_Valid = objCN_Clientes.validar(cliente);
            bool resp = false;

            if (msj_Valid == "")
            {
                if (accion == 1)
                    resp = this.objCN_Clientes.insertar(cliente, "Sistema");

                if (accion == 2)
                {
                    cliente.Id = Convert.ToInt32(txtCliente.Text);
                    resp = this.objCN_Clientes.modificar(cliente, "Sistema");
                }

                if (resp)
                {
                    MessageBox.Show("El cliente se ha guardado con exito", "AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    this.CargarGrid();
                }
                else
                {
                    MessageBox.Show("El cliente no ha Guardado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                                
            }
            else
            {
                MessageBox.Show(msj_Valid, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }     
                        
        }

        //este boton limpia los datos de un cliente que se ha agregado
        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.CargarGrid();
            this.MarcarClientesDesh();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int NumFila = e.RowIndex;
            
            txtCliente.Text = dgvClientes.Rows[NumFila].Cells["ID"].Value.ToString();
            txtIdentidad.Text = dgvClientes.Rows[NumFila].Cells["IDENTIDAD"].Value.ToString();
            txtNombre.Text = dgvClientes.Rows[NumFila].Cells["NOMBRE"].Value.ToString();
            txtDireccion.Text = dgvClientes.Rows[NumFila].Cells["DIRECCION"].Value.ToString();
            txtTelefono.Text = dgvClientes.Rows[NumFila].Cells["TELEFONO"].Value.ToString();
            txtCorreo.Text = dgvClientes.Rows[NumFila].Cells["CORREO"].Value.ToString();
            txtMunicipio.Text = dgvClientes.Rows[NumFila].Cells["MUNICIPIO"].Value.ToString();
            //txtActivo.Text = dgvClientes.Rows[NumFila].Cells["ACTIVO"].Value.ToString();
            dtpFechaNacimiento.Text = dgvClientes.Rows[NumFila].Cells["FECHA_NACIMINETO"].Value.ToString();
            lblCreadoEl.Text = $"Creado el: {dgvClientes.Rows[NumFila].Cells["FECHA_CREACION"].Value.ToString()}";
            lblModificadoPor.Text = $"Modificado por: {dgvClientes.Rows[NumFila].Cells["USUSARIO_MODIFICACION"].Value.ToString()}";
            lblModificadoEl.Text = $"Modificado el: {dgvClientes.Rows[NumFila].Cells["FECHA_MODIFICACION"].Value.ToString()}";
            lblCreadoPor.Text = $"Creado por: {dgvClientes.Rows[NumFila].Cells["USUARIO_CREACION"].Value.ToString()}";
            this.accion = 2;
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtCliente.Text)))
            {
                if (this.objCN_Clientes.anular(txtCliente.Text))
                {
                    MessageBox.Show("El cliente se ha anulado exitosamente", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("El cliente no se ha anulado", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Es necesario Seleccionar un Cliente", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
