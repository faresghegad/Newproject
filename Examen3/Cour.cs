using System;
using System.Collections.Generic;
using System.Text;

namespace Examen3
{
    class Cour
    {
        private string numero_cours;
        private string code;
        private string titre;

        public Cour(string donnees)
        {
            numero_cours = donnees.Split('¿')[0];
            code = donnees.Split('¿')[1];
            titre = donnees.Split('¿')[2];
        }

        public string Numero_cours
        {
            get { return this.numero_cours; }
            set { this.numero_cours = value; }
        }
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }
        public string Titre
        {
            get { return this.titre; }
            set { this.titre = value; }
        }

        public string ToString() 
        {
            return Numero_cours + "¿" + Code + "¿" + Titre;
        }
    }
}