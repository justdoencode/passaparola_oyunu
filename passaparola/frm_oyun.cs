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
    public partial class frm_oyun : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=passaparola;Integrated Security=True");
        public frm_oyun()
        {
            InitializeComponent();
        }
        private void frm_oyun_Load(object sender, EventArgs e)
        {
            btn_cevapla.Enabled = false;
        }
        void soru(int soru)
        {
            int soruno = soru;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select* from tbl_sorular where soru_id=@id", baglanti);
            cmd.Parameters.AddWithValue("@id", soruno);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = dr[1].ToString();
            }
            baglanti.Close();
        }
        void dogru(int numara)
        {
            switch (numara)
            {
                case 1: button1.BackColor = Color.Green;break;
                case 2:button2.BackColor = Color.Green;break;
                case 3: button3.BackColor = Color.Green; break;
                case 4: button4.BackColor = Color.Green; break;
                case 5: button5.BackColor = Color.Green; break;
                case 6: button6.BackColor = Color.Green; break;
                case 7: button7.BackColor = Color.Green; break;
                case 8: button8.BackColor = Color.Green; break;
                case 9: button9.BackColor = Color.Green; break;
                case 10: button10.BackColor = Color.Green; break;
                case 11: button11.BackColor = Color.Green; break;
                case 12: button12.BackColor = Color.Green; break;
                case 13: button13.BackColor = Color.Green; break;
                case 14: button14.BackColor = Color.Green; break;
                case 15: button15.BackColor = Color.Green; break;
                case 16: button16.BackColor = Color.Green; break;
                case 17: button17.BackColor = Color.Green; break;
                case 18: button18.BackColor = Color.Green; break;
                case 19: button19.BackColor = Color.Green; break;
                case 20: button20.BackColor = Color.Green; break;
                case 21: button21.BackColor = Color.Green; break;
                case 22: button22.BackColor = Color.Green; break;
                case 23: button23.BackColor = Color.Green; break;
                case 24: button24.BackColor = Color.Green; break;
            }
        }
        void yanlis(int numara)
        {
            switch (numara)
            {
                case 1: button1.BackColor = Color.Red; break;
                case 2: button2.BackColor = Color.Red; break;
                case 3: button3.BackColor = Color.Red; break;
                case 4: button4.BackColor = Color.Red; break;
                case 5: button5.BackColor = Color.Red; break;
                case 6: button6.BackColor = Color.Red; break;
                case 7: button7.BackColor = Color.Red; break;
                case 8: button8.BackColor = Color.Red; break;
                case 9: button9.BackColor = Color.Red; break;
                case 10: button10.BackColor = Color.Red; break;
                case 11: button11.BackColor = Color.Red; break;
                case 12: button12.BackColor = Color.Red; break;
                case 13: button13.BackColor = Color.Red; break;
                case 14: button14.BackColor = Color.Red; break;
                case 15: button15.BackColor = Color.Red; break;
                case 16: button16.BackColor = Color.Red; break;
                case 17: button17.BackColor = Color.Red; break;
                case 18: button18.BackColor = Color.Red; break;
                case 19: button19.BackColor = Color.Red; break;
                case 20: button20.BackColor = Color.Red; break;
                case 21: button21.BackColor = Color.Red; break;
                case 22: button22.BackColor = Color.Red; break;
                case 23: button23.BackColor = Color.Red; break;
                case 24: button24.BackColor = Color.Red; break;
            }
        }
        void ortabuton(int numara)
        {
            switch (numara)
            {
                case 1:btn_orta.Text = "A";break;
                case 2: btn_orta.Text = "B"; break;
                case 3: btn_orta.Text = "C"; break;
                case 4: btn_orta.Text = "D"; break;
                case 5: btn_orta.Text = "E"; break;
                case 6: btn_orta.Text = "F"; break;
                case 7: btn_orta.Text = "G"; break;
                case 8: btn_orta.Text = "H"; break;
                case 9: btn_orta.Text = "I"; break;
                case 10: btn_orta.Text = "İ"; break;
                case 11: btn_orta.Text = "J"; break;
                case 12: btn_orta.Text = "K"; break;
                case 13: btn_orta.Text = "L"; break;
                case 14: btn_orta.Text = "M"; break;
                case 15: btn_orta.Text = "N"; break;
                case 16: btn_orta.Text = "O"; break;
                case 17: btn_orta.Text = "P"; break;
                case 18: btn_orta.Text = "R"; break;
                case 19: btn_orta.Text = "S"; break;
                case 20: btn_orta.Text = "T"; break;
                case 21: btn_orta.Text = "U"; break;
                case 22: btn_orta.Text = "V"; break;
                case 23: btn_orta.Text = "Y"; break;
                case 24: btn_orta.Text = "Z"; break;
            }
        }
        int dogrucevap = 0, yanliscevap = 0;
        void cevap(int id,string cevap)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select cevap from tbl_sorular where soru_id=@id", baglanti);
            cmd2.Parameters.AddWithValue("@id", id);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string asilcevap = dr2[0].ToString();
                if (asilcevap == cevap)
                {
                    dogru(id);
                    btn_orta.BackColor = Color.Green;
                    dogrucevap++;
                }
                else
                {
                    yanlis(id);
                    btn_orta.BackColor = Color.Red;
                    yanliscevap++;
                    int size = 15;
                    btn_orta.Font = new Font(btn_orta.Font.FontFamily, size);
                    btn_orta.Text ="Doğru Cevap\n"+ dr2[0].ToString();
                }
            }
            baglanti.Close();
        }
        int soruno = 1;
        int cevapno = 1;
        private void btn_cevapla_Click(object sender, EventArgs e)
        {
            cevap(cevapno, txt_cevap.Text);
            cevapno++;
            txt_cevap.Clear();
            richTextBox1.Clear();
            btn_sorual.Enabled = true;
            btn_cevapla.Enabled = false;
            if(cevapno==25)
                MessageBox.Show("Doğru Cevap Sayısı : "+dogrucevap+"\nYanlış Cevap Sayısı : "+yanliscevap);
        }
        private void button28_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_sorual_Click(object sender, EventArgs e)
        {
            int size = 72;
            btn_orta.Font = new Font(btn_orta.Font.FontFamily, size);
            btn_orta.BackColor = Color.Silver;
            soru(soruno);
            ortabuton(soruno);
            btn_sorual.Enabled = false;
            btn_cevapla.Enabled = true;
            soruno++;
        }
    }
}
