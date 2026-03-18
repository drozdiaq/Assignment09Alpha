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

        //option lists
        List<Bread> breadList = new List<Bread>();
        List<SandwichFilling> fillingList = new List<SandwichFilling>();
        List<Condiment> condimentList = new List<Condiment>();

        private void Form1_Load(object sender, EventArgs e)
        {
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
                cmbBread.Items.Add(b);
            }
            cmbBread.SelectedIndex = 0;
            foreach (SandwichFilling f in fillingList)
            {
                cmbFillings.Items.Add(f);
            }
            cmbFillings.SelectedIndex = 0;
            foreach (Condiment c in condimentList)
            {
                clbCondiments.Items.Add(c);
            }
        }

        //summarize order
        private void btnSum_Click(object sender, EventArgs e)
        {
            //create sandwich object from user selections
            Bread bread = (Bread)cmbBread.SelectedItem;
            SandwichFilling filling = (SandwichFilling)cmbFillings.SelectedItem;
            List<Condiment> condiments = new List<Condiment>();
            clbCondiments.CheckedItems.Cast<Condiment>().ToList().ForEach(c => condiments.Add(c));

            Sandwich sandwich = new Sandwich(bread, filling, condiments);
            int calories = bread.getBreadCalories() + filling.getCalories() + condiments.Sum(c => c.getCals());


            string condimentNames = string.Join(", ", condiments.Select(c => c.getName()));
            if (condimentNames == "")
            {
                condimentNames = "no condiments";
            }
            string message = sandwich.getFilling() + " with " + condimentNames + " on " + sandwich.getBread() + "\n\nTotal calories: " + calories;
            MessageBox.Show(message, Sandwich.slogan);//Remember to add slogan. totalCalories variable is just a placeholder for now.

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the checked state of all items (ClearSelected only clears selection highlight)
            for (int i = 0; i < clbCondiments.Items.Count; i++)
            {
                clbCondiments.SetItemChecked(i, false);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

