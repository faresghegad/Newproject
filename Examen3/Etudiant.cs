using System;
using System.Collections.Generic;
using System.Text;

namespace Examen3
{
    class Etudiant
    {
        private string numero_etudiant;
        private string nom;
        private string prenom;
        public List<Cour> Cours = new List<Cour>();
        public List<Note> Notes = new List<Note>();
        public Etudiant()
        {
        }
        public Etudiant(string donnees)
        {
            Numero_etudiant =donnees.Split('¿')[0];
            Nom = donnees.Split('¿')[1];
            Prenom = donnees.Split('¿')[2];
            Cours = Donnees.list_cours(Numero_etudiant);
            Notes = Donnees.list_notes(Numero_etudiant);
        }

        public string Numero_etudiant
        {
            get { return this.numero_etudiant; }
            set { this.numero_etudiant = value; }
        }
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public string ToString()
        {
            return numero_etudiant + "¿" + nom + "¿" + prenom;
        }

    }
}