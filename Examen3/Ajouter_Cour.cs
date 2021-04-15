using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Ajouter_Cour : Form
    {
        public Ajouter_Cour(string numero_etudient)
        {
            InitializeComponent();
            etudient = numero_etudient;
        }
        string etudient = null;
        private void Ajouterbtn_Click(object sender, EventArgs e)
        {
            if (!Donnees.verifier_valeur(NCtxt.Text))
            {
                MessageBox.Show("error", "Le Numero de cour est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Donnees.verifier_valeur(Codetxt.Text))
            {
                MessageBox.Show("error", "Le Code est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Donnees.verifier_valeur(Titretxt.Text))
            {
                MessageBox.Show("error", "Le Titre est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cour N_cour = new Cour(NCtxt.Text + "¿" + Codetxt.Text + "¿" + Titretxt.Text);
            Donnees.ajouter_Cours(N_cour, etudient);
            this.Close();
        }
    }
}
