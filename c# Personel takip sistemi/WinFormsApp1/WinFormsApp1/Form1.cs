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
        // VER�TABANI DOSYA YOLU 
        // ve PROV�DER NESNE BEL�RLENMES�
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data" +
            "Source=personel.accdb");

        // Formlar aras� VER� aktar�m�nda kullan�lcak de�i�kenler
        public static string tcno, adi, soyadi, yetki;

        // Yerel / Yalnizca bu Formda kullanilcak de�i�kenler
        int hak = 3; bool durum = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kullan�c� Giri�i..."; // sekmenin ba�l���
            this.AcceptButton = button1;this.CancelButton = button2;
            // AcceptButton entera bas�l�nca button1 �al��s�n
            // ESC bas�l�nca button 2 �al��s�n
            label5.Text = Convert.ToString(hak);
            // label5 'in text'ine bu yaz�ls�n
            radioButton1.Checked = true;
            // 
            this.StartPosition = FormStartPosition.CenterScreen;
            //
            // ekranda ortala dedik: �zellikler k�sm�ndanda ayarlayabliriz
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            // pencerenin �st�ndeki tu�lar: �arp� b�y�lt k���lt


        }
    }
}
