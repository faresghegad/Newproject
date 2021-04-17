﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Examen3
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string command = Console.ReadLine();
            if (command == "interface")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            while (command != "exit")
            {
                command = Console.ReadLine();
            }
        }
    }
}