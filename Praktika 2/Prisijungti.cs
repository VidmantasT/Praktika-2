using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Praktika_2
{
    public partial class Prisijungti : Form
    {
        public Prisijungti()
        {
            InitializeComponent();
        }

        private void jungtis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
                MessageBox.Show("Iveskite trukstamus laukus", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(new DBClass().userExists(Username.Text, Password.Text))
                {
                    MessageBox.Show("Prisijungta", "Prisijungimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Produktai pr = new Produktai(this);
                    pr.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Neteisingi prisijungimo duomenys", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
