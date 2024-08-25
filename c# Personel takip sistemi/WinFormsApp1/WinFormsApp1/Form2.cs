using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// VERİ TABANI BAĞLANTISI İÇİN 
using System.Data.OleDb;
// Text.RegularExpression / Regex 
using System.Text.RegularExpressions;
// GİRİŞ ÇIKIŞ İŞLEMLERİNE
using System.IO; 


namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Veri tabanı DOsya YOLU
        // PROVİDER NESNE BELİRLENMESİ

        OleDbConnection baglantim = new OleDbConnection
            ("Provider=Microsoft.Ace.Oledb.12.0;Data Source=personel.accdb");

        private void kullanicilari_goster()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter
                  ("select tcno AS[TC KİMLİK NO],ad AS[ADI],soyad AS[SOYADI],yetki AS[YETKİ],kullaniciadi AS[KULLANICI ADI],parola as[PAROLA] from kullanicilar Order By ad ASC",
                  baglantim);
                DataSet dshafiza = new DataSet();
                kullanicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglantim.Close();

            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SKY Personel Takip Programı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Mesaj box da   OK    ve   ERROR olsun
                baglantim.Close();

            }
        }


        private void personelleri_goster()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter personelleri_listele = new OleDbDataAdapter
                  ("select tcno AS[TC KİMLİK NO],ad AS[ADI],soyad AS[SOYADI],cinsiyet AS[CİNSİYETİ],mezuniyet AS[MEZUNİYETİ],dogumtarihi as[DOĞUM TARİHİ],gorevi AS[GÖREVİ],gorevyeri AS[GÖREV YERİ], maasi AS[MAAŞI] from personeller Order By ad ASC",
                  baglantim);
                DataSet dshafiza = new DataSet();
                personelleri_listele.Fill(dshafiza);
                dataGridView2.DataSource = dshafiza.Tables[0];
                baglantim.Close();

            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SKY Personel Takip Programı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Mesaj box da   OK    ve   ERROR olsun
                baglantim.Close();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // form ayarları 
            pictureBox1.Height = 150;
            pictureBox1.Width = 150;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath +
                    "\\kullaniciresimler\\" + Form1.tcno + "jpg");

            }
            catch
            {   // kullanıcı    giriş yaptiktan sonra
                // Kullanıcının resmi getirelemezse : ressimyok.jpg gelsin
                pictureBox1.Image = Image.FromFile(Application.StartupPath +
                    "\\kullaniciresimler\\resimyok.jpg");
              
            }

            // KULLANICI İŞLEMLERİ SEKMESİ AYARLARI İÇİN :
            // PENCERE ÖZELLİKLERİ AYARLAMASI : 
            this.Text = "YÖNETİCİ İŞLEMLERİ";
            label11.ForeColor = Color.DarkRed;
            label11.Text = Form1.adi + " " + Form1.soyadi;
            textBox1.MaxLength = 11;
            textBox1.MaxLength = 8;

            toolTip1.SetToolTip(this.textBox1, "TC Kimlik No 11 Karakter Olmalı!");
            radioButton1.Checked = true;
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox3.CharacterCasing = CharacterCasing.Upper;
            textBox5.MaxLength = 10;
            textBox6.MaxLength = 10;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            kullanicilari_goster();

            // PERSONEL İŞLEMLERİ SEKMESİ : 
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Width = 100; pictureBox2.Height = 100;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            maskedTextBox1.Mask = "00000000000"; //11 tane olmalı
            maskedTextBox2.Mask = "LL????????????????????"; // 20 tane ?
            maskedTextBox3.Mask = "LL????????????????????";
            maskedTextBox4.Mask = "0000";
            maskedTextBox2.Text.ToUpper();
            maskedTextBox3.Text.ToUpper();

            comboBox1.Items.Add("ilköğretim"); comboBox1.Items.Add("Ortaöğretim");
                comboBox1.Items.Add("Lise"); comboBox1.Items.Add("Universite");

            comboBox2.Items.Add("Yönetici"); comboBox1.Items.Add("Memur");
                comboBox2.Items.Add("Şöfor"); comboBox1.Items.Add("İşçi");

            comboBox3.Items.Add("ARGE"); comboBox1.Items.Add("Bilgi İşlem");
                comboBox3.Items.Add("Muhasebe"); comboBox1.Items.Add("Üretim");
                comboBox3.Items.Add("Paketleme"); comboBox1.Items.Add("Nakliye");

            DateTime zaman = DateTime.Now;
            int yil = int.Parse(zaman.ToString("yyyy"));
            int ay = int.Parse(zaman.ToString("MM"));
            int gun = int.Parse(zaman.ToString("dd"));


            dateTimePicker1.MinDate = new DateTime(1960, 1, 1);
            dateTimePicker1.MaxDate = new DateTime(yil-18, ay, gun);
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            radioButton3.Checked = true;










        }       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
