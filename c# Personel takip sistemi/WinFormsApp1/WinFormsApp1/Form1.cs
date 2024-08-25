using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 
using System.Data.OleDb;




namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // VERÝTABANI DOSYA YOLU 
        // ve PROVÝDER NESNE BELÝRLENMESÝ
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data" +
            "Source=personel.accdb");

        // Formlar arasý VERÝ aktarýmýnda kullanýlcak deðiþkenler
        public static string tcno, adi, soyadi, yetki;

        // Yerel / Yalnizca bu Formda kullanilcak deðiþkenler
        int hak = 3; bool durum = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kullanýcý Giriþi..."; // sekmenin baþlýðý
            this.AcceptButton = button1;this.CancelButton = button2;
            // AcceptButton entera basýlýnca button1 çalýþsýn
            // ESC basýlýnca button 2 çalýþsýn
            label5.Text = Convert.ToString(hak);
            // label5 'in text'ine bu yazýlsýn
            radioButton1.Checked = true;
            // 
            this.StartPosition = FormStartPosition.CenterScreen;
            //
            // ekranda ortala dedik: özellikler kýsmýndanda ayarlayabliriz
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            // pencerenin üstündeki tuþlar: çarpý büyült küçült


        }
    }
}
