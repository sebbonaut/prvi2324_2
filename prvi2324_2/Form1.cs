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
    public partial class Form1 : Form
    {
        public List<Racun> racuni = new List<Racun>()
        {
            new Racun("Nova trgovina", new DateTime(2024,02,10),
                new List<Artikl>() {
                    new Artikl("Salata", 1.45M, 0.2M),
                    new Artikl("Cikla", 0.4M, 0)
                }),
            new Racun("Nova trgovina", new DateTime(2024,09,01),
                new List<Artikl>() {
                    new Artikl("Breskva", 1.25M, 0.1M)
                })
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrikazSvih_Click(object sender, EventArgs e)
        {
            dataGridViewRacuni.DataSource = racuni;
        }

        private void dataGridViewRacuni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView d)
            {
                dataGridViewArtikli.DataSource
                    = racuni[d.CurrentRow.Index].artikli;
            }
        }

        private void buttonDodajNaRacun_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacuni.SelectedCells.Count == 0)
            {
                MessageBox.Show("Morate odabrati neki račun!",
                    "VAŽNO");
            }
            else
            {
                Form2 formaZaDodavanje = new Form2
                    (racuni[dataGridViewRacuni.CurrentRow.Index].artikli);
                formaZaDodavanje.ShowDialog();
                dataGridViewArtikli.DataSource = null;
                dataGridViewRacuni.DataSource = null;
            }
        }
    }
}
