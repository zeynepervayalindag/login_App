﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisLabel_Click(object sender, EventArgs e)
        {
            
            string kullaniciadi = kullaniciadiTextBox.Text;
            string sifre = sifreTextBox.Text;
            if(string.IsNullOrEmpty(kullaniciadi))
            { 
                bilgi.Text = "Kullanıcı adınınızı giriniz.";
                return;
            }

            if(string.IsNullOrEmpty(sifre))
            {
                bilgi.Text = "Şifrenizi giriniz.";
                return;
            }
            if (kullaniciadi == "zeynepervayalindag" && sifre == "zeynep797")
            {
                bilgi.Text = "Giriş başarılı.";
            }
            else
            { 
                bilgi.Text = "Giriş başarısız.Kullanıcı adınız veya şifreniz hatalı."; 
            }
        




        }
    }
}
