using LigaDeClubes.Models;
using System;
using System.Collections.Generic;

namespace LigaDeClubes.Models
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public string Club { get; set; }
        public string Categoria { get; set; }
        public List<Jugador> Jugadores { get; set; }


        public Equipo(
            string nombre, 
            string club, 
            string categoria
        
            )
        {
            Nombre = nombre;
            Club = club;
            Categoria = categoria;
            Jugadores = new List<Jugador>();
        }

        public int ObtenerCantidadJugadores(List<Jugador> jugadores)
        {
            int contador = 0;
            foreach (var j in jugadores)
            {
                if (j.Equipos.Contains(this))
                    contador++;
            }
            return contador;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Categoria}";
        }
    }
}