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
            noUserId.Hide();
        }

        void BindGrid()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchByName",ImePrezimeInput.Text.Trim()??"");
            noUserId.Hide();
            if (response.IsSuccessStatusCode)
            {
                List<Korisnici_Result> users = response.Content.ReadAsAsync<List<Korisnici_Result>>().Result;
                korisniciDataView.DataSource= users;
                korisniciDataView.ClearSelection();
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
                BindGrid();
            }
        }

        private void urediButton_Click(object sender, EventArgs e)
        {
            if (korisniciDataView.SelectedRows.Count>=1)
            {
                Convert.ToInt32(korisniciDataView.SelectedRows[0].Cells[0].Value);
                EditForm frm = new EditForm(Convert.ToInt32(korisniciDataView.SelectedRows[0].Cells[0].Value));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                noUserId.Text = Messages.noUserId;
                noUserId.Show();
            }
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
