using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment09Alpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Bread> breadList = new List<Bread>();
            List<SandwichFilling> fillingList = new List<SandwichFilling>();
            List<Condiment> condimentList = new List<Condiment>();



            //load all bread options
            StreamReader inputFile;
            if (File.Exists("Bread.txt"))
            {
                inputFile = File.OpenText("Bread.txt");
                while (!inputFile.EndOfStream)
                {
                    string name = inputFile.ReadLine();
                    int cals = 0;
                    int.TryParse(inputFile.ReadLine(), out cals);
                    Bread temp = new Bread(name, cals);
                    breadList.Add(temp);
                }
                inputFile.Close();
            }
            else
            {
                MessageBox.Show("Bread.txt does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //load all filling options
            if (File.Exists("Fillings.txt"))
            {
                inputFile = File.OpenText("Fillings.txt");
                while (!inputFile.EndOfStream)
                {
                    string name = inputFile.ReadLine();
                    int cals = 0;
                    int.TryParse(inputFile.ReadLine(), out cals);
                    SandwichFilling temp = new SandwichFilling(name, cals);
                    fillingList.Add(temp);
                }
                inputFile.Close();
            }
            else
            {
                MessageBox.Show("Fillings.txt does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //load condiment options
            if (File.Exists("Condiment.txt"))
            {
                inputFile = File.OpenText("Condiment.txt");
                while (!inputFile.EndOfStream)
                {
                    string name = inputFile.ReadLine();
                    int cals = 0;
                    int.TryParse(inputFile.ReadLine(), out cals);
                    Condiment temp = new Condiment(name, cals);
                    condimentList.Add(temp);
                }
                inputFile.Close();
            }
            else
            {
                MessageBox.Show("Condiment.txt does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //load lists into comboboxes
            foreach (Bread b in breadList)
            {
                cmbBread.Items.Add(b.getBreadName());
            }
            foreach (SandwichFilling f in fillingList)
            {
                cmbFillings.Items.Add(f.getFilling());
            }
            foreach (Condiment c in condimentList)
            {
                clbCondiments.Items.Add(c.getName());
            }



        }
    }
}

