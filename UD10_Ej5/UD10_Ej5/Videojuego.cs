using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej5
{
    public class Videojuego : Entregable
    {
        private string titulo;
        private float horas_est;
        private bool entregado;
        private string genero;
        private string compañia;

        public Videojuego()
        {
            titulo = "";
            horas_est = 10;
            entregado = false;
            genero = "";
            compañia = "";
        }

        public Videojuego(string titulo, float horas_est)
        {
            this.titulo = titulo;
            this.horas_est = horas_est;
            entregado = false;
            genero = "";
            compañia = "";
        }

        public Videojuego(string titulo, float horas_est, string genero, string compañia) 
        {
            this.genero = genero;
            this.compañia = compañia;
            this.titulo = titulo;
            this.horas_est = horas_est;
            entregado = false;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public float Horas_est { get => horas_est; set => horas_est = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Compañia { get => compañia; set => compañia = value; }

        public override string ToString()
        {
            return titulo.ToString() + ": " + horas_est.ToString() + ": " + genero.ToString() + ": " + compañia.ToString() + ": " + entregado.ToString();
        }
        public void Entregar()
        {
            entregado = true;
        }

        public void Devolver()
        {
            entregado = false;
        }

        public void isEntregado()
        {
            if (entregado) Console.WriteLine("La serie ha sido entregada");
            else Console.WriteLine("La serie no ha sido entregada");
        }

        public int compareTo(Object a)
        {
            return ntemporadas.CompareTo(a);
        }
    }
}
