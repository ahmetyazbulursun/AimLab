using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aim_Lab
{
    public partial class SerbestMod : Form
    {
        public SerbestMod()
        {
            InitializeComponent();
        }

        int sayac = 0;

        private void SerbestMod_Load(object sender, EventArgs e)
        {
            target.Enabled = false;
            target.Visible = false;
            lblSkor.Visible = false;
            lblSkor.Enabled = false;
            lblZaman.Visible = false;
            lblZaman.Enabled = false;
            label1.Enabled = false;
            label1.Visible = false;
            label3.Enabled = false;
            label3.Visible = false;
        }

        int skor = 0;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            sayac = 0;
            skor = 0;

            lblSkor.Text = "0";
            lblZaman.Text = "0";

            timer1.Start();

            btnBasla.Enabled = false;
            btnBasla.Visible = false;
            btnMenuyeDon.Enabled = false;
            btnMenuyeDon.Visible = false;

            target.Enabled = true;
            target.Visible = true;
            lblSkor.Visible = true;
            lblSkor.Enabled = true;
            lblZaman.Visible = true;
            lblZaman.Enabled = true;
            label1.Enabled = true;
            label1.Visible = true;
            label3.Enabled = true;
            label3.Visible = true;

        }

        private void target_Click(object sender, EventArgs e)
        {
            skor++;

            Random konum = new Random();
            int x = konum.Next(0, 900);
            int y = konum.Next(0, 400);

            target.Location = new Point(x, y);
            lblSkor.Text = skor.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random konum = new Random();
            int x = konum.Next(0, 900);
            int y = konum.Next(0, 450);

            sayac++;
            lblZaman.Text = sayac.ToString();
        }

        private void btnMenuyeDon_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Poligondan Ayrılıp Ana Menüye Dönmek İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                timer1.Stop();
                MessageBox.Show(skor + " başarılı atış yaptınız.", "Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Menu frm = new Menu();
                frm.Show();
                this.Hide();
            }
        }
    }
}
