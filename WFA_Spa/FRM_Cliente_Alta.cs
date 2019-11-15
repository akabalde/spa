using System;
using System.Windows.Forms;

namespace WFA_Spa
{
    public partial class FRM_Cliente_Alta : Form
    {
        public FRM_Cliente_Alta()
        {
            InitializeComponent();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                Clientes.Agregar(TXT_Nombre.Text,
                                 TXT_Apellido.Text,
                                 TXT_DNI.Text,
                                 TXT_Email.Text);            
                
                Clean();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos!", "Info", 0, MessageBoxIcon.Information);
            }

        }

        private bool DatosValidos()
        {
            if (TXT_Nombre.Text == "" ||
                TXT_Apellido.Text == "" ||
                TXT_DNI.Text == "" ||
                TXT_Email.Text == "") return false;
            else
                return true;
            
            //if (TXT_Nombre.Text.Length > 0 ||
            //   TXT_Apellido.Text.Length > 0 ||
            //   TXT_DNI.Text.Length > 0 ||
            //   TXT_Email.Text.Length > 0) return true;
            //else
            //    return false;
        }

        private void Clean()
        {
            TXT_Nombre.Text = "";
            TXT_Apellido.Text = "";
            TXT_DNI.Text = "";
            TXT_Email.Text = "";
        }
    }
}
