using System;
using System.Collections.Generic;
using LigaDeClubes.Models;

namespace LigaDeClubes.Models
{
    public class Jugador
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Seguro { get; set; }
        public bool Afiliado { get; set; }
        public List<Equipo> Equipos { get; set; }

        public string Categoria => ClasificarCategoria(Edad);

        public Jugador(
            int dni, 
            string nombre, 
            string apellido, 
            int edad,                       
            bool seguro, 
            bool afiliado)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Seguro = seguro;
            Afiliado = afiliado;
            Equipos = new List<Equipo>();
        }

        public void AgregarEquipo(Equipo equipo)
        {
            if(this.Categoria == equipo.Categoria)
            {
                Equipos.Add(equipo);
            }
        }

        public void Mostrar()
        {
            Console.WriteLine($"{DNI} - {Nombre} {Apellido} - {Categoria}");
        }

        private static string ClasificarCategoria(int edad)
        {
            if (edad < 13) return "Infantiles";
            if (edad <= 16) return "Cadetes";
            if (edad < 18) return "Juveniles";
            if (edad < 35) return "Primera";
            return "Veteranos";
        }
    }
}