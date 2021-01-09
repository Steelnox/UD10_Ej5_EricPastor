using System;

namespace UD10_Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie[] array_serie = new Serie[5];
            Videojuego[] array_videojuego = new Videojuego[5];

            int contador_entrega = 0;
            int max = 0;
            int posicion = 0;

            array_serie[0] = new Serie("Kimetsu no Yaiba", 1, "Accion", "Koyoharu");
            array_serie[1] = new Serie("Code Geass", "Ichiro");
            array_serie[2] = new Serie("One Piece", "Eichiro Oda");
            array_serie[3] = new Serie("Dragon Ball", 4, "Pelea", "Akira Toriyama");
            array_serie[4] = new Serie("Durarara", "Ryohgo Narita");

            array_videojuego[0] = new Videojuego("Dark Souls", 40);
            array_videojuego[1] = new Videojuego("The Surge", 50, "RPG", "Deck 13");
            array_videojuego[2] = new Videojuego("Fifa 2021", 100, "Deportes", "EA");
            array_videojuego[3] = new Videojuego("World of Warcraft", 10000, "MMORPG", "Blizzard");
            array_videojuego[4] = new Videojuego("The Binding of Isaac", 500);

            array_serie[0].Entregar();
            array_serie[2].Entregar();
            array_serie[3].Entregar();

            array_videojuego[1].Entregar();
            array_videojuego[4].Entregar();

            for (int i = 0; i < array_serie.Length; i++)
            {
                if(array_serie[i].isEntregado())
                {
                    contador_entrega++;
                    array_serie[i].Devolver();
                }
            }

            Console.WriteLine("Hay {0} series entregadas", contador_entrega);
            contador_entrega = 0;

            for (int i = 0; i < array_videojuego.Length; i++)
            {
                if (array_videojuego[i].isEntregado())
                {
                    contador_entrega++;
                    array_videojuego[i].Devolver();
                }
            }

            Console.WriteLine("Hay {0} videojuegos entregados", contador_entrega);

            for (int i = 0; i < array_serie.Length; i++)
            {
                
                if(array_serie[i].Ntemporadas > max)
                {
                    max = array_serie[i].Ntemporadas;
                    posicion = i;
                }
            }

            Console.WriteLine("La serie con mas temporadas es {0}", array_serie[posicion].Titulo);

            max = 0;
            posicion = 0;

            for (int i = 0; i < array_videojuego.Length; i++)
            {
                if (array_videojuego[i].Horas_est > max)
                {
                    max = (int)array_videojuego[i].Horas_est;
                    posicion = i;
                }
            }

            Console.WriteLine("El videojuego con mas horas estimadas es {0}", array_videojuego[posicion].Titulo);

        }
    }
}
