using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Praktika_2
{
    public partial class Produktai : Form
    {
        Prisijungti p;
        public Produktai(Prisijungti p)
        {
            this.p = p;
            InitializeComponent();
        }
        
        public Produktai()
        {
            InitializeComponent();
        }

        public string itemTxt;
        Krepšelis k;
        public List<Uzsakymas> customerList = new List<Uzsakymas>();
        public List<Produktas> productList = new List<Produktas>();
        private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private SQLiteDataReader sql_read;

        
        public void addToListview(string pavadinimas,int atmintis,string spalva,int kaina)
        {
            string[] arr = new string[4];
            ListViewItem itm;

            arr[0] = pavadinimas;
            arr[1] = atmintis.ToString();
            arr[2] = spalva;
            arr[3] = kaina.ToString();

            itm = new ListViewItem(arr);
            productView.Items.Add(itm);
        }


        private void SetConnection()
        {
            sql_conn = new SQLiteConnection("Data Source=PraktikaDB.db; Version = 3; New = True; Compress = True; ");
        }

        private void ProductList(string name)
        {
            productView.Items.Clear();
            SetConnection();
            string txtQueryRead = $"select * from Produktas where Pavadinimas like '{name}%'";
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            sql_cmd.CommandText = txtQueryRead;

            sql_read = sql_cmd.ExecuteReader();
            while (sql_read.Read())
            {
                string pavadinimas = sql_read.GetString(1);
                int atmintis = sql_read.GetInt32(2);
                string spalva = sql_read.GetString(3);
                int kaina = sql_read.GetInt32(4);
                addToListview(pavadinimas, atmintis, spalva, kaina);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductList("iphone");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProductList("huawei");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ProductList("xiaomi");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ProductList("samsung");
        }

        private void krepselis_Click(object sender, EventArgs e)
        {
            k = new Krepšelis(this, productList, customerList);
            k.Show();
            this.Hide();
        }

        private void prideti_Click(object sender, EventArgs e)
        {
            string price = productView.SelectedItems[0].SubItems[3].Text;
            
            
            SetConnection();
            string txtQueryRead = $"select * from Produktas where Kaina like '%{price}%'";
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            sql_cmd.CommandText = txtQueryRead;


            sql_read = sql_cmd.ExecuteReader();
            while (sql_read.Read())
            {
                string ID = sql_read.GetString(0);
                string pavadinimas = sql_read.GetString(1);
                int atmintis = sql_read.GetInt32(2);
                string spalva = sql_read.GetString(3);
                int kaina = sql_read.GetInt32(4);
                customerList.Add(new Uzsakymas(p.Username.Text, ID, pavadinimas, kaina));
                productList.Add(new Produktas(pavadinimas, atmintis, spalva, kaina));
            }

            MessageBox.Show("Produktas pridėtas!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void productView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
