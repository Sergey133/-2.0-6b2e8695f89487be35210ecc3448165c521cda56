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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main More = new Main();
            More.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Skiks Main = new Skiks();
            Main.Show();
            this.Hide();
        }
    }
}
