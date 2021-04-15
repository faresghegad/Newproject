
namespace Examen3
{
    partial class Ajouter_Cour
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
            this.Titretxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Codetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NCtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ajouterbtn
            // 
            this.Ajouterbtn.Location = new System.Drawing.Point(313, 133);
            this.Ajouterbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Ajouterbtn.Name = "Ajouterbtn";
            this.Ajouterbtn.Size = new System.Drawing.Size(100, 28);
            this.Ajouterbtn.TabIndex = 13;
            this.Ajouterbtn.Text = "Ajouter";
            this.Ajouterbtn.UseVisualStyleBackColor = true;
            this.Ajouterbtn.Click += new System.EventHandler(this.Ajouterbtn_Click);
            // 
            // Titretxt
            // 
            this.Titretxt.Location = new System.Drawing.Point(153, 97);
            this.Titretxt.Margin = new System.Windows.Forms.Padding(4);
            this.Titretxt.Name = "Titretxt";
            this.Titretxt.Size = new System.Drawing.Size(259, 22);
            this.Titretxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Titre : ";
            // 
            // Codetxt
            // 
            this.Codetxt.Location = new System.Drawing.Point(153, 53);
            this.Codetxt.Margin = new System.Windows.Forms.Padding(4);
            this.Codetxt.Name = "Codetxt";
            this.Codetxt.Size = new System.Drawing.Size(259, 22);
            this.Codetxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Code : ";
            // 
            // NCtxt
            // 
            this.NCtxt.Location = new System.Drawing.Point(153, 13);
            this.NCtxt.Margin = new System.Windows.Forms.Padding(4);
            this.NCtxt.Name = "NCtxt";
            this.NCtxt.Size = new System.Drawing.Size(259, 22);
            this.NCtxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero de cour : ";
            // 
            // Ajouter_Cour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 176);
            this.Controls.Add(this.Ajouterbtn);
            this.Controls.Add(this.Titretxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Codetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NCtxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Ajouter_Cour";
            this.Text = "Ajouter_Cour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ajouterbtn;
        private System.Windows.Forms.TextBox Titretxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Codetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NCtxt;
        private System.Windows.Forms.Label label1;
    }
}