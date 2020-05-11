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
    partial class AddingPerformance : Form
    {
        Form1 form1;
        public AddingPerformance(Form1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            form1 = parent;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkForm())
            {
                findConcertByName().addPerformance(new Performance(textBox1.Text, findCompositionByName(), (int)numericUpDown1.Value, textBox2.Text, textBox3.Text));
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                numericUpDown1.Value = 0;
                listBox1.SelectedItem = null;
                comboBox1.SelectedItem = null;
            }else {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private bool checkForm()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && (int)numericUpDown1.Value > 0 && comboBox1.SelectedItem != null && listBox1.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Concert findConcertByName() {
            foreach (Concert c in form1.concertStorage.consertList) {
                if (c.consertName == (string)comboBox1.SelectedItem) {
                    return c;
                }
            }
            return new Concert();
        }

        private Composition findCompositionByName() {
            switch (listBox1.Text)
            {
                case "инструментальный": return Composition.instrumental;
                case "вокальный": return Composition.vocal;
                case "стихотворный": return Composition.poetic;
                case "прозаический": return Composition.prosaic;
                default: return Composition.vocal;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (Concert c in form1.concertStorage.consertList)
            {
                comboBox1.Items.Add(c.consertName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
