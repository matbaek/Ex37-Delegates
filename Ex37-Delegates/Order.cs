using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex37_Delegates
{
    public class Order
    {
        public delegate double BonusProvider(double amount);
        private BonusProvider bonus;
        List<Product> products = new List<Product>();

        public BonusProvider Bonus
        {
            get { return this.bonus; }
            set { this.bonus = value; }
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public double GetValueOfProducts()
        {
            double value = 0.0;
            for (int i = 0; i < this.products.Count; i++)
            {
                value += this.products[i].Value;
            }
            return value;
        }

        public double GetBonus()
        {
            return bonus(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
