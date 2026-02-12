using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservasLaboratorios
{
    public partial class FrmReservas : Form
    {
        Reserve reserve = new Reserve();
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fecha_Click(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

            Reserve reserve = new Reserve();
            reserve.Laboratory = txtb_laboratory.Text;
            reserve.Name = txtb_name.Text;
            reserve.Date_start = dtpDatestart.Value;
            reserve.Date_end = dtpDateEnd.Value;

            int? idLab = CrudReservations.verificationAvailableReserve(reserve);

            if (idLab == null)
            {
                MessageBox.Show("El laboratorio no existe.");
            }
            else if (idLab == -1)
            {
                MessageBox.Show("El laboratorio no está disponible, elige otro.");
            }
            else
            {
                CrudReservations.CreateUserAndReservation(reserve, idLab.Value);
                MessageBox.Show("Reserva creada correctamente.");
            }


        }

        private void cmbLaboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btlist_Click(object sender, EventArgs e)
        {
            refreshlist();
        }

        private void refreshlist()
        {
            dgvReservations.DataSource = CrudReservations.ListarLaboratorios();
        }
    }
}
