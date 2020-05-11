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
    partial class MixPerformances : Form
    {
        Form1 form1;

        public MixPerformances(Form1 parent)
        {

            InitializeComponent();
            this.MdiParent = parent;
            form1 = parent;
            
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

        private void concert1_Click(object sender, EventArgs e)
        {

            concertBox1.Items.Clear();
            foreach (Concert c in form1.concertStorage.consertList)
            {
                concertBox1.Items.Add(c.consertName);
            }
        }

        private void performance1_Click_1(object sender, EventArgs e)
        {
            performanceBox1.Items.Clear();
            Concert concert= findConcertByName((string)concertBox1.SelectedItem);
            foreach (Performance p in concert.performancetList)
            {
                performanceBox1.Items.Add(p.nameEvent);
            }
        }

        private void concert2_click(object sender, EventArgs e)
        {
            concertBox2.Items.Clear();
            foreach (Concert c in form1.concertStorage.consertList)
            {
                concertBox2.Items.Add(c.consertName);
            }
        }

        private void performance2_click(object sender, EventArgs e)
        {
            performanceBox2.Items.Clear();
            Concert concert = findConcertByName((string)concertBox2.SelectedItem);
            foreach (Performance p in concert.performancetList)
            {
                performanceBox2.Items.Add(p.nameEvent);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Performance p1 = new Performance();
            Performance p2 = new Performance();
            try
            {
                foreach (Concert c in form1.concertStorage.consertList)
                {
                    foreach (Performance p in c.performancetList)
                    {
                        if (p.nameEvent == (string)performanceBox1.SelectedItem)
                        {
                            p1 = p;
                        }
                        if (p.nameEvent == (string)performanceBox2.SelectedItem)
                        {
                            p2 = p;
                        }
                    }
                }
                if (p1 != p2)
                {
                    if (p1.composition == p2.composition)
                    {
                        Performance p3 = new Performance();
                        p3 = p1 + p2;
                        Concert c1 = findConcertByName((string)concertBox1.SelectedItem);
                        Concert c2 = findConcertByName((string)concertBox2.SelectedItem);
                        c1.performancetList.Remove(p1);
                        c2.performancetList.Remove(p2);
                        c1.performancetList.Add(p3);
                        concertBox1.SelectedItem = null;
                        concertBox2.SelectedItem = null;
                        performanceBox1.SelectedItem = null;
                        performanceBox2.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Разные типы выступлений!");
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали одинаковые выступления или поля незаполнены!\n");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Концерт еще не создан!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
