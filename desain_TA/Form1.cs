using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desain_TA
{
    public partial class Form1 : Form
    {
        float d1, d2, d3, d4, d5, d6;
        Form2 buka = new Form2();
        public Form1()
        {
            InitializeComponent();
            d1 = 40000;
            d2 = 70000;
            d3 = 47000;
            d4 = 82000;
            d5 = 45000;
            d6 = 93000;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
  
        }

        public float pajak(float uang)
        {
            float potong, potongan, duit=0;
            if (uang == nominal)
            {
                potongan = 10000;
                potong = uang - potongan;
                duit = potong;
            }
            else if ((uang==harga_akhir)|| (uang == terakhir))
            {
                duit = uang;
            }
            return duit;
  
        }

        public float keluar(float money)
        {
            return money;
        }


        private void Night_DoubleClick(object sender, EventArgs e)
        {
            buka.Show();
            string isi;
            isi = "View dari tebing bebatuan \n" +
                "Memperlihatkan hamparan pohon pinus\n" +
                "dengan sinar bulan yang terang.";
            buka.pesan(isi);
        }

        private void Door_DoubleClick(object sender, EventArgs e)
        {
            buka.Show();
            string isi;
            isi = "Logo pintu yang digabungkan dengan huruf D \n" +
                "Cocok dipakai untuk perusahaan interior \n" +
                "Menggunakan warna merah agar lebih memikat.";
            buka.pesan(isi);

        }

        private void UFO_DoubleClick(object sender, EventArgs e)
        {
            buka.Show();
            string isi;
            isi = "sebuah ufo yang terbang ditengah malam  \n" +
                "ditengah bangku taman \n" +
                "diantara lampu yang berpijar.";
            buka.pesan(isi);
        }

        private void Pet_DoubleClick(object sender, EventArgs e)
        {
            buka.Show();
            string isi;
            isi = "Logo yang dapat digunakan untuk petshop \n" +
                "Atau pet hospital"+
                "Logo memiliki bentuk perisai \n"+"melindungi hewan tersebut. \n" +
                "kumis dan cakar kucing yang melambangkan \nhewan peliharaan.";
            buka.pesan(isi);
        }

        private void Wolf_DoubleClick(object sender, EventArgs e)
        {
            buka.Show();
            string isi;
            isi = "Sebuah vector dari serigala yang sedang mengaum \n" +
                "Melambangkan kegarangan dari serigala \n";
            buka.pesan(isi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void isi_Click(object sender, EventArgs e)
        {
            float keluar;
            string isi,isi2;
            for (int i = 1; i <= 2; i++)
            {
                if (i == 1)
                {
                    isi = "Pengisisan saldo akan dikenakan pajak";
                    buka.pesan(isi);
                    buka.ShowDialog();
                }
                if (i == 2)
                {
                    isi2 = "Pajak sebesar Rp.10.000" ;
                    buka.pesan(isi2);
                    buka.ShowDialog();
                } 
            }
            nominal = float.Parse(saldo.Text);
            keluar = pajak(nominal);
            hasil.Text = Convert.ToString(keluar);


        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        float harga_akhir, nominal, terakhir;
     
        private void button_beli_Click(object sender, EventArgs e)
        {
            Form1 harga = new Form1();
            terakhir = float.Parse(hasil.Text);

            if (pilihan.SelectedItem == "Fire")
            {

                harga_akhir = pajak(terakhir) - harga.d1;
                hasil.Text = Convert.ToString(harga_akhir);
                pajak(harga_akhir);
                Fire.Image = Properties.Resources.SOLD_02;
            }
            else if (pilihan.SelectedItem == "Night")
            {
                
                
                harga_akhir = pajak(terakhir) - harga.d2;
                hasil.Text = Convert.ToString(harga_akhir);
                pajak(harga_akhir);
                Night.Image = Properties.Resources.SOLD_02;

            }
            else if (pilihan.SelectedItem == "Door")
            {
          
                harga_akhir = pajak(terakhir) - harga.d3;
                hasil.Text = Convert.ToString(harga_akhir);
                pajak(harga_akhir);
                Door.Image = Properties.Resources.SOLD_02;
            }
            else if (pilihan.SelectedItem == "U.F.O")
            {
           
                harga_akhir = pajak(terakhir) - harga.d4;
                hasil.Text = Convert.ToString(harga_akhir);
                pajak(harga_akhir);
                UFO.Image = Properties.Resources.SOLD_02;
            }
            else if(pilihan.SelectedItem=="Pet shield")
            {
           
                
                harga_akhir = pajak(terakhir) - harga.d5;
                hasil.Text = Convert.ToString(harga_akhir);
                pajak(harga_akhir);
                Pet.Image = Properties.Resources.SOLD_02;
            }
            else if (pilihan.SelectedItem == "Wolf")
            {
                  
                harga_akhir = pajak(terakhir) - harga.d6;
                hasil.Text = Convert.ToString(harga_akhir);
                pajak(harga_akhir);
                Wolf.Image = Properties.Resources.SOLD_02;
            }
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            buka.Show();
            string isi;
            isi = "Api unggun yang menyala memberi kehangatan \n" +
                "Ditengah malam dengan bulan purnama penuh\n" +
                "yang bersinar menerangi malam.";
            buka.pesan(isi);
        }

    }
}
