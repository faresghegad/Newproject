using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Examen3
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// fares
        [STAThread]
        static void Main()
        {
            string command = read();
            if (command == "interface")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            /*
             * code console ici
             * 
             * pour lire utiliser read() a la place de Console.ReadLine()
             * les données dans les fichers sont séparés par ¿   pour l'écrire il faut faire Alt+1704  
             * pour lire les données séparés utilisez par example: donne.Split('¿')[0];
             * données c'est le text du ficher lu et [0] c'est la position de la donnée qu'on veut généralement, il ya sulement 0, 1 et 2 .
             */
            
            while (command != "exit")
            {
                command = read();
            }
        }

        static string read()
        {
            return Console.ReadLine();
        }
    }
}
