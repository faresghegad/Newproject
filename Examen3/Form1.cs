using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Form1 : Form
    {
        List<Etudiant> Etudiants = new List<Etudiant>();
        public Form1()
        {
            InitializeComponent();
            update_form();
        }

        public void update_form()
        {
            Etudiants = null;
            listnote.Items.Clear();
            listcours.Items.Clear();
            listetudient.Items.Clear();
            Etudiants = Donnees.list_etudients();
            foreach (Etudiant nouveau_e in Etudiants)
            listetudient.Items.Add(nouveau_e.Numero_etudiant + "  " + nouveau_e.Nom + "  " + nouveau_e.Prenom);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void listetudient_SelectedIndexChanged(object sender, EventArgs e)
        {
                listnote.Items.Clear();
                listcours.Items.Clear();
            if (listetudient.SelectedIndex < 0)
                return;
                foreach (Cour cour in Etudiants[listetudient.SelectedIndex].Cours)
                {
                    listcours.Items.Add(cour.Numero_cours + "-" + cour.Code + "-" + cour.Titre);
                    foreach (Note note in Etudiants[listetudient.SelectedIndex].Notes)
                    {
                        if (note.Numero_cours == cour.Numero_cours)
                            listnote.Items.Add(note.N_value);
                    }
                }
        }

        private void listcours_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listnote.SelectedIndex = listcours.SelectedIndex;
            }
            catch { }
        }

        private void listnote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listcours.SelectedIndex = listnote.SelectedIndex;
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listnote.Items.Clear();
            listcours.Items.Clear();
            listetudient.Items.Clear();
            if (textBox1.Text == "")
            {
                foreach (Etudiant etudient in Etudiants)
                listetudient.Items.Add(etudient.Numero_etudiant + "  " + etudient.Nom + "  " + etudient.Prenom);
            }
            else
            {
                    foreach (Etudiant etudient in Etudiants)
                    { 
                        if(etudient.Numero_etudiant.ToUpper().Contains(textBox1.Text.ToUpper()) || etudient.Nom.ToUpper().Contains(textBox1.Text.ToUpper()) || etudient.Prenom.ToUpper().Contains(textBox1.Text.ToUpper()))
                        listetudient.Items.Add(etudient.Numero_etudiant + "  " + etudient.Nom + "  " + etudient.Prenom);
                }
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (listnote.SelectedIndex < 0)
                return;
            Donnees.Supprimer_Note(Etudiants[listetudient.SelectedIndex].Notes[listnote.SelectedIndex], Etudiants[listetudient.SelectedIndex].Numero_etudiant);
            update_form();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (listcours.SelectedIndex < 0)
                return;
            if (listnote.SelectedIndex >= 0)
                Donnees.Supprimer_Note(Etudiants[listetudient.SelectedIndex].Notes[listnote.SelectedIndex], Etudiants[listetudient.SelectedIndex].Numero_etudiant);
            Donnees.Supprimer_Cours(Etudiants[listetudient.SelectedIndex].Cours[listcours.SelectedIndex], Etudiants[listetudient.SelectedIndex].Numero_etudiant);
            update_form();
        }

        private void etudientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Etudient A_Etudient = new Ajouter_Etudient();
            A_Etudient.ShowDialog();
            update_form();
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Etudient A_Etudient = new Ajouter_Etudient();
            A_Etudient.ShowDialog();
            update_form();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listetudient.SelectedIndex < 0)
                return;
            Modifier_Etudient modifier = new Modifier_Etudient(Etudiants[listetudient.SelectedIndex].ToString());
            modifier.ShowDialog();
            update_form();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
