using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Ajouter_Etudient : Form
    {
        public Ajouter_Etudient()
        {
            InitializeComponent();
        }

        private void Ajouter_Etudient_Load(object sender, EventArgs e)
        {

        }

        private void Ajouterbtn_Click(object sender, EventArgs e)
        {
            if (!Donnees.verifier_valeur(NEtxt.Text))
            {
                MessageBox.Show("error", "Le Numéro d'étudiant est incorrect.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            Etudiant N_etudient = new Etudiant(NEtxt.Text+"¿"+ Nomtxt.Text+"¿"+ Prenomtxt.Text);
            Donnees.ajouter_etudient(N_etudient);
            this.Close();
        }
    }
}
