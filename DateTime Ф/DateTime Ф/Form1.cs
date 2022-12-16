using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Ф
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int leapYear
        {
            get
            {
                int year;
                Console.Write("Введите год:");
                do
                {
                    if (Int32.TryParse(Console.ReadLine(), out year))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }

                }
                while (true);
                return year;
            }
            set
            {
                leapYear = 0;
            }
        }

        void days()
        {
            DateTime now = dateTimePicker1.Value;
            DateTime yesterday = now.AddDays(-1);
            DateTime tomorrow = now.AddDays(1);
            int daysLeft = DateTime.DaysInMonth(now.Year, now.Month) - now.Day;
            richTextBox1.Text += "Сегодня: " + now.ToString("dd.MM.yyyy")
                + "\nВчера: " + yesterday.ToString("dd.MM.yyyy")
                + "\nЗавтра: " + tomorrow.ToString("dd.MM.yyyy")
                + "\nОсталось дней до конца месяца: " + daysLeft;
        }

        string leap()
            {
                string yes;
                bool lea = DateTime.IsLeapYear(Convert.ToInt32(numericUpDown1.Value));
                if (lea == true) { yes = "Высокосный"; } else { yes = "Не высокосный"; }
                return yes;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            
            days();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { richTextBox2.Text = leap(); }
            catch { MessageBox.Show("Год должен быть больше 0"); }
            
        }
    }
}
