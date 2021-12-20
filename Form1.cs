using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-CPQPLH9\SQLEXPRESS;Initial Catalog=yurtkayıt;Integrated Security=True");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT bolumAd FROM Bolumler", baglantı);
            SqlDataReader oku =komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
            }

            baglantı.Close();

            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("SELECT odano FROM odalar where odakapasite !=odaaktif",baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read()) 
            {

                CMBoda.Items.Add(oku2[0].ToString());
            }
            baglantı.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand kaydet = new SqlCommand("insert into ogrencı(ogrAdı,ogrSoyadı,ogrTc,ogrTelefon,ogrDogum,ogrOdano,ogrBolum,ogrMail,OgrVeliadsoyad,ogrvelitelefon,ogrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglantı);
            kaydet.Parameters.AddWithValue("@p1", textBox1.Text);
            kaydet.Parameters.AddWithValue("@P2", textBox2.Text);
            kaydet.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            kaydet.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            kaydet.Parameters.AddWithValue("@p5", maskedTextBox3.Text);
            kaydet.Parameters.AddWithValue("@P6", CMBoda.Text);
            kaydet.Parameters.AddWithValue("@P7", comboBox1.Text);
            kaydet.Parameters.AddWithValue("@p8", textBox3.Text);
            kaydet.Parameters.AddWithValue("@p9", textBox4.Text);
            kaydet.Parameters.AddWithValue("@p10", maskedTextBox4.Text);
            kaydet.Parameters.AddWithValue("@p11", RchAdres.Text);
            kaydet.ExecuteNonQuery();
            baglantı.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
//DESKTOP-CPQPLH9\SQLEXPRESS
