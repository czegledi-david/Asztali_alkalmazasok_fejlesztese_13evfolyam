using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myclasses.products
{
    using myclasses;

    public class Bread : Product
    {
        private double quantity; // Mennyiség

        //Konstruktor
        public Bread(string name, int netPrice, int vatRate, double qauntity) : base(name, netPrice, vatRate)
        {
            this.quantity = qauntity;
        }

        public override string ToString()
        {
            double unitPrice = GetGrossPrice() / quantity;
            return base.ToString() + $" | Egységár: {unitPrice:F2} Ft/kg";
        }
        
        public double GetQuantity()
        {
            return quantity;
        }

        public static bool IsMoreExpensive(Bread b1,  Bread b2)
        {
            double unitPrice1 = b1.GetGrossPrice() / b1.quantity;
            double unitPrice2 = b2.GetNetPrice() / b2.quantity;

            return unitPrice1 > unitPrice2;
        }

    }
}
