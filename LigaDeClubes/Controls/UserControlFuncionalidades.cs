using FontAwesome.Sharp;
using LigaDeClubes.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LigaDeClubes.Controls
{
    public partial class UserControlFuncionalidades : UserControl
    {
        private Liga liga;
        private static readonly Image IconoDetalles = FormsIconHelper.ToBitmap(IconChar.InfoCircle, Color.DarkRed, 24, 0, FlipOrientation.Normal);

        public UserControlFuncionalidades(Liga liga)
        {
            InitializeComponent();
            this.liga = liga;

            selectCategoria.SelectedIndexChanged += CboFiltroEquipo_SelectedIndexChanged;
            dgvJugadoresFuncionalidades.CellContentClick += DgvJugadores_CellContentClick;
        }

        public void CargarDatos()
        {
            dgvJugadoresFuncionalidades.Columns.Clear();

            dgvJugadoresFuncionalidades.Columns.Add("Nombre", "Nombre");
            dgvJugadoresFuncionalidades.Columns.Add("Apellido", "Apellido");
            dgvJugadoresFuncionalidades.Columns.Add("Edad", "Edad");
            dgvJugadoresFuncionalidades.Columns.Add("Categoria", "Categoría");

            dgvJugadoresFuncionalidades.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvJugadoresFuncionalidades.Columns["Apellido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvJugadoresFuncionalidades.Columns["Edad"].Width = 50;
            dgvJugadoresFuncionalidades.Columns["Categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvJugadoresFuncionalidades.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Detalles",
                HeaderText = "",
                Width = 32,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

            // Cargar filtro de equipos
            selectCategoria.Items.Clear();
            selectCategoria.Items.Add("Todos");
            foreach (var e in liga.ObtenerEquipos())
            {
                selectCategoria.Items.Add(e.Nombre);
            }
            selectCategoria.SelectedIndex = 0;

            dgvJugadoresFuncionalidades.Rows.Clear();

            foreach (var j in liga.ObtenerJugadores())
            {
                dgvJugadoresFuncionalidades.Rows.Add(j.Nombre, j.Apellido, j.Edad, j.Categoria, IconoDetalles);
            }
        }

        private void CboFiltroEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvJugadoresFuncionalidades.Columns[e.ColumnIndex].Name == "Detalles")
            {

            }
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
