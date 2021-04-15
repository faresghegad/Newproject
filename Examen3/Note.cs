using System;
using System.Collections.Generic;
using System.Text;

namespace Examen3
{
    class Note
    {
        private string numero_etudiant;
        private string numero_cours;
        private string note;

        public Note(string donnees)
        {
            Numero_etudiant = donnees.Split('¿')[0];
            Numero_cours = donnees.Split('¿')[1];
            N_value = donnees.Split('¿')[2];
        }

        public string Numero_etudiant
        {
            get { return this.numero_etudiant; }
            set { this.numero_etudiant = value; }
        }

        public string Numero_cours
        {
            get { return this.numero_cours; }
            set { this.numero_cours = value; }
        }

        public string N_value
        {
            get { return this.note; }
            set { this.note = value; }
        }

        public string ToString()
        {
            return Numero_etudiant + "¿" + Numero_cours + "¿" + N_value;
        }
    }
}