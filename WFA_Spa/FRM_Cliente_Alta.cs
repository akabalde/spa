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
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                db.SP_Cliente_Agregar(TXT_Nombre.Text, TXT_Apellido.Text, TXT_DNI.Text, TXT_Email.Text);
                
                TXT_Nombre.Text = "";
                TXT_Apellido.Text = "";
                TXT_DNI.Text = "";
                TXT_Email.Text = "";

            }
        }
    }
}
