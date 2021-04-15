using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Examen3
{
    class Donnees
    {
        public static List<Etudiant> list_etudients()
        {
            List<Etudiant> E_list = new List<Etudiant>();
            if (Directory.Exists("donnees"))
            {
                var list_ficher_etudient = Directory.GetDirectories("donnees");
                foreach (var F_etudient in list_ficher_etudient)
                {
                    string line = F_etudient + "\\" + F_etudient.Split('\\')[1] + ".txt";
                    var donne_etudient = File.ReadAllText(line);
                    if (donne_etudient.Split('¿').Length < 3 || donne_etudient.Split('¿').Length > 4)
                        continue;
                    try
                    {
                        if (donne_etudient.Split('¿')[0] != line.Split('\\')[2].Replace(".txt", "") || donne_etudient.Split('¿')[0] != line.Split('\\')[1])
                            continue;
                        Etudiant nouveau_e = new Etudiant(donne_etudient);
                        E_list.Add(nouveau_e);
                    }
                    catch
                    {

                    }
                }
            }
            return E_list;
        }
        public static List<Cour> list_cours(string numero_etudiant)
        {
            List<Cour> C_list = new List<Cour>();
            List<string> cours = new List<string>();
            if (File.Exists("donnees\\"+ numero_etudiant + "\\Cours.txt"))
            {
                var ficher_cours = File.ReadAllLines("donnees\\"+ numero_etudiant + "\\Cours.txt");
                foreach (var donne_cour in ficher_cours)
                {
                    if (donne_cour.Split('¿').Length < 3 || donne_cour.Split('¿').Length > 4)
                        continue;
                    if (cours.Contains(donne_cour.Split('¿')[0]+"¿"+ donne_cour.Split('¿')[1]+ "¿"+donne_cour.Split('¿')[2]))
                        continue;
                    try
                    {
                        cours.Add(donne_cour.Split('¿')[0] + "¿" + donne_cour.Split('¿')[1] + "¿" + donne_cour.Split('¿')[2]);
                        Cour nouveau_e = new Cour(donne_cour);
                        C_list.Add(nouveau_e);
                    }
                    catch
                    {

                    }
                }
            }
            return C_list;
        }
        public static List<Note> list_notes(string numero_etudiant)
        {
            List<Note> N_list = new List<Note>();
            List<string> cours = new List<string>();
            if (File.Exists("donnees\\" + numero_etudiant + "\\Notes.txt"))
            {
                var ficher_notes = File.ReadAllLines("donnees\\" + numero_etudiant + "\\Notes.txt");
                foreach (var donne_note in ficher_notes)
                {
                    if (donne_note.Split('¿').Length < 3 || donne_note.Split('¿').Length > 4)
                        continue;
                    if (donne_note.Split('¿')[0] != numero_etudiant)
                        continue;
                    if(cours.Contains(donne_note.Split('¿')[1]))
                        continue;
                    try
                    {
                        cours.Add(donne_note.Split('¿')[1]);
                        Note nouveau_e = new Note(donne_note);
                        N_list.Add(nouveau_e);
                    }
                    catch
                    {

                    }
                }
            }
            return N_list;
        }

        public static void Supprimer_Etudient(Etudiant etudiant)
        {
            string address = "donnees\\" + etudiant.Numero_etudiant;
            if (Directory.Exists(address))
                try { Directory.Delete(address, true); } catch (IOException) {System.Threading.Thread.Sleep(0); Directory.Delete(address, true); }
        }
        public static void Supprimer_Cours(Cour cour,string Numero_etudiant)
        {
            string address = "donnees\\" + Numero_etudiant + "\\Cours.txt";
            if (File.Exists(address))
                File.WriteAllText(address, File.ReadAllText(address).Replace(cour.Numero_cours + "¿" + cour.Code + "¿" + cour.Titre, ""));
        }
        public static void Supprimer_Note(Note note,string Numero_etudiant)
        {
            string address = "donnees\\" + Numero_etudiant + "\\Notes.txt";
            if (File.Exists(address))
                File.WriteAllText(address, File.ReadAllText(address).Replace(note.Numero_etudiant + "¿" + note.Numero_cours + "¿" + note.N_value, ""));
        }

        public static void update_Etudient(Etudiant etudiant, Etudiant N_etudiant)
        {
            string address = "donnees\\" + etudiant.Numero_etudiant + "\\" + etudiant.Numero_etudiant + ".txt";
            foreach (Note note in etudiant.Notes)
            {
            }
            if (File.Exists(address))
                File.WriteAllText(address, File.ReadAllText(address).Replace(etudiant.Numero_etudiant + "¿" + etudiant.Nom + "¿" +etudiant.Prenom , N_etudiant.Numero_etudiant + "¿" + N_etudiant.Nom + "¿" + N_etudiant.Prenom));
            if (N_etudiant.Numero_etudiant != etudiant.Numero_etudiant)
            {
                File.Move(address, "donnees\\" + etudiant.Numero_etudiant + "\\" + N_etudiant.Numero_etudiant + ".txt");
                Directory.Move("donnees\\" + etudiant.Numero_etudiant, "donnees\\" + N_etudiant.Numero_etudiant);
                if (File.Exists("donnees\\" + N_etudiant.Numero_etudiant + "\\Notes.txt"))
                {
                    File.WriteAllText("donnees\\" + N_etudiant.Numero_etudiant + "\\Notes.txt", File.ReadAllText("donnees\\" + N_etudiant.Numero_etudiant + "\\Notes.txt").Replace(etudiant.Numero_etudiant + "¿", N_etudiant.Numero_etudiant + "¿"));
                }
            }
        }
        public static void update_Cours(Cour cour,Cour N_cour, string Numero_etudiant)
        {
            string address = "donnees\\" + Numero_etudiant + "\\Cours.txt";
            if (File.Exists(address))
                File.WriteAllText(address, File.ReadAllText(address).Replace(cour.Numero_cours + "¿" + cour.Code + "¿" + cour.Titre, N_cour.Numero_cours + "¿" + N_cour.Code + "¿" + N_cour.Titre));
        }
        public static void update_Note(Note note, Note N_note, string Numero_etudiant)
        {
            string address = "donnees\\" + Numero_etudiant + "\\Notes.txt";
            if (File.Exists(address))
                File.WriteAllText(address, File.ReadAllText(address).Replace(note.Numero_etudiant + "¿" + note.Numero_cours + "¿" + note.N_value, N_note.Numero_etudiant + "¿" + N_note.Numero_cours + "¿" + N_note.N_value));
        }

        public static void ajouter_etudient(Etudiant etudiant) 
        {
            if (Directory.Exists("donnees\\" + etudiant.Numero_etudiant))
                Supprimer_Etudient(etudiant);
            Directory.CreateDirectory("donnees\\"+etudiant.Numero_etudiant);
            var creer = File.Create("donnees\\" + etudiant.Numero_etudiant +"\\"+ etudiant.Numero_etudiant+".txt");
            creer.Close();
            File.WriteAllText("donnees\\" + etudiant.Numero_etudiant + "\\" + etudiant.Numero_etudiant + ".txt", etudiant.Numero_etudiant+"¿"+ etudiant.Nom+"¿"+ etudiant.Prenom);
        }

        public static void ajouter_Note(Note note, string Numero_etudiant)
        {
            string address = "donnees\\" + Numero_etudiant + "\\Notes.txt";

            if (File.Exists(address))
            {
                File.WriteAllText(address, File.ReadAllText(address) + "\n" + note.Numero_etudiant + "¿" + note.Numero_cours + "¿" + note.N_value);
            }
            else 
            {
                File.WriteAllText(address, note.Numero_etudiant + "¿" + note.Numero_cours + "¿" + note.N_value);
            }
        }
        public static void ajouter_Cours(Cour cour, string Numero_etudiant)
        {
            string address = "donnees\\" + Numero_etudiant + "\\Cours.txt";
            if (File.Exists(address))
                File.WriteAllText(address, File.ReadAllText(address)+"\n"+cour.Numero_cours + "¿" + cour.Code + "¿" + cour.Titre);
            else
                File.WriteAllText(address, cour.Numero_cours + "¿" + cour.Code + "¿" + cour.Titre);
        }

        public static bool verifier_valeur(string valeur)
        {
            if (valeur.Trim() == null)
            {
                return false;
            }
            string autorisi = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_., ";
            for (int i = 0; i < valeur.Length; i++)
            {
                if (!autorisi.Contains(valeur[i].ToString().ToUpper()))
                    return false;
            }
            return true;
        }
        public static bool verifier_valeur_double(string valeur)
        {
            if (valeur.Trim() == null)
            {
                return false;
            }
            string autorisi = "0123456789.,";
            for (int i = 0; i < valeur.Length; i++)
            {
                if (!autorisi.Contains(valeur[i].ToString().ToUpper()))
                    return false;
            }
            return true;
        }

    }
}
