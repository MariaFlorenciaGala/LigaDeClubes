using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeClubes.Models
{
    public class PartidoJugador
    {
        public bool EsLocal { get; set; }
        public bool EsTitular { get; set; }
        public bool EsArquero { get; set; }
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int GolesRecibidos { get; set; }
        public Jugador Jugador { get; set; }
        public Partido Partido { get; set; }


        public PartidoJugador(
            bool esLocal,
            bool esTitular,
            bool esArquero,
            int goles,
            int asistencias,
            int golesRecibidos,
            Jugador jugador,
            Partido partido
            )
        {
            EsLocal = esLocal;
            EsTitular = esTitular;
            EsArquero = esArquero;
            Goles = goles;
            Asistencias = asistencias;
            GolesRecibidos = golesRecibidos;
            Jugador = jugador;
            Partido = partido;
        }
    }
}
