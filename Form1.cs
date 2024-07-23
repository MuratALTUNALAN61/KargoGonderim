using System.Data.SqlClient;
using System.Data.SqlTypes;
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

            SqlCommand komut = new SqlCommand("select * from dbo.IL", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
               
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
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxTc.Clear();
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

        }
    }
}