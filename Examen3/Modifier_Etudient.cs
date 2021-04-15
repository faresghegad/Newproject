using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Modifier_Etudient : Form
    {
        public Modifier_Etudient(string etudient)
        {
            InitializeComponent();
            oldetudiant = new Etudiant(etudient);
        }

        static Etudiant oldetudiant;
        private void Ajouterbtn_Click(object sender, EventArgs e)
        {
            if (!Donnees.verifier_valeur(NEtxt.Text))
            {
                MessageBox.Show("error", "Le Numéro d'étudiant est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Donnees.verifier_valeur(Nomtxt.Text))
            {
                MessageBox.Show("error", "Le Nom est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Donnees.verifier_valeur(Prenomtxt.Text))
            {
                MessageBox.Show("error", "Le Prenom est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Etudiant N_etudient = new Etudiant(NEtxt.Text + "¿" + Nomtxt.Text + "¿" + Prenomtxt.Text);
            if (N_etudient.Numero_etudiant == oldetudiant.Numero_etudiant && N_etudient.Nom == oldetudiant.Nom && N_etudient.Prenom == oldetudiant.Prenom)
                this.Close();
            Donnees.update_Etudient(oldetudiant, N_etudient);
            this.Close();
        }

        private void Modifier_Etudient_Load(object sender, EventArgs e)
        {
            try
            {
                NEtxt.Text = oldetudiant.Numero_etudiant;
                Nomtxt.Text = oldetudiant.Nom;
                Prenomtxt.Text = oldetudiant.Prenom;
            }
            catch 
            {
                MessageBox.Show("Error","Etudient Invalid.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
