using LigaDeClubes.Models;
using System;
using System.Collections.Generic;

namespace LigaDeClubes.Services
{
    public class Liga
    {
        private List<Jugador> Jugadores { get; set; }
        private List<Equipo> Equipos { get; set; }

        public Liga()
        {
            Jugadores = new List<Jugador>();
            Equipos = new List<Equipo>();
        }

       

        public bool AgregarJugador(Jugador jugador)
        {
            foreach (var j in Jugadores)
                if (j.DNI == jugador.DNI) return false;

            Jugadores.Add(jugador);
            return true;
        }

        public bool BajaJugador(int dni)
        {
            for (int i = 0; i < Jugadores.Count; i++)
            {
                if (Jugadores[i].DNI == dni)
                {
                    Jugadores.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public Jugador BuscarJugador(int dni)
        {
            foreach (var j in Jugadores)
                if (j.DNI == dni) return j;
            return null;
        }

        public List<Jugador> ObtenerJugadores()
        {
            return Jugadores;
        }

        

        public bool AgregarEquipo(Equipo equipo)
        {
            int contador = 0;

            foreach (var e in Equipos)
            {
                if (e.Club.ToUpper() == equipo.Club.ToUpper() &&
                    e.Categoria.ToUpper() == equipo.Categoria.ToUpper())
                {
                    contador++;
                }
            }

            equipo.Nombre = equipo.Club + " " + (char)('A' + contador);
            Equipos.Add(equipo);
            return true;
        }

        public bool BajaEquipo(int indice)
        {
            if (indice < 0 || indice >= Equipos.Count) return false;
            Equipo equipo = Equipos[indice];
            foreach (var j in Jugadores)
                if (j.Equipos.Contains(equipo)) return false;
            Equipos.RemoveAt(indice);
            return true;
        }

        public List<Equipo> ObtenerEquipos() => Equipos;
        public Equipo ObtenerEquipo(int indice)
        {
            if (indice < 0 || indice >= Equipos.Count) return null;
            return Equipos[indice];
        }
    }
}