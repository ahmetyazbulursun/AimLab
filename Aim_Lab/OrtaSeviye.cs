using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aim_Lab
{
    public partial class OrtaSeviye : Form
    {
        public OrtaSeviye()
        {
            InitializeComponent();
        }

        int sayac = 30;

        private void Form1_Load(object sender, EventArgs e)
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

        private void target_Click(object sender, EventArgs e)
        {
            skor++;
            
            Random konum = new Random();
            int x = konum.Next(0,900);
            int y = konum.Next(0,400);

            target.Location =  new Point(x, y);
            lblSkor.Text = skor.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random konum = new Random();
            int x = konum.Next(0, 900);
            int y = konum.Next(0, 450);

            sayac--;
            lblZaman.Text = sayac.ToString();

            if (lblSkor.Text == "40" && sayac > 0)
            {
                timer1.Stop();

                target.Visible = false;
                target.Enabled = false;

                MessageBox.Show("Harika! Orta Seviyeyi " + sayac + " saniye kala tamamladınız." , "Orta Seviye", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnBasla.Enabled = true;
                btnBasla.Visible = true;
                btnMenuyeDon.Enabled = true;
                btnMenuyeDon.Visible = true;

                lblZaman.Visible = false;
                lblZaman.Enabled = false;
                lblSkor.Visible = false;
                lblSkor.Enabled = false;
                label3.Visible = false;
                label3.Enabled = false;
                label1.Visible = false;
                label1.Enabled = false;

                
            }

            if (sayac == 0 && skor < 40)
            {
                timer1.Stop();
                MessageBox.Show("Süre Doldu ve Hedef Sayıya Ulaşamadınız. Skorunuz: " + skor, "Orta Seviye", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                btnBasla.Visible = true;
                btnBasla.Enabled = true;
                btnCikisYap.Visible = true;
                btnCikisYap.Enabled = true;
                btnMenuyeDon.Visible = false;
                btnMenuyeDon.Enabled = false;

                lblSkor.Visible = false;
                lblSkor.Enabled = false;
                lblZaman.Visible = false;
                lblZaman.Enabled = false;
                label1.Visible = false;
                label1.Enabled = false;
                label3.Visible = false;
                label3.Enabled = false;

                target.Visible = false;
                target.Enabled = false;
            }

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            sayac = 30;
            skor = 0;

            lblSkor.Text = "0";
            lblZaman.Text = "30";

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
                Menu frm = new Menu();
                frm.Show();
                this.Hide();
            }
        }
    }
}
