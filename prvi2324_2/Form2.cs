using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prvi2324_2
{
    public partial class Form2 : Form
    {
        private List<Artikl> artikli;
        public Form2(List<Artikl> artikli)
        {
            InitializeComponent();
            this.artikli = artikli;
            gumbDodaj.Enabled = false;
        }

        private void gumbOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbDodaj_Click(object sender, EventArgs e)
        {
            artikli.Add(new Artikl
                (textBoxNaziv.Text,
                numericUpDownCijena.Value,
                numericUpDownPopust.Value / 100)
            );
            Close();
        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNaziv.Text))
            {
                labelaUpozorenje.Visible = false;
                gumbDodaj.Enabled = true;
            } else
            {
                labelaUpozorenje.Visible = true;
                gumbDodaj.Enabled = false;
            }
        }
    }
}
