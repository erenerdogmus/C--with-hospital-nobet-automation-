using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;



namespace hastane_nobett
{
    public partial class Form1 : Form
    {
        static string conString = "Data Source=DESKTOP-8E8HBS2\\SQLEXPRESS;Initial Catalog=nobet;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.PerformClick();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "\n";
            label2.Text = "\n";
            label3.Text = "\n";
            label4.Text = "\n";
            label5.Text = "\n";
            label6.Text = "\n";
            label7.Text = "\n";
            int l_sayı = listBox1.Items.Count;
            int[] isimler = new int[l_sayı];
            Random rnd = new Random();
            int i = 0;
            while (i < 10)
            {
                int secim = rnd.Next(0, l_sayı);
                if (Array.IndexOf(isimler, secim) == -1)
                {
                    isimler[i] = secim;
                    label1.Text += listBox1.Items[secim] + "\n";
                    i++;
                }
            }
            while (i < 20)
            {
                int secim = rnd.Next(0, l_sayı);
                if (Array.IndexOf(isimler, secim) == -1)
                {
                    isimler[i] = secim;
                    label2.Text += listBox1.Items[secim] + "\n";
                    i++;
                }
            }
            while (i < 30)
            {
                int secim = rnd.Next(0, l_sayı);
                if (Array.IndexOf(isimler, secim) == -1)
                {
                    isimler[i] = secim;
                    label3.Text += listBox1.Items[secim] + "\n";
                    i++;
                }
            }
            while (i < 40)
            {
                int secim = rnd.Next(0, l_sayı);
                if (Array.IndexOf(isimler, secim) == -1)
                {
                    isimler[i] = secim;
                    label4.Text += listBox1.Items[secim] + "\n";
                    i++;
                }
            }
            while (i < 50)
            {
                int secim = rnd.Next(0, l_sayı);
                if (Array.IndexOf(isimler, secim) == -1)
                {
                    isimler[i] = secim;
                    label5.Text += listBox1.Items[secim] + "\n";
                    i++;
                }
            }
            while (i < 60)
            {
                int secim = rnd.Next(0, l_sayı);
                if (Array.IndexOf(isimler, secim) == -1)
                {
                    isimler[i] = secim;
                    label6.Text += listBox1.Items[secim] + "\n";
                    i++;
                }
            }
            while (i < 70)
            {
                int secim = rnd.Next(0, l_sayı);
                if (Array.IndexOf(isimler, secim) == -1)
                {
                    isimler[i] = secim;
                    label7.Text += listBox1.Items[secim] + "\n";
                    i++;
                }
            }

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            connect.Open();
            SqlCommand komut = new SqlCommand("select * from hastanenobet", connect);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                listBox1.Items.Add(rd[1]);
            }
            connect.Close();
        }

        private void button2_click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if(secim != -1)
            {
                listBox1.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Nesne Seçin");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int güncelle = listBox1.SelectedIndex;
            listBox1.Items[güncelle] = textBox1.Text;
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
