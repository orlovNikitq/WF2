using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Вы находитесь внутри прямоугольника");
            }
            check(e);
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Вы находитесь на границе прямоугольника");
            }
            check(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Вы находитесь снаружи прямоугольника");
            }
            check(e);
            
        }
        private void check(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show($"Ширина = {ClientSize.Width}, Высота = {ClientSize.Height}");
            }
            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                this.Close();
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Point screenPoint = (sender as Control).PointToScreen(e.Location);
            Point clientPoint = this.PointToClient(screenPoint);
            this.Text = $"X = {clientPoint.X}, Y = {clientPoint.Y}";
        }
    }
}
