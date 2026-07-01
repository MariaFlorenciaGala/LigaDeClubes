using FontAwesome.Sharp;
using LigaDeClubes.Models;
using LigaDeClubes.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LigaDeClubes.Controls
{
    public partial class UserControlEquipos : UserControl
    {
        private Liga liga;

        private static readonly Image IconoDetalles = FormsIconHelper.ToBitmap(IconChar.InfoCircle, Color.DarkRed, 24, 0, FlipOrientation.Normal);
        private static readonly Image IconoLapiz = FormsIconHelper.ToBitmap(IconChar.PencilAlt, Color.DarkRed, 24, 0, FlipOrientation.Normal);
        private static readonly Image IconoPapelera = FormsIconHelper.ToBitmap(IconChar.TrashAlt, Color.DarkRed, 24, 0, FlipOrientation.Normal);

        public UserControlEquipos(Liga liga)
        {
            InitializeComponent();
            this.liga = liga;

            dgvEquipos.CellContentClick += DgvEquipos_CellContentClick;
        }

        public void CargarDatos()
        {
            dgvEquipos.Columns.Clear();

            dgvEquipos.Columns.Add("Nombre", "Nombre");
            dgvEquipos.Columns.Add("Club", "Club");
            dgvEquipos.Columns.Add("Categoria", "Categoría");

            dgvEquipos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEquipos.Columns["Club"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEquipos.Columns["Categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Columna de imagen para detalles
            dgvEquipos.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Detalles",
                HeaderText = "",
                Width = 32,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

            // Columna de imagen para editar — cada celda va a mostrar el icono del lápiz
            dgvEquipos.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Editar",
                HeaderText = "",
                Width = 32,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

            // Columna de imagen para eliminar — cada celda muestra el tacho
            dgvEquipos.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Eliminar",
                HeaderText = "",
                Width = 32,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

            dgvEquipos.Rows.Clear();

            foreach (var e in liga.ObtenerEquipos())
            {
                // Paso los iconos como valores de las últimas dos columnas
                dgvEquipos.Rows.Add(e.Nombre, e.Club, e.Categoria, IconoDetalles, IconoLapiz, IconoPapelera);
            }

            lblTotalEquipos.Text = $"Total: {liga.ObtenerEquipos().Count} equipos";
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Title = "Importar equipos desde archivo",
                Filter = "Archivos de texto (*.txt)|*.txt"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            var lineas = System.IO.File.ReadAllLines(ofd.FileName);
            int ok = 0, error = 0;

            foreach (var linea in lineas)
            {
                var trimmed = linea.Trim();
                if (string.IsNullOrEmpty(trimmed))
                    continue;

                var partes = trimmed.Split(',');
                if (partes.Length < 2)
                {
                    error++;
                    continue;
                }

                var club = partes[0].Trim();
                var categoria = partes[1].Trim();

                if (liga.AgregarEquipo(new Equipo(club, club, categoria)))
                    ok++;
                else
                    error++;
            }

            CargarDatos();

            MessageBox.Show(
                $"Importación finalizada.\nEquipos agregados: {ok}\nErrores: {error}",
                "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void DgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var equipo = liga.ObtenerEquipos()[e.RowIndex];

            if (dgvEquipos.Columns[e.ColumnIndex].Name == "Detalles")
            {

            }
            else if (dgvEquipos.Columns[e.ColumnIndex].Name == "Editar")
            {

            }
            else if (dgvEquipos.Columns[e.ColumnIndex].Name == "Eliminar")
            {

            }
        }

    }
}
