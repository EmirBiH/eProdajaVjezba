namespace eProdaja_UI.Users
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // telefonInput
            // 
            resources.ApplyResources(this.telefonInput, "telefonInput");
            this.telefonInput.Name = "telefonInput";
            // 
            // imeInput
            // 
            resources.ApplyResources(this.imeInput, "imeInput");
            this.imeInput.Name = "imeInput";
            // 
            // prezimeInput
            // 
            resources.ApplyResources(this.prezimeInput, "prezimeInput");
            this.prezimeInput.Name = "prezimeInput";
            // 
            // emailInput
            // 
            resources.ApplyResources(this.emailInput, "emailInput");
            this.emailInput.Name = "emailInput";
            // 
            // korisnickoImeInput
            // 
            resources.ApplyResources(this.korisnickoImeInput, "korisnickoImeInput");
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            // 
            // lozinkaInput
            // 
            resources.ApplyResources(this.lozinkaInput, "lozinkaInput");
            this.lozinkaInput.Name = "lozinkaInput";
            // 
            // dodajButton
            // 
            resources.ApplyResources(this.dodajButton, "dodajButton");
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // AddForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Button dodajButton;
    }
}