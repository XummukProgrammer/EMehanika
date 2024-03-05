public class EMMoneyResource
{
    public int Money { get; private set; }

    public void AddMoney(int money)
    {
        int prevMoney = Money;
        Money += money;

        EMEvents.MoneyResourceChanged?.Invoke(prevMoney, Money);
    }
}
