namespace Vending;
    class Drink : Item
    {
        protected int volume;

        public Drink(string name, int price, int volume) : base(name,price)
        {
            this.volume = volume;
        }

        public int GetVolume()
        {
            return this.volume;
        }

        override public string ToString()
        {
            return string.Format("{0}. price: {1}; vol.: {2}.",this.name,this.price, this.volume);
        }

    }
