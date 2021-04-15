using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Modifier_Cour : Form
    {
        public Modifier_Cour(string cour,string numero_etudient)
        {
            InitializeComponent();
            oldcour = cour;
            etudient = numero_etudient;
            Cour c = new Cour(cour);
            NCtxt.Text = c.Numero_cours;
            Codetxt.Text = c.Code;
            Titretxt.Text = c.Titre;
        }
        string oldcour = null;
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
            Cour O_cour = new Cour(oldcour);
            Cour N_cour = new Cour(NCtxt.Text + "¿" + Codetxt.Text + "¿" + Titretxt.Text);
            Donnees.update_Cours(O_cour, N_cour, etudient);
            this.Close();
        }
    }
}
