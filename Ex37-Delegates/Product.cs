using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex37_Delegates
{
    public class Product
    {
        private string name;
        private double value;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
