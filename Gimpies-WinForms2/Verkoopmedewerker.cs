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
    public partial class Verkoopmedewerker : Form
    {
        public Verkoopmedewerker()
        {
            InitializeComponent();
        }

        private void Verkoopmedewerker_Load(object sender, EventArgs e)
        {
            
        }

        private void Uitloggen_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Voorraadschoenenbekijken_Click(object sender, EventArgs e)
        {
            new Voorraad().Show();
            this.Hide();
        }
    }
}
