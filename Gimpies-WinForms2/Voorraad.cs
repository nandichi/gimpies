using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimpies_WinForms2
{
    public partial class Voorraad : Form
    {
        DataTable table = new DataTable("Table");
        int index; 

        public Voorraad()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Terug_Click(object sender, EventArgs e)
        {
            if (lbl_user.Text == "verkoopmedewerker")
            {
                this.Hide();
                new Verkoopmedewerker().Show();
            }
            else if (lbl_user.Text == "Manager")
            {
                this.Hide();
                new Manager().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Voorraad_Load(object sender, EventArgs e)
        {
          
            lbl_user.Text = Login.GebruikerUser;
            if (lbl_user.Text == "verkoopmedewerker")
            {
                txtMerk.Enabled = false;
                txtType.Enabled = false;
                txtMaat.Enabled = false;
                txtKleur.Enabled = false;
                txtPrijs.Enabled = false;
                Aantal.Enabled = true;
                txtAantal.Enabled = true;
                Toevoegen.Hide();
                Aanpassen.Hide();
                Verwijderen.Hide();
            }
            else if (lbl_user.Text == "Manager")
            {
                txtMerk.Enabled = true;
                txtType.Enabled = true;
                txtMaat.Enabled = true;
                txtKleur.Enabled = true;
                txtPrijs.Enabled = true;
                txtAantal.ReadOnly = true;
                verkopen.Enabled = false;
                verkopen.Hide();
                verkopenaantal.Hide();
                verkopenaantallabel.Hide();
            }
            table.Columns.Add("Merk", System.Type.GetType("System.String"));
            table.Columns.Add("Type", System.Type.GetType("System.String"));
            table.Columns.Add("Maat", System.Type.GetType("System.Double"));
            table.Columns.Add("Kleur", System.Type.GetType("System.String"));
            table.Columns.Add("Prijs", System.Type.GetType("System.Double"));
            table.Columns.Add("Aantal", System.Type.GetType("System.Int32"));
            dataGridView1.DataSource = table;
            table.Rows.Add("Nike", "Jordan", 41, "Zwart", 400, 120);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Toevoegen_Click(object sender, EventArgs e)
        {
            txtAantal.Text = "0";
            table.Rows.Add(txtMerk.Text, txtType.Text, txtMaat.Text, txtKleur.Text, txtPrijs.Text, txtAantal.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtMerk.Text = row.Cells[0].Value.ToString();
            txtType.Text = row.Cells[1].Value.ToString();
            txtMaat.Text = row.Cells[2].Value.ToString();
            txtKleur.Text = row.Cells[3].Value.ToString();
            txtPrijs.Text = row.Cells[4].Value.ToString();
            txtAantal.Text = row.Cells[5].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Aanpassen_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = txtMerk.Text;
            newdata.Cells[1].Value = txtType.Text;
            newdata.Cells[2].Value = txtMaat.Text;
            newdata.Cells[3].Value = txtKleur.Text;
            newdata.Cells[4].Value = txtPrijs.Text;
            newdata.Cells[5].Value = txtAantal.Text;
        }

        private void Verwijderen_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void Gebruiker_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void verkopen_Click(object sender, EventArgs e)
        {
           DataGridViewRow verkoopdata = dataGridView1.Rows[index];
            int verkoopaantal = int.Parse(verkopenaantal.Text);
            int schoencontrole = Convert.ToInt32(verkopenaantal.Text);
            int datacontrole = Convert.ToInt32(verkoopdata.Cells[5].Value);
            if (schoencontrole > 0 && schoencontrole < datacontrole)
            {
                verkoopdata.Cells[5].Value = Convert.ToInt32(verkoopdata.Cells[5].Value) - Convert.ToInt32(verkopenaantal.Text);
                verkopenaantal.Text = verkoopaantal.ToString();
            }
            else if (schoencontrole > datacontrole)
            {
                MessageBox.Show("Meer schoenen dan op voorraad verkopen is niet mogelijk.");
            }
            else if (schoencontrole < 0)
            {
                MessageBox.Show("Het getal moet boven de 0 zijn. probeer het opnieuw.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
