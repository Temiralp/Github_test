using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Mysql kodlarını kullanmak için Referanslardan mysql.data referansını eklemek ve bu isim uzayını eklemeniz gerekiyor.

namespace hastane_otomasyon
{
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) // button 3 admin girişi yazan butonumuz.
  
        {// Hastanede yatanlar isimli butona tıkladığımızda
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT hastalar.adi, hastalar.soyadi, hastalar.DogumYeri, yatisverilenler.yatisTarihi FROM yatisverilenler INNER JOIN hastalar ON yatisverilenler.yatanTC = hastalar.TC",formlar.baglanti);
            // mysqldataadapter oluşturduk ve içerisine sql cümlemizi yazdık.
            formlar.dataGridVeri(mda, formlar.formHastanedeYatanlar.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
                                                                                    // çağırdık ve o fonksiyon verdiğimiz sql cümlesi ile formlar.formHastanedeYatanlar.dataGridView1'i istediğimiz bilgilerle doldurdu..
<<<<<<< HEAD

            InitializeComponent();

            // formlar klasında tanımladığımız formHastanedeYatanlar formumuzu göstertiyoruz.

            this.Hide(); // Bu ana ekran formumuzu gizledik.
=======
            this.Hide();// formlar klasında tanımladığımız formHastanedeYatanlar formumuzu göstertiyoruz.
            formlar.dataGridVeri(mda, formlar.formHastanedeYatanlar.dataGridView1);
>>>>>>> kayit
        }

        private void button5_Click(object sender, EventArgs e)
        {// Taburcu olan hastalar isimli buton kodları
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT hastalar.adi,hastalar.soyadi,hastalar.DogumYeri,taburcular.cikisTarihi FROM taburcular INNER JOIN hastalar ON taburcular.TC = hastalar.TC", formlar.baglanti);
            // mysqldataadapter oluşturduk ve içerisine sql cümlemizi yazdık.
            formlar.dataGridVeri(mda, formlar.formtaburcuOlanlar.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
            // çağırdık ve o fonksiyon verdiğimiz sql cümlesi ile formlar.formtaburcuOlanlar.dataGridView1'i istediğimiz bilgilerle doldurdu..
            formlar.formtaburcuOlanlar.Show(); // formlar klasında tanımladığımız formtaburcuOlanlar formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void button4_Click(object sender, EventArgs e)
        {// Nakil giden hastalar isimli buton kodları
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT nakiller.nakiledilenHastane, hastalar.adi, hastalar.soyadi, doktorlar.doktorAdiSoyadi FROM hastalar INNER JOIN nakiller ON nakiller.nakilTC = hastalar.TC INNER JOIN doktorlar ON nakiller.doktorID = doktorlar.doktorID", formlar.baglanti);
            // mysqldataadapter oluşturduk ve içerisine sql cümlemizi yazdık.
            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
            // çağırdık ve o fonksiyon verdiğimiz sql cümlesi ile formlar.formNakiller.dataGridView1'i istediğimiz bilgilerle doldurdu..
            formlar.formNakiller.Show(); // formlar klasında tanımladığımız formNakiller formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }
        private void button5_Click(object sender, EventArgs e)
        {// Nakil giden hastalar isimli buton kodları
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT nakiller.nakiledilenHastane, hastalar.adi, hastalar.soyadi, doktorlar.doktorAdiSoyadi FROM hastalar INNER JOIN nakiller ON nakiller.nakilTC = hastalar.TC INNER JOIN doktorlar ON nakiller.doktorID = doktorlar.doktorID", formlar.baglanti);
            // mysqldataadapter oluşturduk ve içerisine sql cümlemizi yazdık.
            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
            // çağırdık ve o fonksiyon verdiğimiz sql cümlesi ile formlar.formNakiller.dataGridView1'i istediğimiz bilgilerle doldurdu..
 
        }


        private void button6_Click(object sender, EventArgs e)
        {// Nakil giden hastalar isimli buton kodları
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT nakiller.nakiledilenHastane, hastalar.adi, hastalar.soyadi, doktorlar.doktorAdiSoyadi FROM hastalar INNER JOIN nakiller ON nakiller.nakilTC = hastalar.TC INNER JOIN doktorlar ON nakiller.doktorID = doktorlar.doktorID", formlar.baglanti);
            // mysqldataadapter oluşturduk ve içerisine sql cümlemizi yazdık.
            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
                                                                           // çağırdık ve o fonksiyon verdiğimiz sql cümlesi ile formlar.formNakiller.dataGridView1'i istediğimiz bilgilerle doldurdu..

        }
        private void kayit_yoneticisik(object sender, EventArgs e)
        {// Nakil giden hastalar isimli buton kodları
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT nakiller.nakiledilenHastane, hastalar.adi, hastalar.soyadi, doktorlar.doktorAdiSoyadi FROM hastalar INNER JOIN nakiller ON nakiller.nakilTC = hastalar.TC INNER JOIN doktorlar ON nakiller.doktorID = doktorlar.doktorID", formlar.baglanti);
            // mysqldataadapter oluşturduk ve içerisine sql cümlemizi yazdık.
            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
                                                                           // çağırdık ve o fonksiyon verdiğimiz sql cümlesi ile formlar.formNakiller.dataGridView1'i istediğimiz bilgilerle doldurdu..
            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu

            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu

            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
        }
        private void kayit_yoneticisik2(object sender, EventArgs e)
        {// Nakil giden hastalar isimli buton kodları
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT nakiller.nakiledilenHastane, hastalar.adi, hastalar.soyadi, doktorlar.doktorAdiSoyadi FROM hastalar INNER JOIN nakiller ON nakiller.nakilTC = hastalar.TC INNER JOIN doktorlar ON nakiller.doktorID = doktorlar.doktorID", formlar.baglanti);
            // mysqldataadapter oluşturduk ve içerisine sql cümlemizi yazdık.
            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
                                                                           // çağırdık ve o fonksiyon verdiğimiz sql cümlesi ile formlar.formNakiller.dataGridView1'i istediğimiz bilgilerle doldurdu..
            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu

            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu

            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
        }
        private void SET(object sender, EventArgs e)
        {// Nakil giden hastalar isimli buton kodları
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT nakiller.nakiledilenHastane, hastalar.adi, hastalar.soyadi, doktorlar.doktorAdiSoyadi FROM hastalar INNER JOIN nakiller ON nakiller.nakilTC = hastalar.TC INNER JOIN doktorlar ON nakiller.doktorID = doktorlar.doktorID", formlar.baglanti);
            // mysqldataadapter oluşturduk ve içerisine sql cümlemizi yazdık.
            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
                                                                           // çağırdık ve o fonksiyon verdiğimiz sql cümlesi ile formlar.formNakiller.dataGridView1'i istediğimiz b
        }
        private void gET(object sender, EventArgs e)
        {// Nakil giden hastalar isimli buton kodları
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT nakiller.nakiledilenHastane, hastalar.adi, hastalar.soyadi, doktorlar.doktorAdiSoyadi FROM hastalar INNER JOIN nakiller ON nakiller.nakilTC = hastalar.TC INNER JOIN doktorlar ON nakiller.doktorID = doktorlar.doktorID", formlar.baglanti);
            // mysqldataadapter oluşturduk ve içerisine sql cümlemizi yazdık.
            formlar.dataGridVeri(mda, formlar.formNakiller.dataGridView1); // formlar tablosunda dataGridVeri isimli fonksiyonu
                                                                           // çağırdık ve o fonksiyon verdiğimiz sql cümlesi ile formlar.formNakiller.dataGridView1'i istediğimiz b
        }
    }
