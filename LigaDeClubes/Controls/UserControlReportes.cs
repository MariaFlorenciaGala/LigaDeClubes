using LigaDeClubes.Services;
using System;
using System.Windows.Forms;

namespace LigaDeClubes.Controls
{
    public partial class UserControlReportes : UserControl
    {
        private Liga liga;

        private readonly string[] reportes = {
            "Ranking de goleadores",
            "Ranking de asistencias",
            "Cantidad de jugadores por equipo",
            "Equipo con mayor cantidad de jugadores",
            "Equipos que no alcanzan el cupo mínimo",
            "Equipos sin jugadores",
            "Equipos registrados",
            "Jugadores registrados"
        };

        public UserControlReportes(Liga liga)
        {
            InitializeComponent();
            this.liga = liga;

            for (int i = 0; i < 8; i++)
            {
                Wires(Controls.Find($"btnVer{i}", true)[0] as Button, i);
                Wires(Controls.Find($"btnDescargar{i}", true)[0] as Button, i);
            }
        }

        private void Wires(Button btn, int indice)
        {
            var tag = btn.Tag as int? ?? -1;
            btn.Tag = indice;

            if (btn.Name.StartsWith("btnVer"))
                btn.Click += BtnVer_Click;
            else
                btn.Click += BtnDescargar_Click;
        }

        private string GenerarReporte(int indice)
        {
            switch (indice)
            {
                case 0: return "Ranking de goleadores\n(pendiente)";
                case 1: return "Ranking de asistencias\n(pendiente)";
                case 2: return "Cantidad de jugadores por equipo\n(pendiente)";
                case 3: return "Equipo con mayor cantidad de jugadores\n(pendiente)";
                case 4: return "Equipos que no alcanzan el cupo mínimo\n(pendiente)";
                case 5: return "Equipos sin jugadores\n(pendiente)";
                case 6: return $"Equipos registrados: {liga.ObtenerEquipos().Count}\n(pendiente)";
                case 7: return $"Jugadores registrados: {liga.ObtenerJugadores().Count}\n(pendiente)";
                default: return "";
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int indice)
            {
                var contenido = GenerarReporte(indice);
                MessageBox.Show(contenido, reportes[indice], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int indice)
            {
                var sfd = new SaveFileDialog
                {
                    Title = $"Descargar {reportes[indice]}",
                    Filter = "Archivo de texto (*.txt)|*.txt",
                    FileName = $"{reportes[indice].Replace(' ', '_')}.txt"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var contenido = GenerarReporte(indice);
                    System.IO.File.WriteAllText(sfd.FileName, contenido);
                    MessageBox.Show("Reporte descargado correctamente.", "Descarga completa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
