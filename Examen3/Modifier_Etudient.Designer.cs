
namespace Examen3
{
    partial class Modifier_Etudient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ajouterbtn = new System.Windows.Forms.Button();
            this.Prenomtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nomtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NEtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ajouterbtn
            // 
            this.Ajouterbtn.Location = new System.Drawing.Point(235, 109);
            this.Ajouterbtn.Name = "Ajouterbtn";
            this.Ajouterbtn.Size = new System.Drawing.Size(75, 23);
            this.Ajouterbtn.TabIndex = 13;
            this.Ajouterbtn.Text = "Modifier";
            this.Ajouterbtn.UseVisualStyleBackColor = true;
            this.Ajouterbtn.Click += new System.EventHandler(this.Ajouterbtn_Click);
            // 
            // Prenomtxt
            // 
            this.Prenomtxt.Location = new System.Drawing.Point(115, 80);
            this.Prenomtxt.Name = "Prenomtxt";
            this.Prenomtxt.Size = new System.Drawing.Size(195, 20);
            this.Prenomtxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prenom : ";
            // 
            // Nomtxt
            // 
            this.Nomtxt.Location = new System.Drawing.Point(115, 44);
            this.Nomtxt.Name = "Nomtxt";
            this.Nomtxt.Size = new System.Drawing.Size(195, 20);
            this.Nomtxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom : ";
            // 
            // NEtxt
            // 
            this.NEtxt.Location = new System.Drawing.Point(115, 12);
            this.NEtxt.Name = "NEtxt";
            this.NEtxt.Size = new System.Drawing.Size(195, 20);
            this.NEtxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numéro d\'étudiant : ";
            // 
            // Modifier_Etudient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 145);
            this.Controls.Add(this.Ajouterbtn);
            this.Controls.Add(this.Prenomtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nomtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NEtxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Modifier_Etudient";
            this.Text = "Modifier_Etudient";
            this.Load += new System.EventHandler(this.Modifier_Etudient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ajouterbtn;
        private System.Windows.Forms.TextBox Prenomtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nomtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NEtxt;
        private System.Windows.Forms.Label label1;
    }
}