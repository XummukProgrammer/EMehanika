public class EMMoneyResource
{
    public int Money { get; private set; }

    public void AddMoney(int money)
    {
        int prevMoney = Money;
        Money += money;

        EMEvents.MoneyResourceChanged?.Invoke(prevMoney, Money);
    }

    public void TakeMoney(int meat)
    {
        int prevMoney = Money;
        Money -= Money;

        if (Money < 0)
        {
            Money = 0;
        }

        EMEvents.MoneyResourceChanged?.Invoke(prevMoney, Money);
    }

    public void Reset()
    {
        Money = 0;

        EMEvents.MoneyResourceChanged?.Invoke(0, 0);
    }
}
