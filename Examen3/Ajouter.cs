using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Ajouter : Form
    {
        public Ajouter(string add)
        {
            InitializeComponent();
            type = add;
            if (add == "etudient")
            {
                label1.Text = "Numéro d'étudiant : ";
                label2.Text = "Nom : ";
                label3.Text = "Prenom : ";
            }
            else if (add == "cour")
            {
                label1.Text = "Numero de cour : ";
                label2.Text = "Code : ";
                label3.Text = "Titre : ";
            }
            else if (add == "note")
            {
                label1.Text = "Etudient : ";
                txtbox1.ReadOnly = true;
                label2.Text = "Cour : ";
                txtbox2.ReadOnly = true;
                label3.Text = "Note : ";
            }
            else { Close(); }
        }
        public string etudient = null;
        public string cour = null;
        public string numero_etudient = null;
        string type = "";
        public string N_etudient = null;
        public string N_cours = null;

        private void Ajouterbtn_Click(object sender, EventArgs e)
        {
            if (type == "etudient")
            {
                if (!Donnees.verifier_valeur(txtbox1.Text))
                {
                    MessageBox.Show("error", "Le Numéro d'étudiant est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Donnees.verifier_valeur(txtbox2.Text))
                {
                    MessageBox.Show("error", "Le Nom est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Donnees.verifier_valeur(txtbox3.Text))
                {
                    MessageBox.Show("error", "Le Prenom est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Etudiant N_etudient = new Etudiant(txtbox1.Text + "¿" + txtbox2.Text + "¿" + txtbox3.Text);
                Donnees.ajouter_etudient(N_etudient);
                this.Close();
            }
            else if (type == "cour")
            {
                if (!Donnees.verifier_valeur(txtbox1.Text))
                {
                    MessageBox.Show("error", "Le Numero de cour est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Donnees.verifier_valeur(txtbox2.Text))
                {
                    MessageBox.Show("error", "Le Code est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Donnees.verifier_valeur(txtbox3.Text))
                {
                    MessageBox.Show("error", "Le Titre est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Cour N_cour = new Cour(txtbox1.Text + "¿" + txtbox2.Text + "¿" + txtbox3.Text);
                Donnees.ajouter_Cours(N_cour, etudient);
                this.Close();
            }
            else if (type == "note")
            {
                if (!Donnees.verifier_valeur_double(txtbox3.Text))
                {
                    MessageBox.Show("error", "La Note est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Etudiant et = new Etudiant(N_etudient);
                Cour c = new Cour(N_cours);
                Donnees.ajouter_Note(new Note(et.Numero_etudiant + "¿" + c.Numero_cours + "¿" + txtbox3.Text), et.Numero_etudiant);
                this.Close();
            }
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            if (type == "note")
            {
                txtbox1.Text = N_etudient.Replace("¿", "  ");
                txtbox2.Text = N_cours.Replace("¿", "-");
            }
        }
    }
}
