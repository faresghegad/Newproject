using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

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
            Console.WriteLine("pour une interface graphique fait : 'interface'\npour console appuyez sur n'importe quelle touche");
            string command = Console.ReadLine();
            if (command == "interface")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            /*
             * code console ici
             */
            /* pour lire utiliser read() a la place de Console.ReadLine()
             * les donne dans les ficher sont séparés par ¿ pour l'ecrire il faut faire Alt+1704  
             * pour lire les donne séparés utiliser par example: donne.Split('¿')[0];
             * donne c'est le text du ficher lu et [0] c'est la position de la donne que on veut generalement il ya sulement 0,1 et 2 
            */
            while (true)
            {
                Etudiant student = new Etudiant();
                Cour classLesson = new Cour();
                Note classNote = new Note();
                Console.WriteLine("Bienvenue dans le système de gestion des étudiants");
                Console.WriteLine("Entrez # étudiant :");
                int studentNo;
                while (!Int32.TryParse(Console.ReadLine(), out studentNo))
                {
                    Console.WriteLine("Élève invalide #");
                    Console.WriteLine("Entrez le numéro d'étudiant:");
                }
                student.Numero_etudiant = studentNo.ToString();

                Console.WriteLine("Entrez le nom de famille de l'étudiant:");
                student.Nom = Console.ReadLine();

                Console.WriteLine("Entrez le prénom de l'étudiant:");
                student.Prenom = Console.ReadLine();

                Console.WriteLine("Entrer le # cours:");
                int courseno;
                while (!Int32.TryParse(Console.ReadLine(), out courseno))
                {
                    Console.WriteLine("Cours invalide #");
                    Console.WriteLine("Entrer le # cours:");
                }
                classLesson.Numero_cours = courseno.ToString();

                Console.WriteLine("Entrez le code du cours:");
                classLesson.Code = Console.ReadLine();

                Console.WriteLine("Entrez le titre du cours:");
                classLesson.Titre = Console.ReadLine();

                Console.WriteLine("Entrez la note de classe:");
                classNote.Numero_cours = Console.ReadLine();
                classNote.Numero_etudiant = student.Numero_etudiant;
                classNote.N_value = classLesson.Numero_cours;

                string fileName = student.Numero_etudiant + ".txt";
                File.WriteAllText(fileName, "# Etudiant: " + student.Numero_etudiant + Environment.NewLine);
                File.AppendAllText(fileName, "Nom de famille de l'étudiant: " + student.Nom + Environment.NewLine);
                File.AppendAllText(fileName, "Prénom de l'étudiant: " + student.Prenom + Environment.NewLine);
                File.AppendAllText(fileName, "Cours #: " + classLesson.Numero_cours + Environment.NewLine);
                File.AppendAllText(fileName, "Code: " + classLesson.Code + Environment.NewLine);
                File.AppendAllText(fileName, "Titre: " + classLesson.Titre + Environment.NewLine);
                File.AppendAllText(fileName, "Note: " + classNote.N_value + Environment.NewLine);

                Console.WriteLine("Voila l'information de l'etudiant");
                string[] Lists = File.ReadAllLines(fileName);
                foreach (var item in Lists)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Appuyez sur n'importe quelle touche pour continuer...");
                Console.WriteLine("E ou C pour quitter.");
                char exit = Convert.ToChar(Console.ReadKey().KeyChar);
                if (exit == 'e' || exit == 'E' || exit == 'c' || exit == 'C')
                {
                    return;
                }
            }

            /*
             * fin du code console 
             */
        }
    }
}
