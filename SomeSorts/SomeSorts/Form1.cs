using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeSorts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(100);
            listBox1.Items.Add(1000);
            listBox1.Items.Add(10000);
            listBox1.SelectedIndex = 0;
            bt_run.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
