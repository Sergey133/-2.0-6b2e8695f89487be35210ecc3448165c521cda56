using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Марафон11
{
    public partial class Sponsor : Form
    {
        public Sponsor()
        {
            InitializeComponent();
        }
        private void check()
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textBox6.Text == "" | comboBox1.Text == "") button3.Enabled = false; else button3.Enabled = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sponsor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maraphonDataSet.Runner". При необходимости она может быть перемещена или удалена.
         

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0) textBox2.Text = "0";
            label13.Text = textBox6.Text;
            if (Convert.ToInt32(textBox6.Text) <= 0)
            {
                MessageBox.Show("Вы должны пожертвовать хотя бы 1$");
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }

        }

        private void time_Click(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("21.10.2017 6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            time.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " + time1.Minutes.ToString() + " минут до старта марафона!";

        }
    }
}
