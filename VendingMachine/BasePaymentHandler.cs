namespace Vending;

class BasePaymentHandler : IPaymentHandler
{
    public bool GetPayment(HotDrink hotDrink)
    {
        Console.Write("Получена оплата {0}руб.", hotDrink.GetPrice());
        return true;
    }
}