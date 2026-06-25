using System;
using System.Windows.Forms;
using LigaDeClubes.Services;

namespace LigaDeClubes
{
    public partial class FormMenu : Form
    {
        private Liga liga;

        public FormMenu(Liga liga)
        {
            InitializeComponent();

            this.liga = liga;

            btnEquipos.Click += btnEquipos_Click;
            btnJugadores.Click += btnJugadores_Click;
            btnPartidos.Click += btnPartidos_Click;
            btnEstadisticas.Click += btnEstadisticas_Click;
            btnReportes.Click += btnReportes_Click;
            btnFuncionalidades.Click += btnFuncionalidades_Click;
            btnInformacion.Click += btnInformacion_Click;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            // TODO: abrir formulario de equipos
            MessageBox.Show("Módulo de Equipos - próximamente");
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            // TODO
            MessageBox.Show("Módulo de Jugadores - próximamente");
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            // TODO
            MessageBox.Show("Módulo de Partidos - próximamente");
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            // TODO
            MessageBox.Show("Módulo de Estadísticas - próximamente");
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            // TODO
            MessageBox.Show("Módulo de Reportes - próximamente");
        }

        private void btnFuncionalidades_Click(object sender, EventArgs e)
        {
            // TODO
            MessageBox.Show("Funcionalidades - próximamente");
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liga Deportiva - TP2\nGrupo 33", "Información");
        }
    }
}
