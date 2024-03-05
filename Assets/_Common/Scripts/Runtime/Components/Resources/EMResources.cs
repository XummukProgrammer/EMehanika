public static class EMResources
{
    public static EMMoneyResource Money { get; private set; } = new();

    public static void OnInit()
    {
        EMEvents.HouseCrossed += OnHouseCrossed;
    }

    public static void OnDeinit()
    {
        EMEvents.HouseCrossed -= OnHouseCrossed;
    }

    private static void OnHouseCrossed(int money)
    {
        Money.AddMoney(money);
    }
}
