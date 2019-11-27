using System;
using System.Windows.Forms;
using CL_Spa;

namespace WFA_Spa
{
    public partial class FRM_Cliente_Editar : Form
    {
        private readonly int iD_SelectedRow;
        private string AUX_DNI;
        private Cliente cliente = null;

        public FRM_Cliente_Editar(int iD_SelectedRow)
        {
            InitializeComponent();

            this.iD_SelectedRow = iD_SelectedRow;
        }

        private void FRM_Cliente_Editar_Load(object sender, EventArgs e)
        {
            cliente = FillForm();
            AUX_DNI = TXT_DNI.Text;
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
            if (DatosValidos())
            {
                Clientes.Editar(cliente.Id, 
                                TXT_Nombre.Text, 
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
            if (errorProvider1.GetError(TXT_DNI)!="")
            {
                return false;
            }

            if (TXT_Nombre.Text.Length > 0 &&
               TXT_Apellido.Text.Length > 0 &&
               TXT_DNI.Text.Length > 0 &&
               TXT_Email.Text.Length > 0) return true;
            else
                return false;
        }

        private void TXT_DNI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TXT_DNI.Text != AUX_DNI)
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
            else
                errorProvider1.SetError(TXT_DNI, "");

        }
    }
}
