using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string [] kahveler ={ "Misto" ,"Americano","Bianco","Cappucino","Macchiato","Con Panna","Mocca" };
        string[] sicakIcecekler = { "Çay", "Hot Chocolate", "Chai Tea Latte" };
        string[] sogukIcecekler = { "Su", "Soda", "Meyve Suyu" };
        decimal[] fiyatlarSoguk = { 5,5m, 5,5m, 5,5m };
        decimal[] fiyatlarKahve = { 4.5m, 5.75m, 6m, 7.5m, 6.75m, 8m, 7.75m };
        decimal[] fiyatlarSicak = { 3m, 4.5m, 6.5m };
        decimal tutar = 0;
        
        double boyut = 1;
        //int siparisAdet = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            İcecekEkle();
        }
        public void İcecekEkle()
        {
            for (int i = 0; i < kahveler.Length; i++)
            {
                cmbKahve.Items.Add(kahveler[i]);

            }
            for (int i = 0; i < sicakIcecekler.Length; i++)
            {
                cmbSicak.Items.Add(sicakIcecekler[i]);
            }
            for (int i = 0; i < sogukIcecekler.Length; i++)
            {
                cmbSoguk.Items.Add(sogukIcecekler[i]);
            }
        }
        public void SiparisHazırla()
        {
            string Ad = txtAd.Text;
            string No = txtTelefon.Text;
            string kahve = cmbKahve.SelectedItem.ToString();
            string soguk = cmbSoguk.SelectedItem.ToString();
            string sicak = cmbSicak.SelectedItem.ToString();
            string listbox = $"{txtAd} kişinin siparişi:{cmbKahve.SelectedItem}, {nmbKahve.Value.ToString()} adet ={tutar} TL";
            MessageBox.Show($"{txtAd} kişinin siparişi:{cmbKahve.SelectedItem}, {nmbKahve.Value.ToString()} adet ={tutar} TL");
            lstSiparis.Items.Add(listbox);



        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double Shot = 0;
            double Sut = 0;
            double boyut = 0;
            if (rb1X.Checked)
            {

            }

            decimal tutar = ((fiyatlarKahve[cmbKahve.SelectedIndex] * nmbKahve.Value) + (fiyatlarSicak[cmbSicak.SelectedIndex] * nmbSicak.Value) + (fiyatlarSoguk[cmbSoguk.SelectedIndex] * nmbSoguk.Value))*;



            SiparisHazırla();
            lblToplamSiparis.Text = $"Tutar= {tutar} TL";
        }
        void KahveHesapla()
        {
            //double Shot = 0;
            //double Sut = 0;
            //double boyut = 0;
            //if(rb1X.Checked)
            //{
            //    double shot=0.75;

            //}
            //else if (rb2x.Checked)
            //{
            //    double shot = 1.5;
            //}
            //if (rbSutYagsiz.Checked)
            //{
            //    double sut = 0.5;
            //}
            //else if (rbSutSoya.Checked)
            //{
            //    double sut = 0;
            }
            //if(rbBoyutTall.Checked)
            //{
            //    double boyut= 1;
            //}
            //else if(rbBoyutGrande.Checked)
            //{
            //    double boyut = 1.25;
            //}
            //else(rbBBoyutVenti.Checked)
            //{
            //    double boyut = 1.75;
            //}
           

        }


    }
}
