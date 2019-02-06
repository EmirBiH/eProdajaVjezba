namespace eProdaja_UI
{
    partial class IndexForm
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
            this.korisniciDataView = new System.Windows.Forms.DataGridView();
            this.dodajKorisnika = new System.Windows.Forms.Button();
            this.urediButton = new System.Windows.Forms.Button();
            this.traziButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImePrezimeInput = new System.Windows.Forms.TextBox();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // korisniciDataView
            // 
            this.korisniciDataView.AllowUserToAddRows = false;
            this.korisniciDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikID,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Telefon,
            this.KorisnickoIme,
            this.Status});
            this.korisniciDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.korisniciDataView.Location = new System.Drawing.Point(0, 93);
            this.korisniciDataView.Name = "korisniciDataView";
            this.korisniciDataView.ReadOnly = true;
            this.korisniciDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisniciDataView.Size = new System.Drawing.Size(677, 357);
            this.korisniciDataView.TabIndex = 1;
            // 
            // dodajKorisnika
            // 
            this.dodajKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajKorisnika.Location = new System.Drawing.Point(419, 30);
            this.dodajKorisnika.Name = "dodajKorisnika";
            this.dodajKorisnika.Size = new System.Drawing.Size(134, 23);
            this.dodajKorisnika.TabIndex = 2;
            this.dodajKorisnika.Text = "Dodaj korisnika";
            this.dodajKorisnika.UseVisualStyleBackColor = true;
            this.dodajKorisnika.Click += new System.EventHandler(this.dodajKorisnika_Click);
            // 
            // urediButton
            // 
            this.urediButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.urediButton.Location = new System.Drawing.Point(559, 30);
            this.urediButton.Name = "urediButton";
            this.urediButton.Size = new System.Drawing.Size(106, 23);
            this.urediButton.TabIndex = 3;
            this.urediButton.Text = "Izmjena korisnika";
            this.urediButton.UseVisualStyleBackColor = true;
            this.urediButton.Click += new System.EventHandler(this.urediButton_Click);
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(325, 30);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(75, 23);
            this.traziButton.TabIndex = 4;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime i prezime:";
            // 
            // ImePrezimeInput
            // 
            this.ImePrezimeInput.Location = new System.Drawing.Point(86, 32);
            this.ImePrezimeInput.Name = "ImePrezimeInput";
            this.ImePrezimeInput.Size = new System.Drawing.Size(233, 20);
            this.ImePrezimeInput.TabIndex = 6;
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.ImePrezimeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.traziButton);
            this.Controls.Add(this.urediButton);
            this.Controls.Add(this.dodajKorisnika);
            this.Controls.Add(this.korisniciDataView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.ShowIcon = false;
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView korisniciDataView;
        private System.Windows.Forms.Button dodajKorisnika;
        private System.Windows.Forms.Button urediButton;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImePrezimeInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}

