namespace Vending;

interface IPaymentHandler
{
    abstract public bool GetPayment(HotDrink hotDrink);
}