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

        
        private void Prijava()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("GetByUserName", korisnickoImeInput.Text);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                MessageBox.Show(Messages.login_fail, "Greška",MessageBoxButtons.OK,MessageBoxIcon.Error);

            else if (response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;
                if (UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt)==k.LozinkaHash)
                {
                    DialogResult = DialogResult.OK;
                    Global.prijavljeniKorisnik = k;
                    Close();
                }
                else
                    MessageBox.Show(Messages.login_fail, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            Prijava();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
