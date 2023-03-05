// namespace Vending;
// using HotDrink;
// using Item;
using Vending;
using System.Collections.Generic;
using System.Collections;

// HotDrink cappuccino = new HotDrink("Cappuccino", 150, 250, 60);

HotDrinksVendingMachine machine = new HotDrinksVendingMachine();
machine.AddItem(new HotDrink("Cappuccino", 150, 200, 60));
machine.AddItem(new HotDrink("Cappuccino", 150, 200, 60));
machine.AddItem(new HotDrink("Cappuccino", 150, 200, 60));
machine.AddItem(new HotDrink("Cappuccino", 150, 200, 60));
machine.AddItem(new HotDrink("Cappuccino", 150, 200, 60));
machine.AddItem(new HotDrink("Americano", 100, 150, 80));
machine.AddItem(new HotDrink("Americano", 100, 150, 80));
machine.AddItem(new HotDrink("Americano", 100, 150, 80));
machine.AddItem(new HotDrink("Americano", 100, 150, 80));
machine.AddItem(new HotDrink("Espresso", 100, 50, 80));
machine.AddItem(new HotDrink("Espresso", 100, 50, 80));
machine.AddItem(new HotDrink("Espresso", 100, 50, 80));
machine.AddItem(new HotDrink("Espresso", 100, 50, 80));
machine.AddItem(new HotDrink("Hotwater", 50, 200, 95));
machine.AddItem(new HotDrink("Hotwater", 50, 200, 95));
machine.AddItem(new HotDrink("Hotwater", 50, 200, 95));
machine.AddItem(new HotDrink("Hotwater", 50, 200, 95));
machine.AddItem(new HotDrink("Latte", 150, 250, 60));
machine.AddItem(new HotDrink("Latte", 150, 250, 60));
machine.AddItem(new HotDrink("Latte", 150, 250, 60));
machine.AddItem(new HotDrink("Latte", 150, 250, 60));

IEnumerator<HotDrink> myEnum = machine.GetEnumerator();
while (myEnum.MoveNext())
{
    Console.WriteLine(myEnum.Current);
}

machine.SellItem(machine.GetProduct(95), new BasePaymentHandler());


machine.PrintContents();


//Console.WriteLine(machine.GetProduct("Espresso"));


//Enumerator machine.Enumerator();