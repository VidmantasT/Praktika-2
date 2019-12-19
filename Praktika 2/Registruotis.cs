using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Praktika_2
{
    public partial class Registruotis : Form
    {   
        public Registruotis()
        {
            InitializeComponent();
        }
        private DBClass DB = new DBClass();

        //add user
        private void patvirtinti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vardas.Text) || string.IsNullOrEmpty(pavarde.Text) || string.IsNullOrEmpty(prisijungVardas.Text) ||
                    string.IsNullOrEmpty(slaptazodis.Text))
                MessageBox.Show("Iveskite trukstamus laukus", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //search for existing username
                string txtQueryRead = "select * from Vartotojai where Username='" + prisijungVardas.Text + "'";
                string username = DB.ExecuteQueryRead(txtQueryRead);

                if (username == prisijungVardas.Text)
                {
                    MessageBox.Show("Toks vartotojo vardas jau egzistuoja", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    prisijungVardas.Text = string.Empty;
                }
                else
                {
                    //inserting user
                    string txtQueryInsert = "insert into Vartotojai (Username, Password, Vardas, Pavarde) values ('" + prisijungVardas.Text + "', " +
                        "'" + slaptazodis.Text + "', '" +vardas.Text + "', '" + pavarde.Text + "')";
                    DB.ExecuteQueryInsert(txtQueryInsert);

                    MessageBox.Show("Vartotojas uzregistruotas", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    WelcomePage w = new WelcomePage();
                    w.Show();
                    this.Hide();
                }
            }
        }
    }
}