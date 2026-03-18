using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09Alpha
{
    internal class SandwichFilling
    {
        private string filling;
        private int calories;

        // Constructor
        public SandwichFilling(string filling, int calories)
        {
            this.filling = filling;
            this.calories = calories;
        }

        // Accessors
        public string getFilling()
        {
            return filling;
        }

        public int getCalories()
        {
            return calories;
        }

        // Modifiers 
        public void setFilling(string filling)
        {
            this.filling = filling;
        }
        public void setCalories(int calories)
        {
            this.calories = calories;
        }

        // Method
        public override string ToString()
        {
            return this.filling;
        }
    }
}
