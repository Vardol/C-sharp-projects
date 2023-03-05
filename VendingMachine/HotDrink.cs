namespace Vending;
    class HotDrink : Drink
    {
        protected int temperature;

        public HotDrink(string name, int price, int volume, int temperature) : base(name,price,volume)
        {
            this.temperature = temperature;
        }

        public int GetTemperature()
        {
            return this.temperature;
        }


        override public string ToString()
        {
            return string.Format("{0}. price: {1}; vol.: {2}; temperature: {3}C.",this.name,this.price, this.volume, this.temperature);
        }

    }
