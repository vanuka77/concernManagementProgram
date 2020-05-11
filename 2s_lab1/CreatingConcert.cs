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
    partial class CreatingConcert : Form
    {
        Form1 form1;
        public CreatingConcert(Form1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            form1 = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkConcertByName(textBox2.Text))
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    try
                    {
                        form1.concertStorage.addConsert(new Concert(textBox1.Text, textBox2.Text, (DateTime)dateTimePicker1.Value));
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выбирите дату!");
                    }
                }
                else
                {
                    MessageBox.Show("Поля не заполнены!");
                }
            }
            else {
                MessageBox.Show("Такой концерт уже существует");
            }
        }

        private bool checkConcertByName(string concertName)
        {
            foreach (Concert c in form1.concertStorage.consertList)
            {
                if (c.consertName == concertName)
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private Concert findConcertByName(string concertName)
        {
            foreach (Concert c in form1.concertStorage.consertList)
            {
                if (c.consertName == concertName)
                {
                    return c;
                }
            }
            return new Concert();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.concertStorage.addConsert((Concert)findConcertByName((string)comboBox1.SelectedItem).Clone());
        }

        private void concertBox1_Click(object sender, EventArgs e)
        {
            concertBox1.Items.Clear();
            foreach (Concert c in form1.concertStorage.consertList)
            {
                concertBox1.Items.Add(c.consertName);
            }
            dateTimePicker2.MinDate = findConcertByName((string)concertBox1.SelectedItem).dataTime.Date;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Concert tempConcert = findConcertByName((string)concertBox1.SelectedItem);
            if (textBox3.Text != "")
            {
                tempConcert.consertName = textBox3.Text;
            }
            if (textBox4.Text != "")
            {
                tempConcert.companyName = textBox4.Text;
            }
            if (textBox4.Text != "" && textBox3.Text != "") {
                MessageBox.Show("Пустые поля!");
            }
            tempConcert.dataTime = dateTimePicker2.Value;
        }
    }
}
