
namespace Examen3
{
    partial class Ajouter_Note
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
            this.Ntxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ctxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Etxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ajouterbtn
            // 
            this.Ajouterbtn.Location = new System.Drawing.Point(297, 133);
            this.Ajouterbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Ajouterbtn.Name = "Ajouterbtn";
            this.Ajouterbtn.Size = new System.Drawing.Size(100, 28);
            this.Ajouterbtn.TabIndex = 27;
            this.Ajouterbtn.Text = "Ajouter";
            this.Ajouterbtn.UseVisualStyleBackColor = true;
            this.Ajouterbtn.Click += new System.EventHandler(this.Ajouterbtn_Click);
            // 
            // Ntxt
            // 
            this.Ntxt.Location = new System.Drawing.Point(137, 97);
            this.Ntxt.Margin = new System.Windows.Forms.Padding(4);
            this.Ntxt.Name = "Ntxt";
            this.Ntxt.Size = new System.Drawing.Size(259, 22);
            this.Ntxt.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Note : ";
            // 
            // Ctxt
            // 
            this.Ctxt.Location = new System.Drawing.Point(137, 53);
            this.Ctxt.Margin = new System.Windows.Forms.Padding(4);
            this.Ctxt.Name = "Ctxt";
            this.Ctxt.ReadOnly = true;
            this.Ctxt.Size = new System.Drawing.Size(259, 22);
            this.Ctxt.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cour : ";
            // 
            // Etxt
            // 
            this.Etxt.Location = new System.Drawing.Point(137, 13);
            this.Etxt.Margin = new System.Windows.Forms.Padding(4);
            this.Etxt.Name = "Etxt";
            this.Etxt.ReadOnly = true;
            this.Etxt.Size = new System.Drawing.Size(259, 22);
            this.Etxt.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Etudient : ";
            // 
            // Ajouter_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 179);
            this.Controls.Add(this.Ajouterbtn);
            this.Controls.Add(this.Ntxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ctxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Etxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Ajouter_Note";
            this.Text = "Ajouter_Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ajouterbtn;
        private System.Windows.Forms.TextBox Ntxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ctxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Etxt;
        private System.Windows.Forms.Label label1;
    }
}