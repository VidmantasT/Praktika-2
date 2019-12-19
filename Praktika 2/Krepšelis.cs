using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Praktika_2
{
    public partial class Krepšelis : Form
    {
        Produktai produktai;
        WelcomePage welcomePage = new WelcomePage();
        Uzsakymas uzsakymas = new Uzsakymas();
        private DBClass DBClass = new DBClass();
        List<Produktas> P;
        List<Uzsakymas> U;
        double total = 0;

        public Krepšelis(Produktai produktai, List<Produktas> _P, List<Uzsakymas> _U)
        {
            this.produktai = produktai;
            P = _P;
            U = _U;
            InitializeComponent();
        }

        private void backToProducts_Click(object sender, EventArgs e)
        {
            this.produktai.Show();
            this.Hide();
        }

        private void Krepšelis_Load(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/9951704/add-item-to-listview-control
            for (int i = 0; i < P.Count; i++)
            {
                string[] row = { P[i].getPavadinimas(), P[i].getAtmintis().ToString() + " GB", P[i].getSpalva(), P[i].getKaina().ToString()};
                var listViewItem = new ListViewItem(row);
                krepselisListview.Items.Add(listViewItem);
                total += P[i].getKaina();
            }

            moketi.Text = uzsakymas.moketinaSuma(total).ToString() + " €";
        }

        private void istrintiProdukta_Click(object sender, EventArgs e)
        {
            var item = krepselisListview.SelectedItems[0];
            krepselisListview.Items.Remove(item);

            var p = P.First(x => x.getKaina() == Convert.ToDouble(item.SubItems[3].Text));
            P.Remove(p);

            var u = U.First(x => x.getKaina() == Convert.ToDouble(item.SubItems[3].Text));
            U.Remove(u);

            total -= Convert.ToDouble(item.SubItems[3].Text);
            uzsakymas.moketinaSuma(total);
            moketi.Text = uzsakymas.moketinaSuma(total).ToString() + " €";
        }

        private void pirkti_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < U.Count; i++)
            {
                string txtQueryInsert = "insert into Uzsakymas (Username, ProductID, Pavadinimas, Kaina, Data) values ('" + U[i].getUsername() + "', " +
                        "'" + U[i].getID() + "', '" + U[i].getPavadinimas() + "', '" + U[i].getKaina() + "', '" + U[i].GetDate() + "')";
                DBClass.ExecuteQueryInsert(txtQueryInsert);
            }

            MessageBox.Show("Užsakymas pateiktas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.welcomePage.Show();
            this.Hide();
        }
    }
}
