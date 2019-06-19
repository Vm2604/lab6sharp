using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab6_GUI
{
    public partial class Form1 : Form
    {
        Parametr p_1;
        Parametr p_2;
        public Form1()
        {           
            InitializeComponent();           
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int digit = Convert.ToInt32(Digit.Text);           
            int size_interval = digit / 2;

            p_1 = new Parametr(2, size_interval);
            p_2 = new Parametr(2, digit);

            Thread t = new Thread(new ThreadStart(p_1.Work)); //создаем поток в качестве параметров передаем класс
            t.Start(); //запускаем новый поток
            Thread.Sleep(100);
            p_2.Work(); //запускаем метод в главном потоке 

            Main_thread.Text = p_2.result;
            richTextBox1.Text = p_1.result;
        }

        private void Main_thread_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
