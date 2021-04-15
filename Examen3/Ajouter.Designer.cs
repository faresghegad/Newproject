
namespace Examen3
{
    partial class Ajouter
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
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ajouterbtn
            // 
            this.Ajouterbtn.Location = new System.Drawing.Point(309, 133);
            this.Ajouterbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Ajouterbtn.Name = "Ajouterbtn";
            this.Ajouterbtn.Size = new System.Drawing.Size(100, 28);
            this.Ajouterbtn.TabIndex = 13;
            this.Ajouterbtn.Text = "Ajouter";
            this.Ajouterbtn.UseVisualStyleBackColor = true;
            this.Ajouterbtn.Click += new System.EventHandler(this.Ajouterbtn_Click);
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(149, 97);
            this.txtbox3.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(259, 22);
            this.txtbox3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prenom : ";
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(149, 53);
            this.txtbox2.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(259, 22);
            this.txtbox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom : ";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(149, 13);
            this.txtbox1.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(259, 22);
            this.txtbox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numéro d\'étudiant : ";
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 175);
            this.Controls.Add(this.Ajouterbtn);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.label1);
            this.Name = "Ajouter";
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.Ajouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ajouterbtn;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Label label1;
    }
}