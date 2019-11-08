using System;
using System.Windows.Forms;

namespace WFA_Spa
{
    public partial class FRM_Cliente : Form
    {
        public FRM_Cliente()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (FRM_Cliente_Alta frm = new FRM_Cliente_Alta())
            {
                frm.ShowDialog();
                DGV_Clientes_Refresh();

            }
        }

        private void FRM_Cliente_Load(object sender, EventArgs e)
        {
            DGV_Clientes_Refresh();

        }

        private void DGV_Clientes_Refresh()
        {
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                DGV_Clientes.DataSource = db.Clientes;
            }
        }


    }
}
