using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_v1_815
{
    public partial class Bilgileiniz : Form
    {
        Hasta hasta1 = new Hasta();
        int sayac = 0;
        public Bilgileiniz()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            sayac++;
            lbBilgiler.Items.Add(sayac+" .HASTA");

            hasta1.ad = txtAd.Text;
            lbBilgiler.Items.Add(hasta1.ad);

            hasta1.soyad = txtSoyad.Text;
            lbBilgiler.Items.Add(hasta1.soyad);

            hasta1.tel = txtTel.Text;
            lbBilgiler.Items.Add(hasta1.tel);

            hasta1.tc = txtTc.Text;          
            lbBilgiler.Items.Add(hasta1.tc);

            if (rbHastalikVar.Checked)
            {
                hasta1.kronikHastalik = true;
            }
            else
            {
                hasta1.kronikHastalik= false;
            }
            lbBilgiler.Items.Add(hasta1.kronikHastalik);

            hasta1.kanGrup = cmbKan.Text;
            lbBilgiler.Items.Add(hasta1.kanGrup);

            hasta1.dtarih = dtpTarih.Value;
            lbBilgiler.Items.Add(hasta1.dtarih);

            txtAd.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            txtTel.Clear();
            cmbKan.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
                MessageBox.Show("BİLGİLERİNİZ KAYDEDİLMİŞTİR");  
        }
    }
}
