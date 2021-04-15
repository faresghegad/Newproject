using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Ajouter_Note : Form
    {
        public Ajouter_Note(string etudient, string cour)
        {
            InitializeComponent();
            N_etudient = etudient;
            N_cours = cour;
            Etxt.Text = etudient.Replace("¿", "  ");
            Ctxt.Text = cour.Replace("¿","-");

        }
        string N_etudient = null;
        string N_cours = null;
        private void Ajouterbtn_Click(object sender, EventArgs e)
        {
            if (!Donnees.verifier_valeur_double(Ntxt.Text))
            {
                MessageBox.Show("error", "La Note est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Etudiant et = new Etudiant(N_etudient);
            Cour c = new Cour(N_cours);
            Donnees.ajouter_Note(new Note(et.Numero_etudiant + "¿" + c.Numero_cours + "¿" + Ntxt.Text), et.Numero_etudiant);
            this.Close();
        }
    }
}
