using System.Collections.Generic;
class OrderSystem
{
    private List<IOrderObserver> observers = new List<IOrderObserver>();
    private string status;
    // подписка
    public void Attach(IOrderObserver observer)
    {
        observers.Add(observer);
    }
    // отписка
    public void Detach(IOrderObserver observer)
    {
        observers.Remove(observer);
    }
    // уведомление всех подписчиков
    private void Notify()
    {
        foreach (IOrderObserver observer in observers)
        {
            observer.Update(status);
        }
    }
    // изменение статуса заказа
    public void SetOrderStatus(string newStatus)
    {
        status = newStatus;
        Notify();
    }
}

//издатель