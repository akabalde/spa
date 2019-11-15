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

        private void BTN_Borrar_Click(object sender, EventArgs e)
        {
            if (DGV_Clientes.SelectedRows.Count != 0)
            {
                int ID_SelectedRow = int.Parse(DGV_Clientes.SelectedRows[0].Cells[0].Value.ToString());

                Clientes.Borrar(ID_SelectedRow);

                DGV_Clientes_Refresh();
            }

        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            if (DGV_Clientes.SelectedRows.Count != 0)
            {
                int ID_SelectedRow = int.Parse(DGV_Clientes.SelectedRows[0].Cells[0].Value.ToString());

                using (FRM_Cliente_Editar frm = new FRM_Cliente_Editar(ID_SelectedRow))
                {
                    frm.ShowDialog();
                    DGV_Clientes_Refresh();

                }

                //using (DataClasses1DataContext db = new DataClasses1DataContext())
                //{
                //    db.editarEstados(int.Parse(TXT_Editar_1.Text), TXT_Editar_3.Text);

                //    TXT_Editar_1.Text = "";
                //    TXT_Editar_2.Text = "";
                //    TXT_Editar_3.Text = "";

                //    Estados_Refresh();
                //}
            }
        }
    }
}
