using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenisKortu
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=android-5e629fa2c3ce3bb5\\SQLEXPRESS;Initial Catalog=KortTenisi;Integrated Security=True");
        string adsoyad, telefon;
        Boolean üye=false;
        string seans = "",tarih="";
        Boolean kontrol = false;
        int karsilastirmaDate;
        

        public Form2(string _adsoyad="", string _telefon="", Boolean _üye =false)
        {
            InitializeComponent();
            adsoyad = _adsoyad;
            telefon = _telefon;
            groupBox2.Hide();
            if (adsoyad == "")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                textBox1.Text = adsoyad;
                textBox2.Text = telefon;
            }
            üye = _üye;
            groupBox1.Hide();
            if (_üye)
            {
                groupBox2.Show();
                üyeRezervasyonlariUpdate();
                groupBox2.Text = "İleri veya Geri Tarihli Rezervasyonlarınız";
            }
                
            
            
        }

        private void tarihuyg_Click(object sender, EventArgs e)
        {
                  yenile();
            kontrol = false;
            if (comboBox1.SelectedItem != null)
            {
                if (karsilastirmaDate >= 0)
                {
                    label6.Text = "";
                    ZamaniGecenSeanslar();
                    KarsilastirmaDate();

                    groupBox1.Show();
                    tarih = dateTimePicker1.Value.ToShortDateString();
                    groupBox1.Text = tarih + " " + comboBox1.SelectedItem;


                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("select seans from Kiralamalar where tarih='" + tarih + "'and kort='" + comboBox1.SelectedItem + "'", baglanti);
                    SqlDataReader dr = komut2.ExecuteReader();
                    while (dr.Read())
                    {
                        for (int i = 0; i < 6; i++)
                        {

                            if (groupBox1.Controls[i].Text == dr["seans"].ToString())

                            {
                                groupBox1.Controls[i].BackColor = Color.Red;
                                groupBox1.Controls[i].Enabled = false;
                            }

                        }
                    }
                    baglanti.Close();
                }
                else { label6.Text = "Lütfen ileri bir tarih seçiniz!"; }
            }
            else
            {
                label6.Text = "Lütfen kort belirtiniz!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "insert into kiralamalar(ad_soyad,telefon,kort,tarih,uyemi,seans) values (@ad_soyad,@telefon,@kort,@tarih,@uyemi,@seans)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);


            if(!(seans==""||tarih==""|| comboBox1.SelectedItem.ToString()=="")||textBox1.Text==""|| textBox2.Text=="")
            {

                komut.Parameters.AddWithValue("@ad_soyad", textBox1.Text);
                komut.Parameters.AddWithValue("@telefon", textBox2.Text);
                komut.Parameters.AddWithValue("@kort", comboBox1.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@uyemi", üye);
                komut.Parameters.AddWithValue("@seans", seans);
                komut.ExecuteNonQuery();
                MessageBox.Show("Tamam");
            }
            else
            {
                MessageBox.Show("Lütfen Ad ve Soyad giriniz");

            }

             baglanti.Close();
            yenile();
            groupBox1.Hide();
            üyeRezervasyonlariUpdate();
            
            }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();

        }

        //tarih seçildiği zaman
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            DateTimePicker zaman = (DateTimePicker)sender;
            tarih = zaman.Value.ToShortDateString();
             karsilastirmaDate = DateTime.Compare(zaman.Value.Date, DateTime.Now.Date);
            KarsilastirmaDate();

        }


        //Kullanılabilir Fonksiyonlar
        void ZamaniGecenSeanslar()
        {
            if (karsilastirmaDate == 0 || karsilastirmaDate < 0)
            {
                for (int i = 09; i < DateTime.Now.Hour; i++)
                {
                    if (i < 16)
                    {
                        if (i != 12)
                            groupBox1.Controls["seans" + i].Enabled = false;
                    }
                }
            }
        }

        void KarsilastirmaDate() {
            if (karsilastirmaDate < 0)
            {
                label6.Text = "Lütfen İleri tarih seçiniz";
                button2.Enabled = false;
            }
            else if (karsilastirmaDate == 0)
            {

                label6.Text = "";
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        void yenile()
        {
            for (int i = 0; i < 6; i++)
            {
                groupBox1.Controls[i].BackColor = Color.Lime;
                groupBox1.Controls[i].Enabled = true;
            }
            groupBox1.Text = "Tarih ve Kort Seciniz";
 
        }

        void üyeRezervasyonlariUpdate()
        {
            string bilgiler = "";
            listBox1.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Kiralamalar where ad_soyad='" + adsoyad + "'and telefon='" + telefon + "'", baglanti);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                bilgiler = dr["tarih"].ToString() + " " + dr["kort"].ToString() + "  " + dr["seans"].ToString();
                listBox1.Items.Add(bilgiler);
            }
            baglanti.Close();
        }


        //seans butonları       
        private void seans9_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                seans = "09:00-10:00";
                seans9.BackColor = Color.Red;
                kontrol = true;
            }
            else if (kontrol == true && seans9.BackColor == Color.Red)
            {
                seans = "";
                seans9.BackColor = Color.Lime;
                kontrol = false;
            }
        }

        private void seans10_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                seans = "10:00-11:00";
                seans10.BackColor = Color.Red;
                kontrol = true;
            }
            else if (kontrol == true && seans10.BackColor == Color.Red)
            {
                seans = "";
                seans10.BackColor = Color.Lime;
                kontrol = false;
            }

            
            
            
        }

        private void seans11_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                seans = "11:00-12:00";
                seans11.BackColor = Color.Red;
                kontrol = true;
            }
            else if (kontrol == true && seans11.BackColor == Color.Red)
            {
                seans = "";
                seans11.BackColor = Color.Lime;
                kontrol = false;
            }
        }

        private void seans15_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                seans = "15:00-16:00";
                seans15.BackColor = Color.Red;
                kontrol = true;
            }
            else if (kontrol == true && seans15.BackColor == Color.Red)
            {
                seans = "";
                seans15.BackColor = Color.Lime;
                kontrol = false;
            }
        }

        private void seans14_Click(object sender, EventArgs e)
        {

            if (kontrol == false)
            {
                seans = "14:00-15:00";
                seans14.BackColor = Color.Red;
                kontrol = true;
            }
            else if (kontrol == true && seans14.BackColor == Color.Red)
            {
                seans = "";
                seans14.BackColor = Color.Lime;
                kontrol = false;
            }
        }

        private void seans13_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                seans = "13:00-14:00";
                seans13.BackColor = Color.Red;
                kontrol = true;
            }
            else if (kontrol == true && seans13.BackColor == Color.Red)
            {
                seans = "";
                seans13.BackColor = Color.Lime;
                kontrol = false;
            }
        }



    }
}
