using System;

namespace LaboratorioProgra1.Laboratorio
{
    /// Esta Clase Padre tiene 4 errores lógicos
    /// debe de encontrarlos y corregirlos
    /// documente los errores encontrados y las correcciones realizadas
    /// </summary>
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                La calificación debe estar entre 0 y 10
                if (value >= 0 && value <= 10)
                {
                    calificacion = value;
                }
                else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }
            }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set
            {
                // El año de lanzamiento debe ser un valor mayor o igual a cero
                if (value >= 0 && value <2025)
                {
                    anioLanzamiento = value;
                }
                else
                {
                    Console.WriteLine("El año de lanzamiento debe ser un valor positivo");
                }
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Desarrolladora: " + Desarrolladora);
            Console.WriteLine("Calificación: " + Calificacion);
            Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
        }

        public static void Saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }

        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            // Se verifica si hay una partida en curso antes de detenerla
            if (jugando)
            {
                jugando = false;
                Console.WriteLine("Partida detenida.");
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }

        public void TerminarJuego()
        {
            // Se verifica si hay una partida en curso antes de terminar el juego
            if (jugando)
            {
                jugando = false;
                Console.WriteLine("Juego terminado.");
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }
    }
}
