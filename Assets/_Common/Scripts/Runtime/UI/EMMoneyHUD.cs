public static class EMMoneyHUD
{
    public static void Enable()
    {
        SetEnable(true);
    }

    public static void Disable()
    {
        SetEnable(false);
    }

    public static void OnInit()
    {
        EMEvents.MoneyResourceChanged += OnMoneyResourceChanged;

        OnMoneyResourceChanged(0, 0);
    }

    public static void OnDeinit()
    {
        EMEvents.MoneyResourceChanged -= OnMoneyResourceChanged;
    }

    private static void SetEnable(bool isEnable)
    {
        if (EMApplicationBehaviour.Instance.LinksData.MoneyHUDBehaviour == null)
        {
            EMDebugHelper.PrintError("EMMoneyHUD", "The 'MoneyHUDBehaviour' field in 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.MoneyHUDBehaviour.gameObject.SetActive(isEnable);
    }

    private static void OnMoneyResourceChanged(int prevMoney, int currMoney)
    {
        if (EMApplicationBehaviour.Instance.LinksData.MoneyHUDBehaviour == null)
        {
            EMDebugHelper.PrintError("EMMoneyHUD", "The 'MoneyHUDBehaviour' field in 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.MoneyHUDBehaviour.SetMoney(currMoney);
    }
}
