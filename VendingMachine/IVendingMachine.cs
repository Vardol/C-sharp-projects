namespace Vending;

interface IVendingMachine<I>
{
    public I GetProduct(String name);
    public void SellItem(I i, IPaymentHandler paymentHandler);
    public void Remove(I i);
    public void AddItem(I i);
    public IEnumerator<I> GetEnumerator();
    public LinkedList<I> GetList();
}