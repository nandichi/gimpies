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
    public partial class Login : Form
    {
        public static string GebruikerUser;
        public Login()
        {
            InitializeComponent();
        }
        int attempts;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Wachtwoord.PasswordChar == '\0')
                Wachtwoord.PasswordChar = '*';
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            {
                if (attempts == 3)
                {
                    MessageBox.Show("U heeft de maximaal aantal loginpogingen bereikt \nProbeer het nog eens.", "pogingen");
                    
                }
            }
            string user, pass;
            user = Gebruikersnaam.Text;
            pass = Wachtwoord.Text;
            
            if(user== "verkoopmedewerker"&& pass== "gimpies")
            {
                GebruikerUser = "verkoopmedewerker";
                MessageBox.Show("U bent succesvol ingelogd.");
                new Verkoopmedewerker().Show();
                this.Hide();
            }
            
            else if(user== "manager"&& pass== "gimpies")
            {
                GebruikerUser = "Manager";
                MessageBox.Show("U bent succesvol ingelogd");
                new Manager().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("fout probeer het nog eens.");
                attempts = attempts + 1;
            }
            if (attempts == 3)
            {
                MessageBox.Show("U heeft de maximaal aantal loginpogingen bereikt");
                Application.Exit();
            }
        }

        private void Gebruikersnaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            attempts = 0;
        }
    }
}
