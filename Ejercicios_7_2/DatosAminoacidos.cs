using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_7_2
{
    public class DatosAminoacidos
    {
        //Es una clase que solamente contiene enumeraciones, listas y diccionarios, donde se pueden encontrar todos los datos anteriores para que los puedan utilizar las demás clases.


        //En una molécula de ADN hay una o varias proteínas codificadas(normalmente son muchísimas). Cada proteína empieza con el codón START y termina con uno de los codones STOP.

        //Una proteína es una cadena de aminoácidos cuyo orden viene determinado por la secuencia de C, G, T y A de la hebra de ADN.


        public enum TipoAminoacido
        {
            Alanina, Arginina, Asparagina, Acido_aspartico, Cisteina, Glutamina, Acido_glutamico, Glicina, Histidina,
            Isoleucina, Leucina, Lisina, Metionina, Fenilalanina, Prolina, Serina, Treonina, Triptofano, Tirosina, Valina
        }

        public static Dictionary<TipoAminoacido, string> nombreAminoacidos = new Dictionary<TipoAminoacido, string>
        {
            {TipoAminoacido. Alanina, "Alanina" },
            {TipoAminoacido. Arginina, "Arginina" },
            {TipoAminoacido. Asparagina, "Asparagina" },
            {TipoAminoacido. Acido_aspartico, "Acido_aspartico" },
            {TipoAminoacido. Acido_glutamico, "Acido_glutamico" },
            {TipoAminoacido. Glutamina, "Glutamina" },
            {TipoAminoacido. Glicina, "Glicina" },
            {TipoAminoacido. Histidina, "Histidina" },
            {TipoAminoacido. Isoleucina, "Isoleucina" },
            {TipoAminoacido. Leucina, "Leucina" },
            {TipoAminoacido. Lisina, "Lisina" },
            {TipoAminoacido. Metionina, "Metionina" },
            {TipoAminoacido. Fenilalanina, "Fenilalanina" },
            {TipoAminoacido. Prolina, "Prolina" },
            {TipoAminoacido. Serina, "Serina" },
            {TipoAminoacido. Treonina, "Treonina" },
            {TipoAminoacido. Triptofano, "Triptofano" },
            {TipoAminoacido. Tirosina, "Tirosina" },
            {TipoAminoacido. Valina, "Valina" },
        };








































        /*
        public static string ObtenerNombreAminoacido(TipoAminoacido tipo)
        {
            if (nombreAminoacidos.ContainsKey(tipo))
                return nombreAminoacidos[tipo];
            else
                throw new ArgumentException("El tipo de aminoácido no es válido.");
        }
        */
    }
}
