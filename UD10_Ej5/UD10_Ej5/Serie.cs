using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej5
{
    public class Serie
    {
        private string titulo;
        private int ntemporadas;
        private bool entregado;
        private string genero;
        private string creador;

        public Serie()
        {
            titulo = "";
            ntemporadas = 3;
            entregado = false;
            genero = "";
            creador = "";
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
            ntemporadas = 3;
            entregado = false;
            genero = "";
        }

        public Serie(string titulo, int ntemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.ntemporadas = ntemporadas;
            this.genero = genero;
            this.creador = creador;
            entregado = false;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Ntemporadas { get => ntemporadas; set => ntemporadas = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Creador { get => creador; set => creador = value; }

        public override string ToString()
        {
            return titulo.ToString() + ": " + ntemporadas.ToString() + ": " + genero.ToString() + ": " + creador.ToString() + ": " + entregado.ToString() ;
        }
    }
}
