using System;
using System.Windows.Forms;
using CL_Spa;

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
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Hay errores en el formulario!",
                                "Info", 0, MessageBoxIcon.Information);
            }

        }

        private bool DatosValidos()
        {
            if (errorProvider1.GetError(TXT_DNI) != "")
            {
                return false;
            }

            //if (!long.TryParse(TXT_DNI.Text, out _))
            //{
            //    return false;
            //}

            if (TXT_Nombre.Text.Length > 0 &&
               TXT_Apellido.Text.Length > 0 &&
               TXT_DNI.Text.Length > 0 &&
               TXT_Email.Text.Length > 0) return true;
            else
                return false;
        }

        private void TXT_DNI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                long x = long.Parse(TXT_DNI.Text);
                errorProvider1.SetError(TXT_DNI, "1");
            }
            catch (Exception)
            {
                errorProvider1.SetError(TXT_DNI, "DNI debe contener solo números");
            }

            if (errorProvider1.GetError(TXT_DNI) == "1")
            {
                try
                {
                    if (!Clientes.ExisteCliente(long.Parse(TXT_DNI.Text)))
                    {
                        errorProvider1.SetError(TXT_DNI, "");
                    }
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                    errorProvider1.SetError(TXT_DNI, "Ya existe un cliente con este DNI");
                }
            }

        }

        //private void Clean()
        //{
        //    TXT_Nombre.Text = "";
        //    TXT_Apellido.Text = "";
        //    TXT_DNI.Text = "";
        //    TXT_Email.Text = "";
        //}
    }
}
