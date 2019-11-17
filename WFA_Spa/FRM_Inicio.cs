using System;
using System.Windows.Forms;

namespace WFA_Spa
{
    public partial class FRM_Inicio : Form
    {
        public FRM_Inicio()
        {
            InitializeComponent();
        }

        private void FRM_Inicio_Load(object sender, EventArgs e)
        {
            DGV_Turnos_Refresh();            
            SetFormatting();

        }

        private void SetFormatting()
        {
            DGV_Turnos.DefaultCellStyle.NullValue = " - - - ";
        }

        private void DGV_Turnos_Refresh()
        {
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                DGV_Turnos.DataSource = db.View_Turnos;
            }
        }

        private void BTN_Turnos_Agregar_Click(object sender, EventArgs e)
        {
            using (FRM_Turno_Alta frm = new FRM_Turno_Alta())
            {
                frm.ShowDialog();
                DGV_Turnos_Refresh();
            }
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FRM_Cliente frm = new FRM_Cliente())
            {
                frm.ShowDialog();
            }
        }
    }
}
