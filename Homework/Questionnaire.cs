using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public class Questionnaire
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string date { get; set; }
        public string gender { get; set; }

        public override string ToString()
        {
            return $"surname = {surname},name = {name},patronymic = {patronymic},country = {country}, city = {city},phone = {phone},date = {date}, gender = {gender}";
        }
    }
}
