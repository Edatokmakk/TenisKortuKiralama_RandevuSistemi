using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TenisKortu
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
        }

        //SqlConnection baglanti = new SqlConnection("Data Source=VAHITTINZAIM;Initial Catalog=KortTenisi;Integrated Security=True");
        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LD27M7V\\SQLEXPRESS;Initial Catalog=KortTenisi;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source=android-5e629fa2c3ce3bb5\\SQLEXPRESS;Initial Catalog=KortTenisi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Hata");
            }

            else if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                string kayit = "insert into uyeler(Ad_Soyad,Telefon,E_Posta,Sifre) values (@Ad_Soyad,@Telefon,@E_Posta,@Sifre)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@Ad_Soyad", textBox1.Text);
                komut.Parameters.AddWithValue("@Telefon", textBox2.Text);
                komut.Parameters.AddWithValue("@E_Posta", textBox3.Text);
                komut.Parameters.AddWithValue("@Sifre", textBox4.Text);


                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Üye Kayıt İşlemi Gerçekleşti.");
                groupBox1.Hide();
                groupBox2.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Uyeler where E_Posta='" + textBox5.Text + "'and Sifre='" + textBox7.Text + "'", baglanti);
            SqlDataReader dr = komut2.ExecuteReader();
            
            string _adsoyad="", _telefon="";
            if (dr.Read())
            { 
               MessageBox.Show("Giriş Başarılı");
                              
               _adsoyad = dr["Ad_Soyad"].ToString();
               _telefon = dr["Telefon"].ToString();
               
               frm2 = new Form2(_adsoyad, _telefon,true);
               frm2.Show();
               this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanici adi veya şifre hatalı");
            }
           
            baglanti.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm2 = new Form2("", "", false);
            frm2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
        }
    }
}
