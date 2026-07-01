using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeClubes.Models
{
    public class Partido
    {
        public int IdPartido { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int GolesEquipo1 { get; set; }
        public int GolesEquipo2 { get; set; }
        public string Lugar { get; set; }
        public Equipo Equipo1 { get; set; }
        public Equipo Equipo2 { get; set; }
        public Torneo Torneo { get; set; }
        public List<PartidoJugador> PartidoJugadores { get; set; }



        public Partido(
            int idPartido,
            string fecha,
            string hora,
            int golesEquipo1,
            int golesEquipo2,
            string lugar,
            Equipo equipo1,
            Equipo equipo2,
            Torneo torneo
            )
        {
            IdPartido = idPartido;
            Fecha = fecha;
            Hora = hora;
            GolesEquipo1 = golesEquipo1;
            GolesEquipo2 = golesEquipo2;
            Lugar = lugar;
            Equipo1 = equipo1;
            Equipo2 = equipo2;
            Torneo = torneo;
            PartidoJugadores = new List<PartidoJugador>();
        }
    }
}
