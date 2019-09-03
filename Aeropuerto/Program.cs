using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeropuerto.Clases;

namespace Aeropuerto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BD.LEncargados.Add(new Encargado("viviana@gmail.com","viviana","jeldres",DateTime.Now,"1234"));
            BD.LEncargados.Add(new Encargado("ana@gmail.com","ana", "vega", DateTime.Now, "1564"));
            BD.LEncargados.Add(new Encargado("maria@gmail.com","maria","gonzalez", DateTime.Now, "5634"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistroEncargados());
            

            

        }
    }
}
