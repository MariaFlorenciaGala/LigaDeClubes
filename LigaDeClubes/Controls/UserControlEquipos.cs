using LigaDeClubes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaDeClubes.Controls
{
    public partial class UserControlEquipos : UserControl
    {
        private Liga liga;

        public UserControlEquipos(Liga liga)
        {
            InitializeComponent();
            this.liga = liga;
        }

        public void CargarDatos()
        {
            dgvEquipos.Columns.Clear();
            dgvEquipos.Columns.Add("Nombre", "Nombre");
            dgvEquipos.Columns.Add("Club", "Club");
            dgvEquipos.Columns.Add("Categoria", "Categoría");

            dgvEquipos.Rows.Clear();

            foreach (var e in liga.ObtenerEquipos())
            {
                dgvEquipos.Rows.Add(e.Nombre, e.Club, e.Categoria);
            }

            lblTotalEquipos.Text = $"Total: {liga.ObtenerEquipos().Count} equipos";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
