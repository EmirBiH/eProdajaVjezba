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
            this.ucitajKorinikebtn = new System.Windows.Forms.Button();
            this.korisniciDataView = new System.Windows.Forms.DataGridView();
            this.dodajKorisnika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ucitajKorinikebtn
            // 
            this.ucitajKorinikebtn.Location = new System.Drawing.Point(226, 22);
            this.ucitajKorinikebtn.Name = "ucitajKorinikebtn";
            this.ucitajKorinikebtn.Size = new System.Drawing.Size(142, 23);
            this.ucitajKorinikebtn.TabIndex = 0;
            this.ucitajKorinikebtn.Text = "Ucitaj korinike";
            this.ucitajKorinikebtn.UseVisualStyleBackColor = true;
            this.ucitajKorinikebtn.Click += new System.EventHandler(this.ucitajKorinikebtn_Click);
            // 
            // korisniciDataView
            // 
            this.korisniciDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.korisniciDataView.Location = new System.Drawing.Point(0, 93);
            this.korisniciDataView.Name = "korisniciDataView";
            this.korisniciDataView.Size = new System.Drawing.Size(800, 357);
            this.korisniciDataView.TabIndex = 1;
            // 
            // dodajKorisnika
            // 
            this.dodajKorisnika.Location = new System.Drawing.Point(624, 22);
            this.dodajKorisnika.Name = "dodajKorisnika";
            this.dodajKorisnika.Size = new System.Drawing.Size(134, 23);
            this.dodajKorisnika.TabIndex = 2;
            this.dodajKorisnika.Text = "Dodaj korisnika";
            this.dodajKorisnika.UseVisualStyleBackColor = true;
            this.dodajKorisnika.Click += new System.EventHandler(this.dodajKorisnika_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodajKorisnika);
            this.Controls.Add(this.korisniciDataView);
            this.Controls.Add(this.ucitajKorinikebtn);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ucitajKorinikebtn;
        private System.Windows.Forms.DataGridView korisniciDataView;
        private System.Windows.Forms.Button dodajKorisnika;
    }
}

