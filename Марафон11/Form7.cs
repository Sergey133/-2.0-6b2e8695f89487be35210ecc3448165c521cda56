﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Марафон11
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void time_Click(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("21.10.2017 6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            time.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " + time1.Minutes.ToString() + " минут до старта марафона!";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int login = 0;
            string role = "";
            using (SqlConnection conn = new
            SqlConnection(Марафон11.Properties.Settings.Default.MaraphonConnectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Count(*) FROM [User] WHERE Email='" + textBox1.Text + "'AND Password = '" + textBox2.Text + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    login = Convert.ToInt32(reader[0]);
                }
                conn.Close();
                conn.Open();
                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "SELECT RoleId FROM [User] WHERE Email='" + textBox1.Text + "'AND Password = '" + textBox2.Text + "'";
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    role = reader1[0].ToString();
                }
                conn.Close();
            }
            if (login == 1)
            {
                File.WriteAllText("C://login.txt", textBox1.Text);
                if (role == "R")
                {
                    Form3 Runner = new Form3();
                    Runner.Show();
                    this.Hide();
                }
                else
                {
                    if (role == "A")
                    {
                        Admin Admin = new Admin();
                        Admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (role == "C")
                        {
                            Coordinator Coordinator = new Coordinator();
                            Coordinator.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Не правильный логин/пароль.");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
