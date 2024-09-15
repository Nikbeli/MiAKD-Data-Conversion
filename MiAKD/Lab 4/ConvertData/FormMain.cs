using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertData
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Date.Text == "День месяц и год")
            {
                textBox_result.Text = dateTimePicker1.Value.ToLongDateString();
            }

            if (comboBox_Date.Text == "День/Месяц/Год кратко")
            {
                textBox_result.Text = dateTimePicker1.Value.ToShortDateString();
            }

            if (comboBox_Date.Text == "Полная запись времени")
            {
                textBox_result.Text = dateTimePicker1.Value.ToLongTimeString();
            }

            if (comboBox_Date.Text == "Краткая запись времени")
            {
                textBox_result.Text = dateTimePicker1.Value.ToShortTimeString();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // dateTimePicker1.Value = DateTime.Now;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm:ss dd.MM.yyyy 'г.'";

            // Добавление в ComboBox
            comboBox_Date.Items.Add("День месяц и год");
            comboBox_Date.Items.Add("День/Месяц/Год кратко");
            comboBox_Date.Items.Add("Полная запись времени");
            comboBox_Date.Items.Add("Краткая запись времени");

            comboBox_format.Items.Add("Год");
            comboBox_format.Items.Add("Месяц");
            comboBox_format.Items.Add("День");
            comboBox_format.Items.Add("Час");
            comboBox_format.Items.Add("Минуту");
            comboBox_format.Items.Add("Секунду");
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (comboBox_format.Text == "Год")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddYears(Decimal.ToInt32((numericUpDown_operations.Value)));
            }

            if (comboBox_format.Text == "Месяц")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(Decimal.ToInt32((numericUpDown_operations.Value)));
            }

            if (comboBox_format.Text == "День")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(Decimal.ToInt32((numericUpDown_operations.Value)));
            }

            if (comboBox_format.Text == "Час")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddHours(Decimal.ToInt32((numericUpDown_operations.Value)));
            }

            if (comboBox_format.Text == "Минуту")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(Decimal.ToInt32((numericUpDown_operations.Value)));
            }

            if (comboBox_format.Text == "Секунду")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddSeconds(Decimal.ToInt32((numericUpDown_operations.Value)));
            }
        }

        private void button_convertToString_Click(object sender, EventArgs e)
        {
            textBox_string.Text = dateTimePicker1.Value.ToString();
        }

        private void button_converttodata_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Parse(textBox_string.Text);
        }
    }
}
