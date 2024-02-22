using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D32
{
    public partial class Form1 : Form
    {
        int totalTime = 0;
        int remainingTime = 0;

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            if (remainingTime <= 0)
            {
                timer1.Stop();
                button2.Enabled = false;
                MessageBox.Show("Таймер сработал", "TIMER");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Выберите время");
                button1.Enabled = false;
                return;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                totalTime = Decimal.ToInt32(numericUpDown1.Value );
                remainingTime = totalTime ;
                timer1.Interval = 1000;  
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = false;
            MessageBox.Show($"Осталось времени: {remainingTime} секунд");
        }
    }
}
