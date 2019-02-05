using eProdaja_API.Models;
using eProdaja_UI.Users;
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
    public partial class IndexForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:10733", "api/Korisnici");

        public IndexForm()
        {
            InitializeComponent();
        }

        private void ucitajKorinikebtn_Click(object sender, EventArgs e)
        {
            
        }

        void BindForm()
        {
            HttpResponseMessage response = korisniciService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Korisnici_Result> users = response.Content.ReadAsAsync<List<Korisnici_Result>>().Result;
                korisniciDataView.DataSource = users;
                korisniciDataView.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
        private void dodajKorisnika_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindForm();
        }
    }
}
