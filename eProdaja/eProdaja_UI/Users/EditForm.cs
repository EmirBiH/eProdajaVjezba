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

namespace eProdaja_UI.Users
{
    public partial class EditForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:10733", "api/Korisnici");
        private WebAPIHelper ulogeService = new WebAPIHelper("http://localhost:10733", "api/Uloge");

        Korisnici k { get; set; }

        public EditForm(int KorisnikID)
        {
            InitializeComponent();

            HttpResponseMessage response = korisniciService.GetResponse(KorisnikID.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                k = null;
            if (response.IsSuccessStatusCode)
            {
                k = response.Content.ReadAsAsync<Korisnici>().Result;
                FillForm();
            }
        
        }

        private void FillForm()
        {
            imeInput.Text = k.Ime;
            prezimeInput.Text = k.Prezime;
            telefonInput.Text = k.Telefon;
            emailInput.Text = k.Email;
            korisnickoImeInput.Text = k.KorisnickoIme;
            statusCheckBox.Checked = k.Status;

            HttpResponseMessage checkUloge= korisniciService.GetActionResponse("UlogeZaKorisnika",k.KorisnikID.ToString());
            HttpResponseMessage sveUloge = ulogeService.GetResponse();
            if (sveUloge.IsSuccessStatusCode && checkUloge.IsSuccessStatusCode)
            {
                List<Uloge> su = sveUloge.Content.ReadAsAsync<List<Uloge>>().Result;
                List<int> cu = checkUloge.Content.ReadAsAsync<List<int>>().Result;
                foreach (var item in su)
                {
                    if (cu.Contains(item.UlogaID))
                        ulogeList.Items.Add(item, true);
                    else
                        ulogeList.Items.Add(item, false);
                }
            }
            ulogeList.DisplayMember = "Naziv";

        }

        private void snimiButton_Click(object sender, EventArgs e)
        {
            if (k != null)
            {
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Telefon = telefonInput.Text;
                k.Email = emailInput.Text;
                k.KorisnickoIme = korisnickoImeInput.Text;
                k.Status = statusCheckBox.Checked;

                k.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

                if (!String.IsNullOrEmpty(labelLozinka.Text))
                {
                    k.LozinkaSalt = UIHelper.GenerateSalt();
                    k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                }

                HttpResponseMessage response = korisniciService.PutResponse(k.KorisnikID,k);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_usr_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error code" + response.StatusCode + " Message:" + response.ReasonPhrase);
                }

            }
        }
    }
}
