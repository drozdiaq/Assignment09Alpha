using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09Alpha
{
    internal class Bread
    {
        private int breadCalories;
        private string name;

        public Bread(string breadName, int breadCalories)
        {
            this.name = breadName;
            this.breadCalories = breadCalories;
        }
        public string getBreadName()
        {
            return name;
        }
        public int getBreadCalories()
        {
            return breadCalories;
        }
        private void setBreadName(string breadName)
        {
            this.name = breadName;
        }
        private void setBreadCalories(int breadCalories)
        {
            this.breadCalories = breadCalories;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
