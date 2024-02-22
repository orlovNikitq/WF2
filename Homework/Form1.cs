using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> countriesAndCities = new Dictionary<string, List<string>>();
        public Form1()
        {
            InitializeComponent();
            countriesAndCities.Add("Россия", new List<string> { "Москва", "Санкт-Петербург", "Новосибирск" });
            countriesAndCities.Add("США", new List<string> { "Нью-Йорк", "Лос-Анджелес", "Чикаго" });
            foreach (var el in countriesAndCities)
            {
                comboBox1.Items.Add(el.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    Questionnaire que = new Questionnaire
                    {
                        surname = textBox1.Text,
                        name = textBox2.Text,
                        patronymic = textBox3.Text,
                        country = comboBox1.Text,
                        city = comboBox2.Text,
                        phone = textBox4.Text,
                        date = dateTimePicker1.Text,  
                        gender = radioButton1.Checked ? "Мужской" : "Женский"
                    };

                    MessageBox.Show(que.ToString());
                }
                else MessageBox.Show("Выберите пол");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string selectedCountry = comboBox1.SelectedItem.ToString();
            if (countriesAndCities.ContainsKey(selectedCountry))
            {
                foreach (var city in countriesAndCities[selectedCountry])
                {
                    comboBox2.Items.Add(city);
                }
            }
        }

    }
}
