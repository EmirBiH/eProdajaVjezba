using eProdaja_API.Models;
using eProdaja_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja_UI.Users
{
    public partial class AddForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:10733", "api/Korisnici");
        private WebAPIHelper ulogeService = new WebAPIHelper("http://localhost:10733", "api/Uloge");

        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = ulogeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                ulogeList.DataSource = response.Content.ReadAsAsync<Uloge>().Result;
                ulogeList.DisplayMember = "Naziv";
                ulogeList.ClearSelected();
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Korisnici k = new Korisnici();
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Email = emailInput.Text;
                k.Telefon = telefonInput.Text;
                k.KorisnickoIme = korisnickoImeInput.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                k.Status = true;

                k.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

                HttpResponseMessage response = korisniciService.PostResponse(k);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_usr_succ, "Poruka o uspijehu.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    string msg = response.ReasonPhrase;
                    if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                        msg = Messages.ResourceManager.GetString(response.ReasonPhrase);
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + msg);
                }
            }
        }

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Messages.fname_req);
            }
            else
                errorProvider.SetError(imeInput, null);
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Messages.lname_req);
            }
            else
                errorProvider.SetError(prezimeInput, null);
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, Messages.email_req);
                return;
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(emailInput.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailInput, Messages.email_err);
                    return;
                }
            }
            errorProvider.SetError(emailInput, null);
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lozinkaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.pass_req);
                return;
            }
            else
            {
                string validacija = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";
                Match match = Regex.Match(lozinkaInput.Text, validacija,
                RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    e.Cancel = true;
                    errorProvider.SetError(lozinkaInput, Messages.pass_format);
                    return;
                }
            }
            errorProvider.SetError(lozinkaInput, null);
        }
    }
}
