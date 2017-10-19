using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.StrukturaPrograma
{
    /// <summary>
    /// primjer za predavanje
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kvadrat(5));
            Console.WriteLine(DuljinaDvijeRiječi("dva", "2"));
        }

        /// <summary>
        ///   Izračunava kvadrat broja.
        /// </summary>
        /// <param name="broj">
        ///   Broj čiji kvadrat treba izračunati.
        /// </param>
        /// <returns>
        ///   Zadani broj na kvadrat, tipa <c>double</c>.
        /// </returns>
        static double Kvadrat(double broj)
        {
            return broj * broj;
        }

        /// <summary>
        /// izracun duljine rijeci
        /// </summary>
        /// <param name="prva">prva rijec</param>
        /// <param name="druga">druga rijec</param>
        /// <returns>returns static integer value</returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return (prva + druga).Length;
        }
    }
}
