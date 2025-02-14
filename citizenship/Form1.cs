using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citizenship;

namespace citizenship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
           InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            People people1 = new People();
            people1.NameSurname = "ULKU AKCALI";
            people1.Alive = true;

            People people2 = new People();
            people2.NameSurname = "Nilufer Beyza Kilic";
            people2.Alive = true;

            People people3 = new People();
            people3.NameSurname = "Halil Akcali";
            people3.Alive = false;

            MessageBox.Show(People.Hi()); // İnsan sınıfındaki Hi metodunu çağır
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Europecitizen ct2 = new Europecitizen();
            ct2.Birthdate = DateTime.Now;
            MessageBox.Show(ct2.Legal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USCitizen ct1 = new USCitizen();
            ct1.Birthdate = Convert.ToDateTime("2000-01-01"); // 'Birtdaydate' yerine 'Birthdate' kullanıldı, tarih formatı düzeltildi
            MessageBox.Show(ct1.Legal());
        }
    }
}