using System;

namespace myclasses
{
    public class Product
    {
        private string name;
        private int netPrice;
        private int vatRate;

        public Product(string name, int netPrice, int vatRate)
        {
            this.name = name;
            this.netPrice = netPrice;
            this.vatRate = vatRate;
        }

        public int GetGrossPrice()
        {
            double gross = netPrice * (1 + vatRate / 100.0);
            return (int)Math.Round(gross);
        }

        public override string ToString()
        {
            return $"{name} - Bruttó ár: {GetGrossPrice()}";
        }

        public void IncreasePrice(int percent)
        {
            netPrice = (int)Math.Round(netPrice * (1 + percent / 100.0));
        }

        public int CompareTo(Product other)
        {
            int thisGross = this.GetGrossPrice();
            int otherGross = other.GetGrossPrice();

            if (thisGross > otherGross) return -1;
            else if (thisGross < otherGross) return 1;
            else return 0;

        }

        protected string GetName() => name;
        protected int GetNetPrice() => netPrice;
        protected int GetVatRate => vatRate;

    }

}