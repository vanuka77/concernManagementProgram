using _2s_lab1.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2s_lab1
{
     partial class Form1 : Form
    {
        public ConcertStorage concertStorage;
        CreatingConcert creatingConcert;
        AddingPerformance addingPerformance;
        ResultForm resultform;
        MixPerformances mixPerformances;
        ConcertController concertController;

        public Form1(ConcertController concertController)
        {
            InitializeComponent();
            concertStorage = concertController.concertStorage;
            creatingConcert = new CreatingConcert(this);
            addingPerformance = new AddingPerformance(this);
            resultform = new ResultForm(this);
            mixPerformances = new MixPerformances(this);
            this.concertController = concertController;
        }

        public Form1( )
        {
            InitializeComponent();
            concertStorage = new ConcertStorage();
            creatingConcert = new CreatingConcert(this);
            addingPerformance = new AddingPerformance(this);
        }

        private void создатьКонцертToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creatingConcert.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addingPerformance.Show();
        }

        private void посмотретьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultform.Show();
        }

        private void обьеденитьВыступленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mixPerformances.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ConsertStorage.dat", FileMode.OpenOrCreate);
            BinaryFormatter binFormatter = new BinaryFormatter();
            try
            {
                binFormatter.Serialize(fs, concertController.concertStorage.consertList);
                Console.WriteLine(" Saved list of cars in binary");
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare the hashtable reference.
            concertController.concertStorage.consertList = null;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream("ConsertStorage.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and assign the reference to the local variable.
                concertController.concertStorage.consertList = (List<Concert>)formatter.Deserialize(fs);
                Console.WriteLine("Success to deserialize ");
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + ex.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
