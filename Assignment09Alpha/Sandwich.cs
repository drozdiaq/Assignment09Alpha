using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09Alpha
{
    internal class Sandwich
    {
        private Bread bread;
        private SandwichFilling filling;
        private List<Condiment> condiments;

        public const string slogan = "fresh ingredients, bold sandwiches";
        public Sandwich(Bread bread, SandwichFilling filling, List<Condiment> condiments)
        {
            this.bread = bread;
            this.filling = filling;
            this.condiments = condiments;

        }

        public Bread getBread()
        {
            return this.bread;
        }

        public SandwichFilling getFilling()
        {
            return this.filling;
        }

        public List<Condiment> getCondiments()
        {
            return this.condiments;
        }

    }
}
