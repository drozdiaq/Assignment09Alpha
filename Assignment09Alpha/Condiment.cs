using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09Alpha
{
    internal class Condiment
    {
        private int cal;
        private string name;


        public Condiment(string name, int cal)
        {
            this.name = name;
            this.cal = cal;
        }

        public string getName()
        {
            return name;
        }

        public int getCals()
        {
            return cal;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setCals(int cals)
        {
            this.cal = cals;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
