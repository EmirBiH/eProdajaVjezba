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
    public partial class AddForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:10733", "api/Korisnici");
        private WebAPIHelper ulogeService = new WebAPIHelper("http://localhost:10733", "api/Uloge");

        public AddForm()
        {
            InitializeComponent();
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

           HttpResponseMessage response=  korisniciService.PostResponse(k);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Korisnik uspješno dodan.");
                DialogResult= DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
    }
}
