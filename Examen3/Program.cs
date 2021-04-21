 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Student student = new Student();
                ClassLesson classLesson = new ClassLesson();
                ClassNote classNote = new ClassNote();
                Console.WriteLine("Bienvenue dans le système de gestion des étudiants");
                Console.WriteLine("Entrez # étudiant :");
                int studentNo;
                while(!Int32.TryParse(Console.ReadLine(),out studentNo))
                {
                    Console.WriteLine("Élève invalide #");
                    Console.WriteLine("Entrez le numéro d'étudiant:");
                }
                student.StudentNumber = studentNo;

                Console.WriteLine("Entrez le nom de famille de l'étudiant:");
                student.LastName = Console.ReadLine();

                Console.WriteLine("Entrez le prénom de l'étudiant:");
                student.FirstName = Console.ReadLine();

                Console.WriteLine("Entrer le # cours:");
                int courseno;
                while (!Int32.TryParse(Console.ReadLine(), out courseno))
                {
                    Console.WriteLine("Cours invalide #");
                    Console.WriteLine("Entrer le # cours:");
                }
                classLesson.Coursenumber = courseno;
                
                Console.WriteLine("Entrez le code du cours:");
                classLesson.Coded = Console.ReadLine();

                Console.WriteLine("Entrez le titre du cours:");
                classLesson.Title = Console.ReadLine();

                Console.WriteLine("Entrez la note de classe:");
                classNote.Note = Console.ReadLine();
                classNote.StudentNumber = student.StudentNumber;
                classNote.Coursenumber = classLesson.Coursenumber;

                string fileName = student.StudentNumber + ".txt";
                File.WriteAllText(fileName, "# Etudiant: " + student.StudentNumber +Environment.NewLine);
                File.AppendAllText(fileName, "Nom de famille de l'étudiant: " + student.LastName +Environment.NewLine);
                File.AppendAllText(fileName, "Prénom de l'étudiant: " + student.FirstName +Environment.NewLine);
                File.AppendAllText(fileName, "Cours #: " + classLesson.Coursenumber +Environment.NewLine);
                File.AppendAllText(fileName, "Code: " + classLesson.Coded +Environment.NewLine);
                File.AppendAllText(fileName, "Titre: " + classLesson.Title +Environment.NewLine);
                File.AppendAllText(fileName, "Note: " + classNote.Note +Environment.NewLine);

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
                Console.ReadKey();
            }
        }
    }
}
