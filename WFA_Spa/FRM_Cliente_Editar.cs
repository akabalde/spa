using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Spa
{
    public partial class FRM_Cliente_Editar : Form
    {
        private readonly int iD_SelectedRow;
        private Cliente cliente = null;

        public FRM_Cliente_Editar(int iD_SelectedRow)
        {
            InitializeComponent();

            this.iD_SelectedRow = iD_SelectedRow;
        }

        private void FRM_Cliente_Editar_Load(object sender, EventArgs e)
        {
            cliente = FillForm();
        }
        
        private Cliente FillForm()
        {
            Cliente cliente = Clientes.Buscar(iD_SelectedRow);

            TXT_Nombre.Text = cliente.Nombre;
            TXT_Apellido.Text = cliente.Apellido;
            TXT_DNI.Text = cliente.DNI.ToString();
            TXT_Email.Text = cliente.Email;

            return cliente;
        }
        
        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            Clientes.Editar(cliente.Id, TXT_Nombre.Text, TXT_Apellido.Text,
                TXT_DNI.Text, TXT_Email.Text);

            this.Close();
        }

        
    }
}
