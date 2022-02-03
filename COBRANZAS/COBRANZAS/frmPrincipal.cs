using MaterialSkin;
using MaterialSkin.Controls;
using System;
using COBRANZAS.CLIENTES;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBRANZAS
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.BlueGrey300, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes objClientes = new frmClientes();
            objClientes.Show();
        }

        
    }
}
