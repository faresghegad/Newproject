using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Modifier_Note : Form
    {
        public Modifier_Note(string etudient, string cour,string note)
        {
            InitializeComponent();
            Etxt.Text = etudient.Replace("¿", "  ");
            Ctxt.Text = cour.Replace("¿", "-");
            Ntxt.Text = note;
            old_note = etudient.Split('¿')[0]+"¿"+cour.Split('¿')[0] + "¿" + note;
        }
        string old_note = null;
        private void Ajouterbtn_Click(object sender, EventArgs e)
        {
            if (!Donnees.verifier_valeur_double(Ntxt.Text))
            {
                MessageBox.Show("error", "La Note est incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Note o_note = new Note(old_note);
            Note n_note = new Note(o_note.Numero_etudiant+"¿"+o_note.Numero_cours+"¿"+Ntxt.Text);
            if (n_note.N_value == o_note.N_value)
                Close();
            Donnees.update_Note(o_note, n_note, o_note.Numero_etudiant);
            Close();

        }
    }
}
