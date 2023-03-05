namespace Vending;
    abstract class Item
    {
        protected string name;
        protected int price;

        protected Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public void SetPrice(int newPrice)
        {
            this.price = newPrice;
        }

    }