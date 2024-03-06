public static class EMMeatHUD
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
        EMEvents.MeatResourceChanged += OnMeatResourceChanged;

        OnMeatResourceChanged(0, 0);
    }

    public static void OnDeinit()
    {
        EMEvents.MeatResourceChanged -= OnMeatResourceChanged;
    }

    private static void SetEnable(bool isEnable)
    {
        if (EMApplicationBehaviour.Instance.LinksData.MeatHUDBehaviour == null)
        {
            EMDebugHelper.PrintError("EMMeatHUD", "The 'MeatHUDBehaviour' field in 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.MeatHUDBehaviour.gameObject.SetActive(isEnable);
    }

    private static void OnMeatResourceChanged(int prevMeat, int currMeat)
    {
        if (EMApplicationBehaviour.Instance.LinksData.MeatHUDBehaviour == null)
        {
            EMDebugHelper.PrintError("EMMeatHUD", "The 'MeatHUDBehaviour' field in 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.MeatHUDBehaviour.SetMeat(currMeat);
    }
}
