using eProdaja_API.Models;
using eProdaja_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja_UI
{
    public partial class LoginForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:10733", "api/Korisnici");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
           HttpResponseMessage response= korisniciService.GetResponse(korisnickoImeInput.Text);
            if (response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;
                if (k.LozinkaHash == UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt))
                {
                    MessageBox.Show("Dobrodošli " + k.Ime + " " + k.Prezime);
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Korisničko ime ili lozinka nisu validni!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
    }
}
