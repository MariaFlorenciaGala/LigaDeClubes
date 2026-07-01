using LigaDeClubes.Models;
using System;
using System.Collections.Generic;

namespace LigaDeClubes.Services
{
    public class Liga
    {
        //Propiedades
        private List<Jugador> Jugadores { get; set; }
        private List<Equipo> Equipos { get; set; }
        private List <Torneo> Torneos { get; set; }
        
        //Constructor
        public Liga()
        {
            Jugadores = new List<Jugador>();
            Equipos = new List<Equipo>();
            Torneos = new List<Torneo>();
        }
       
        //Métodos jugador        
        public bool AgregarJugador(Jugador jugador)
        {
            foreach (var j in Jugadores)
            {
                if (j.DNI == jugador.DNI)
                {
                    return false;
                }
            }
            Jugadores.Add(jugador);
            return true;
        }
        public bool AgregarJugadorAEquipo(Jugador jugador, Equipo equipo)
        {
            if (jugador.Categoria == equipo.Categoria)
            {
                jugador.AgregarEquipo(equipo);
                equipo.Jugadores.Add(jugador);
                return true;
            }            
            return false;
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
          
        //Metodos equipo
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
        public Equipo ObtenerEquipo(int indice)
        {
            if (indice < 0 || indice >= Equipos.Count) return null;
            return Equipos[indice];
        }
        public List<Equipo> ObtenerEquipos() => Equipos;

        //Metodos torneo
        public bool AgregarTorneo(Torneo torneo)
        {
            Torneos.Add(torneo);
            return true;
        }        
        public Torneo BuscarTorneo(int idTorneo)
        {
            foreach(var torneo in Torneos)
            {
                if(torneo.IdTorneo == idTorneo)
                {
                    return torneo;
                }
            }
            return null;
        }
        public List<Torneo> ObtenerTorneos() => Torneos;

        //Metodos partido
        public bool AgregarPartido(Torneo torneo, Partido partido)
        {
            torneo.Partidos.Add(partido);
            partido.Torneo = torneo;
            return true;
        }
        public List<Partido> ObtenerPartidos(Torneo torneo) => torneo.Partidos;

        //Metodos partido jugador
        public int ObtenerGolesTotales(Jugador jugador)
        {
            int total = 0;
            foreach(var torneo in Torneos)
            {
                foreach (var partido in torneo.Partidos)
                {
                    foreach(var gol in partido.PartidoJugadores)
                    {
                        if (gol.Jugador.DNI == jugador.DNI)
                        {
                            total += gol.Goles;
                        }
                    }
                }
            }
            return total;
        }
        public int ObtenerAsistenciasTotales(Jugador jugador)
        {
            int total = 0;
            foreach (var torneo in Torneos)
            {
                foreach (var partido in torneo.Partidos)
                {
                    foreach (var asistencia in partido.PartidoJugadores)
                    {
                        if (asistencia.Jugador.DNI == jugador.DNI)
                        {
                            total += asistencia.Asistencias;
                        }
                    }
                }
            }
            return total;
        }
        public int ObtenerPartidosJugados(Jugador jugador)
        {
            int total = 0;
            foreach (var torneo in Torneos)
            {
                foreach (var partido in torneo.Partidos)
                {
                    foreach (var pj in partido.PartidoJugadores)
                    {
                        if (pj.Jugador.DNI == jugador.DNI)
                        {
                            total++;
                        }
                    }
                }
            }
            return total;
        }

        //Metodos estadisticas
        public List<Jugador> ObtenerJugadoresAfiliados()
        {
            List<Jugador> afiliados = new List<Jugador>();
            foreach(var jugador in Jugadores)
            {
                if (jugador.Afiliado)
                {
                    afiliados.Add(jugador);
                }
            }
            return afiliados;       
        }
        public List<Jugador> ObtenerJugadoresPorEquipo(Equipo equipo)
        {
            List<Jugador> jugadoresPorEquipo = new List<Jugador>();
            foreach(var jugador in Jugadores)
            {
                if (jugador.Equipos.Contains(equipo))
                {
                    jugadoresPorEquipo.Add(jugador);
                }
            }
            return jugadoresPorEquipo;
        }

        //Metodos reportes
        public int ContarJugadoresEnEquipos(Equipo equipo)
        {
            int contador = 0;
            foreach(var jugador in Jugadores)
            {
                if (jugador.Equipos.Contains(equipo))
                {
                    contador++;
                }
            }
            return contador;
        }

        public Equipo ObtenerEquipoConMasJugadores(out int cantidad)
        {
            Equipo mejor = null;
            int max = -1;
            foreach(var equipo in Equipos)
            {
                int contador = ContarJugadoresEnEquipos(equipo);
                if (contador > max)
                {
                    max = contador;
                    mejor = equipo;
                }
            }
            cantidad = max;
            return mejor;
        }

        public List<Equipo> ObtenerEquipoSinCupoMinimo()
        {
            List<Equipo> equiposSinCupoMinimo = new List<Equipo>();
            foreach (var equipo in Equipos)
            {
                int minimo = (equipo.Categoria.ToUpper() == "VETERANOS") ? 10 : 9;
                int cantidad = ContarJugadoresEnEquipos(equipo);
                if (cantidad < minimo)
                    equiposSinCupoMinimo.Add(equipo);
            }
            return equiposSinCupoMinimo;
        }

        public List<Equipo> ObtenerEquiposSinJugadores()
        {
            List<Equipo> vacios = new List<Equipo>();
            foreach (var e in Equipos)
            {
                if (ContarJugadoresEnEquipos(e) == 0)
                    vacios.Add(e);
            }
            return vacios;
        }
    }
}