using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeClubes.Models
{
    public class Torneo
    {
        public int IdTorneo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public List<Partido> Partidos { get; set; }


        public Torneo(
            int idTorneo,
            string nombre,
            string categoria
            )
        {
            IdTorneo = idTorneo;
            Nombre = nombre;
            Categoria = categoria;
            Partidos = new List<Partido>();
        }
    }

}
