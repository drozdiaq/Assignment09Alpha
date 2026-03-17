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
        private string breadName;

        public Bread(string breadName, int breadCalories)
        {
            this.breadName = breadName;
            this.breadCalories = breadCalories;
        }
        public string getBreadName()
        {
            return breadName;
        }
        public int getBreadCalories()
        {
            return breadCalories;
        }
        private void setBreadName(string breadName)
        {
            this.breadName = breadName;
        }
        private void setBreadCalories(int breadCalories)
        {
            this.breadCalories = breadCalories;
        }
        public override string ToString()
        {
            return string.Format(
                "Bread Name: {0}", "Bread Calories: {1:F3}",
                breadName, breadCalories);
        }
    }
}
