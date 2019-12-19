using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_2
{
    public partial class WelcomePage : Form
    {

        public WelcomePage()
        {
            InitializeComponent();
        }

        private void registruotis_Click(object sender, EventArgs e)
        {
            Registruotis r = new Registruotis();
            r.Show();
            this.Hide();
        }

        private void prisijungti_Click(object sender, EventArgs e)
        {
            Prisijungti p = new Prisijungti();
            p.Show();
            this.Hide();
        }
    }
}
