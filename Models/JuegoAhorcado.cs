using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP04.Models
{
    public static class JuegoAhorcado
    {
        public static List<string> ListaPalabras { get; private set; }
        public static string PalabraAdivinar { get; private set; }
        public static List<char> ListaLetrasIntentadas { get; private set; }
        public static int Contador { get; private set; }
        


        public static void ComenzarJuego()
        {
            ListaLetrasIntentadas = new List<char>();
            Contador = 0;
            ListaPalabras = new List<string> { "Escribo", "Estrella", "Brillante", "Onda", "Playa", "Color", "Rojo", "Feliz", "Sueño" };
            Random random = new Random();
            PalabraAdivinar = ListaPalabras[random.Next(0, ListaPalabras.Count)];

        }


        public static string ProbarLetra(char letraIngresada)
        {
            char letra = char.ToUpper(letraIngresada);
             if (ListaLetrasIntentadas.Contains(letraIngresada))
            {
            
            return AdivinarPalabra();
            }
             ListaLetrasIntentadas.Add(letraIngresada);


        if (!PalabraAdivinar.Contains(letraIngresada))
        {
            Contador--; 
        }

        return AdivinarPalabra();
    }

        public static bool ProbarPalabra(string palabraIntentada)
        {
            if (palabraIntentada == PalabraAdivinar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static string AdivinarPalabra()
        {
            string PalabraQueSeVe = "";
            foreach (char letra in PalabraAdivinar)
            {
                if (ListaLetrasIntentadas.Contains(letra))
                {
                    PalabraQueSeVe += letra;
                }
                else
                {
                    PalabraQueSeVe += "_";
                }
            }
            return PalabraQueSeVe;
        }
    }
}
