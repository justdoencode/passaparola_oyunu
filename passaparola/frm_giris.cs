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

namespace passaparola
{
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=passaparola;Integrated Security=True");
        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_kullanici (kullanici_adi,kullanici_sifre) values (@ad,@sifre)", baglanti);
            cmd.Parameters.AddWithValue("@ad", txt_yenikullaniciadi.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_yenisifre.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            lbl_cevap.Text = "Kullanıcı Kaydedildi";
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btn_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select * from tbl_kullanici where kullanici_adi=@ad and kullanici_sifre=@sifre", baglanti);
            cmd2.Parameters.AddWithValue("@ad", txt_kullaniciadi.Text);
            cmd2.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            if(dr.Read())
            {
                frm_oyun frmoyun = new frm_oyun();
                frmoyun.lbl_oyuncu.Text = dr[1].ToString();
                frmoyun.Show();
            }
            else
            {
                lbl_bilgi.Text = "Kullanıcı Adı Veya Şifre Hatalı";
            }
            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_bilgi_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_cevap_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_yenikullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_yenisifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
