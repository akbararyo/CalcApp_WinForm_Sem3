using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorMachine;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text); //casting
            var b = Convert.ToInt32(txtNilaiB.Text); //casting
            var cal = new Calculator();

            lstHasil.Items.Clear(); //kosongkan isi listbox

            //tampilkan hasil semua hasil pemanggilan method calculator ke dalam listbox
            lstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, cal.Penambahan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} x {1} = {2}", a, b, cal.Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} % {1} = {2}", a, b, Calculator.Modulo(a, b)));
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text); //casting
            var b = Convert.ToInt32(txtNilaiB.Text); //casting

            var cal = new Calculator();

            listBox.Items.Clear(); //kosongkan isi listbox

            var perhitungan = comboBox.Text;

            if (perhitungan == "Penjumlahan")
            {
                listBox.Items.Add(string.Format("{0}", cal.Penambahan(a, b)));
            }
            else if (perhitungan == "Pengurangan")
            {
                listBox.Items.Add(string.Format("{0}", cal.Pengurangan(a, b)));
            }
            else if (perhitungan == "Perkalian")
            {
                listBox.Items.Add(string.Format("{0}", cal.Perkalian(a, b)));
            }
            else if (perhitungan == "Pembagian")
            {
                listBox.Items.Add(string.Format("{0}", Calculator.Pembagian(a, b)));
            }
            else if (perhitungan == "Pangkat")
            {
                listBox.Items.Add(string.Format("{0}", cal.Pangkat(a, b)));
            }
            else if (perhitungan == "Modulo")
            {
                listBox.Items.Add(string.Format("{0}", Calculator.Modulo(a, b)));
            }
        }
    }
}
