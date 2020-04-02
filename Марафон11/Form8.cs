using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон11
{
    public partial class Runner : Form
    {
        public Runner()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Runner CheckRunner = new Runner();
            CheckRunner.Show();
            this.Hide();

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
