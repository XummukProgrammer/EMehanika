public static class EMResources
{
    public static EMMoneyResource Money { get; private set; } = new();
    public static EMMeatResource Meat { get; private set; } = new();

    public static void OnInit()
    {
        EMEvents.HouseCrossed += OnHouseCrossed;
    }

    public static void OnDeinit()
    {
        EMEvents.HouseCrossed -= OnHouseCrossed;
    }

    public static void Reset()
    {
        Money.Reset();
        Meat.Reset();
    }

    private static void OnHouseCrossed(int value, EMHouseType type)
    {
        switch (type)
        {
            case EMHouseType.Bank:
                Money.AddMoney(value);
                break;

            case EMHouseType.MeatButcher:
                Meat.AddMeat(value);
                break;
        }
    }
}
