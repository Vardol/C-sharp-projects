namespace Vending;
using System.Collections.Generic;

class HotDrinksVendingMachine : IVendingMachine<HotDrink>
{
    private LinkedList<HotDrink> contentsList; //хранилище списка содержимого

    //Конструкторы
    public HotDrinksVendingMachine(LinkedList<HotDrink> hotDrinks)
    {
        this.contentsList = new LinkedList<HotDrink>(hotDrinks);
    }

    public HotDrinksVendingMachine()
    {
        this.contentsList = new LinkedList<HotDrink>();
    }


    public void Remove(HotDrink hotDrink)
    {
        contentsList.Remove(hotDrink);
    }
    public void AddItem(HotDrink hotDrink)
    {
        contentsList.AddFirst(hotDrink);
    }

    public void SellItem(HotDrink hotDrink, IPaymentHandler paymentHandler)
    {
        if (paymentHandler.GetPayment(hotDrink))
        {
            Console.WriteLine(string.Format("Продан {0}", hotDrink.GetName()));
            this.Remove(hotDrink);
        }
        else
        {
            Console.WriteLine(string.Format("Не получилось продать {0}", hotDrink.GetName()));
        }
    }

    //нумератор (итератор)
    public IEnumerator<HotDrink> GetEnumerator()
    {
        return this.contentsList.GetEnumerator();
    }

    //возвращает список содержимого
    public LinkedList<HotDrink> GetList()
    {
        return this.contentsList;
    }


    //поиск товара по названию
    public HotDrink GetProduct(string name)
    {
        foreach (HotDrink hotDrink in this.contentsList)
        {
            if (hotDrink.GetName().ToLower().Equals(name.ToLower()))
            {
                return hotDrink;
            }
        }
        return null;
    }

    public HotDrink GetProduct(int temperature)
    {
        foreach (HotDrink hotDrink in this.contentsList)
        {
            if (hotDrink.GetTemperature() == temperature)
            {
                return hotDrink;
            }
        }
        return null;
    }

    public void PrintContents()
    {
        IEnumerator<HotDrink> myEnum = this.GetEnumerator();
        while (myEnum.MoveNext())
        {
            Console.WriteLine(myEnum.Current);
        }
    }

}