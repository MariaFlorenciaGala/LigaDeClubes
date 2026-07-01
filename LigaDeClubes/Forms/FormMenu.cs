using LigaDeClubes.Controls;
using LigaDeClubes.Services;
using LigaDeClubes.Models;
using System;
using System.Windows.Forms;


namespace LigaDeClubes
{
    public partial class     FormMenu : Form
    {
        private Liga liga;
        
        private UserControlEquipos ucEquipos;
        private UserControlInformacion ucInformacion;
        private UserControlJugadores ucJugadores;
        private UserControlFuncionalidades ucFuncionalidades;
        private UserControlPartidos ucPartidos;
        private UserControlEstadisticas ucEstadisticas;
        private UserControlReportes ucReportes;

        public FormMenu(Liga liga)
        {
            InitializeComponent();

            this.liga = liga;

            //Control de ususario para las vistas de los módulos
            //Equipos
            ucEquipos = new UserControlEquipos(liga);
            ucEquipos.CargarDatos(); 

            ucEquipos.Visible = false;
            panelContenedor.Controls.Add(ucEquipos);
            ucEquipos.Dock = DockStyle.Fill;

            //Jugadores           
            ucJugadores = new UserControlJugadores(liga);

            ucJugadores.Visible = false;
            panelContenedor.Controls.Add(ucJugadores);
            ucJugadores.Dock = DockStyle.Fill;

            //Partidos
            ucPartidos = new UserControlPartidos(liga);

            ucPartidos.Visible = false;
            panelContenedor.Controls.Add(ucPartidos);
            ucPartidos.Dock = DockStyle.Fill;

            //Estadisticas
            ucEstadisticas = new UserControlEstadisticas(liga);

            ucEstadisticas.Visible = false;
            panelContenedor.Controls.Add(ucEstadisticas);
            ucEstadisticas.Dock = DockStyle.Fill;

            //Funcionalidades
            ucFuncionalidades = new UserControlFuncionalidades(liga);
            ucFuncionalidades.CargarDatos();

            ucFuncionalidades.Visible = false;
            panelContenedor.Controls.Add(ucFuncionalidades);
            ucFuncionalidades.Dock = DockStyle.Fill;

            //Reportes     
            ucReportes = new UserControlReportes(liga);

            ucReportes.Visible = false;
            panelContenedor.Controls.Add(ucReportes);
            ucReportes.Dock = DockStyle.Fill;

            //Información
            ucInformacion = new UserControlInformacion();
            ucInformacion.Visible = false;
            panelContenedor.Controls.Add(ucInformacion);
            ucInformacion.Dock = DockStyle.Fill;

            //Eventos de los botones
            btnEquipos.Click += btnEquipos_Click;
            btnJugadores.Click += btnJugadores_Click;
            btnPartidos.Click += btnPartidos_Click;
            btnEstadisticas.Click += btnEstadisticas_Click;
            btnReportes.Click += btnReportes_Click;
            btnFuncionalidades.Click += btnFuncionalidades_Click;
            btnInformacion.Click += btnInformacion_Click;

            System.Diagnostics.Debug.WriteLine($"panelContenedor: {panelContenedor.Size}");
            System.Diagnostics.Debug.WriteLine($"ucEquipos: {ucEquipos.Size}");
        }
        private void OcultarTodos()
        {
            ucEquipos.Visible = false;
            ucInformacion.Visible = false;
            ucJugadores.Visible = false;
            ucPartidos.Visible = false;
            ucEstadisticas.Visible = false;
            ucReportes.Visible = false;
            ucFuncionalidades.Visible = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            OcultarTodos();
            ucEquipos.Visible = true;
            ucEquipos.BringToFront();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            OcultarTodos();
            ucJugadores.Visible = true;
            ucJugadores.BringToFront();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            OcultarTodos();
            ucPartidos.Visible = true;
            ucPartidos.BringToFront();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            OcultarTodos();
            ucEstadisticas.Visible = true;
            ucEstadisticas.BringToFront();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OcultarTodos();
            ucReportes.Visible = true;
            ucReportes.BringToFront();
        }        

        private void btnFuncionalidades_Click(object sender, EventArgs e)
        {
            OcultarTodos();
            ucFuncionalidades.Visible = true;
            ucFuncionalidades.BringToFront();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            OcultarTodos();
            ucInformacion.Visible = true;
            ucInformacion.BringToFront();
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
