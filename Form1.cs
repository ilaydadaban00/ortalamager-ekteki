using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace dersOrtalamaAğırlıkort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEdebiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Edebiyat, Matematik, Fizik, Kimya, Biyoloji, Tarih, Cografya, Din, Beden, Felsefe, ingilizce, Ntp, Robotik,DersPuanı;
            int Edebiyatsaati, Matematiksaati, Fiziksaati, Kimyasaati, Biyolojisaati, Tarihsaati, Cografyasaati, Dinsaati, Bedensaati, Felsefesaati, ingilizcesaati, Ntpsaati, Robotiksaati,saat,agırlıkderssaati;
            int edebiyatAgirlik, matematikAgirlik, FizikAgirlik, KimyaAgirlik, BiyolojiAgirlik, TarihAgirlik, CografyaAgirlik, DinAgirlik, BedenAgirlik, FelsefeAgirlik, ingilizceAgirlik, NtpAgirlik, RobotikAgirlik;

            Edebiyat = Convert.ToInt32(txtEdebiyat.Text);
            Matematik = Convert.ToInt32(txtMatemattik.Text);
            Fizik = Convert.ToInt32(txtFizik.Text);
            Kimya = Convert.ToInt32(txtKimya.Text);
            Biyoloji = Convert.ToInt32(txtBiyoloji.Text);
            Tarih = Convert.ToInt32(txtTarih.Text);
            Cografya = Convert.ToInt32(txtCografya.Text);
            Din = Convert.ToInt32(txtDin.Text);
            Beden=Convert.ToInt32(txtBeden.Text);
            Felsefe = Convert.ToInt32(txtFelsefe.Text);
            ingilizce = Convert.ToInt32(txtİngilizce.Text);
            Ntp= Convert.ToInt32(txtNtp.Text);
            Robotik = Convert.ToInt32(txtRobotik.Text);



            Edebiyatsaati = Convert.ToInt32(txtEdebiyatSaat.Text);
            Matematiksaati = Convert.ToInt32(txtMatemattikSaat.Text);
            Fiziksaati = Convert.ToInt32(txtFizikSaat.Text);
            Kimyasaati = Convert.ToInt32(txtKimyaSaat.Text);
            Biyolojisaati = Convert.ToInt32(txtBiyolojiSaat.Text);
            Tarihsaati = Convert.ToInt32(txtTarihSaat.Text);
            Cografyasaati = Convert.ToInt32(txtCografyaSaat.Text);
            Dinsaati = Convert.ToInt32(txtDinSaat.Text);
            Bedensaati = Convert.ToInt32(txtBedenSaat.Text);
            Felsefesaati = Convert.ToInt32(txtFelsefeSaat.Text);
            ingilizcesaati = Convert.ToInt32(txtİngilizceSaat.Text);
            Ntpsaati = Convert.ToInt32(txtNtpSaat.Text);
            Robotiksaati = Convert.ToInt32(txtRobotikSaat.Text);


            edebiyatAgirlik = Edebiyatsaati * Edebiyat;
            matematikAgirlik = Matematiksaati * Matematik;
            FizikAgirlik = Fiziksaati * Fizik;
            KimyaAgirlik = Kimyasaati * Kimya;
            BiyolojiAgirlik=Biyolojisaati * Biyoloji;
            TarihAgirlik = Tarihsaati * Tarih;
            CografyaAgirlik = Cografyasaati * Cografya;
            DinAgirlik = Dinsaati * Din;
            BedenAgirlik=Bedensaati * Beden;
            FelsefeAgirlik = Felsefesaati * Felsefe;
            ingilizceAgirlik = ingilizcesaati * ingilizce;



            lblMatematikAgirlik.Text = "edebiyat ağırlık:" + matematikAgirlik;





            DersPuanı = Edebiyat + Matematik + Fizik + Kimya + Biyoloji + Tarih + Cografya + Din + Beden + Felsefe + ingilizce + Ntp + Robotik;
            saat=Edebiyatsaati+Matematiksaati+Fiziksaati+Kimyasaati+Biyolojisaati+Tarihsaati+Cografyasaati+Dinsaati+Bedensaati+Felsefesaati+ ingilizcesaati+ Ntpsaati+ Robotiksaati;
            agırlıkderssaati = (DersPuanı * saat);

            lblEdebiatAgirlik.Text = "edebiyat ağırlık:"+edebiyatAgirlik;
            lblMatematikAgirlik.Text = "edebiyat ağırlık:" + matematikAgirlik;






        }

               
    }
}
