using System;
using System.Windows.Forms;

namespace WFA_Spa
{
    public partial class FRM_Turno_Alta : Form
    {
        public FRM_Turno_Alta()
        {
            InitializeComponent();
        }

        private void FRM_Turno_Alta_Load(object sender, EventArgs e)
        {
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                CBX_Cliente.DataSource = null;
                CBX_Cliente.DisplayMember = "Cliente";
                CBX_Cliente.DataSource = db.View_Clientes;

                CBX_Tratamiento.DataSource = null;
                CBX_Tratamiento.DisplayMember = "Nombre";
                CBX_Tratamiento.DataSource = db.Tratamientos;
            }

            DTP_Turno.MinDate = DateTime.Now;
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            int Id_Cliente = ((View_Cliente)CBX_Cliente.SelectedItem).Id;

            int Id_Tratamiento = ((Tratamiento)CBX_Tratamiento.SelectedItem).Id;

            DateTime Fecha_Hora = DTP_Turno.Value;

            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                db.SP_Turno_Agregar(Id_Cliente, Id_Tratamiento, Fecha_Hora);
            }

            this.Close();

            //TXTModelo.Text = TXTModelo.Text.Trim();

            //if (Agregar(TXTModelo.Text))
            //{
            //    ToolTipAgregado.Show
            //       (
            //           String.Concat("Se agregó el modelo => ",
            //           TXTModelo.Text),
            //           TXTModelo, -30, 30, 3000
            //       );

            //    TXTModelo.Text = "";
            //}
            //else
            //{
            //    TXTModelo.Text = "";
            //}
        }
    }
}
