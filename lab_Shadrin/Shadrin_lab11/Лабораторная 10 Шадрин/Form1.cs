using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_10_Шадрин
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Программа вычисления массы";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double _Forse = Convert.ToDouble(textBox1.Text);
            double _Height = Convert.ToDouble(textBox2.Text);
            double _Mass;
            _Mass = (_Forse * _Height) / (9.8 * _Height);
            MessageBox.Show("Значение Массы = " + _Mass);            
        }      
    }
}
