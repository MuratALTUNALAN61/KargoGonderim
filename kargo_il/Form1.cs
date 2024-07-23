using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing.Printing;
using System.Numerics;
using System.Windows.Forms;

namespace kargo_il
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8J8VAOJ\\SQLEXPRESS03;Initial Catalog=kargo_il;Integrated Security=SSPI");
        

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonBireysel.Checked = true;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from dbo.IL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["adi"]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select adi from dbo.ILCE where dbo.ILCE.refilid=" + (comboBox1.SelectedIndex + 1), baglanti);
            SqlDataReader dr2;
            baglanti.Open();
            dr2 = komut2.ExecuteReader();
            comboBox2.Items.Clear();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2["adi"]);
            }
            baglanti.Close();
        }

        private void textBoxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
            else if (textBoxTc.Text.Length == 0)
            {
                if (e.KeyChar == '0')
                {
                    e.Handled = true;
                    errorProvider1.SetError(textBoxTc, "Ýlk rakam 0(sýfýr) olamaz!");
                }
                else
                {
                    e.Handled = false;
                    errorProvider1.Clear();
                }
            }
            else if (textBoxTc.Text.Length == 9)
            {
                int[] tc = new int[textBoxTc.Text.Length];
                for (int i = 0; i < textBoxTc.Text.Length; i++)
                {
                    tc[i] = (int)char.GetNumericValue(textBoxTc.Text[i]);
                }
                int tektoplam = 0;
                for (int i = 0; i <= 8; i += 2)
                {
                    tektoplam += tc[i];
                }
                tektoplam *= 7;
                int cift = 0;
                for (int i = 1; i <= 7; i += 2)
                {
                    cift += tc[i];
                }
                cift *= 9;
                int haneOn = (tektoplam + cift) % 10;
                if (e.KeyChar.ToString() != haneOn.ToString())
                {
                    errorProvider1.SetError(textBoxTc, "Tc kimlik numarasýný doðru giriniz!");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else if (textBoxTc.Text.Length == 10)
            {
                int[] tc = new int[textBoxTc.Text.Length];
                for (int i = 0; i < textBoxTc.Text.Length; i++)
                {
                    tc[i] = (int)char.GetNumericValue(textBoxTc.Text[i]);
                }
                int toplam = 0;
                for (int i = 0; i < textBoxTc.Text.Length; i++)
                {
                    toplam += textBoxTc.Text[i];
                }
                int haneOnbir = toplam % 10;
                if (e.KeyChar.ToString() != haneOnbir.ToString())
                {
                    errorProvider1.SetError(textBoxTc, "Tc kimlik numarasýný doðru giriniz!");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void radioButtonBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBireysel.Checked == true)
            {
                textBoxAd.Enabled = true;
                textBoxSoyad.Enabled = true;
                textBoxTc.Enabled = true;
                textBoxKurumAd.Enabled = false;
                textBoxMersis.Enabled = false;
                lblKurum.Enabled = false;
                lblMersis.Enabled = false;
                lblAd.Enabled = true;
                lblSoyad.Enabled = true;
                lblTc.Enabled = true;
                textBoxKurumAd.Clear();
                textBoxMersis.Clear();

            }
        }

        private void radioButtonKurumsal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKurumsal.Checked == true)
            {
                textBoxKurumAd.Enabled = true;
                textBoxMersis.Enabled = true;
                textBoxAd.Enabled = false;
                textBoxSoyad.Enabled = false;
                textBoxTc.Enabled = false;
                lblKurum.Enabled = true;
                lblMersis.Enabled = true;
                lblAd.Enabled = false;
                lblSoyad.Enabled = false;
                lblTc.Enabled = false;
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxTc.Clear();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (baglanti)
            {
                baglanti.Open();
                using (SqlCommand komut2 = new SqlCommand("insert into Kargo (g_ad,g_soyad,g_adres) values ('@gondericiAd','@gondericiSoyad','@gondericiAdres')", baglanti))
                {
                    komut2.Parameters.AddWithValue("@gondericiAd", textBoxAd.Text);
                    komut2.Parameters.AddWithValue("@gondericiSoyad", textBoxSoyad.Text);
                    komut2.Parameters.AddWithValue("@gondericiAdres", comboBox1.Text);
                    int eklenenSatýrlar = komut2.ExecuteNonQuery();  
                    if (eklenenSatýrlar > 0)
                    {
                        MessageBox.Show("kaydedildi");
                    }
                    else
                    {
                        MessageBox.Show("hata oluþtu");
                    }
                }
                baglanti.Close();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (baglanti)
            {
                string gonderiNo, g_ad, g_soyad, g_adres;
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select gonderiNo,g_ad,g_soyad,g_adres from kargo where id=(select max(id) from kargo)", baglanti);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    gonderiNo = rdr["gonderiNo"].ToString();
                    g_ad = rdr["g_ad"].ToString();
                    g_soyad = rdr["g_soyad"].ToString();
                    g_adres = rdr["g_adres"].ToString();
                }
                else
                {
                    Console.WriteLine("kayýt bulunamadý");
                }
                baglanti.Close();

                Font font = new Font("arrial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                e.Graphics.DrawString("gönderi no: ", font, firca, 61, 150);
                e.Graphics.DrawString("gönderici adý: ", font, firca, 61, 200);
                e.Graphics.DrawString("gönderen soyadý: ", font, firca, 61, 300);
                e.Graphics.DrawString("gönderen adresi: ", font, firca, 61, 350);

                e.Graphics.DrawString(gonderiNo, font, firca, 61, 250);
                e.Graphics.DrawString(g_ad, font, firca, 61, 300);
                e.Graphics.DrawString(g_soyad, font, firca, 61, 400);
                e.Graphics.DrawString(g_adres, font, firca, 61, 450);
            }
        }
        private void comboBox2_Leave(object sender, EventArgs e)
        {        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {        }
        private void comboBox1_Leave(object sender, EventArgs e)
        {        }
    }
}