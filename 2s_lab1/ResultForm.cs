using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2s_lab1
{
    partial class ResultForm : Form
    {
        Form1 form1;
        public ResultForm(Form1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            form1 = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {
                richTextBox1.Text += findConcertByName().createShortInfo();
            }
            else
            {
                MessageBox.Show("Концерт не выбран!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                richTextBox1.Text += findConcertByName().createFullInfo();
            }
            else
            {
                MessageBox.Show("Концерт не выбран!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (Concert c in form1.concertStorage.consertList)
            {
                comboBox1.Items.Add(c.consertName);
            }
        }

        private Concert findConcertByName()
        {
            foreach (Concert c in form1.concertStorage.consertList)
            {
                if (c.consertName == (string)comboBox1.SelectedItem)
                {
                    return c;
                }
            }
            return new Concert();
        }
    }
}
