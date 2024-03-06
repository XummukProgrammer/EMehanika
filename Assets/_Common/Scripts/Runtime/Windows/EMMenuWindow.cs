public static class EMMenuWindow
{
    public static void Enable()
    {
        SetEnable(true);
    }

    public static void Disable()
    {
        SetEnable(false);
    }

    private static void SetEnable(bool isEnable)
    {
        if (EMApplicationBehaviour.Instance.LinksData.MenuWindowBehaviour == null)
        {
            EMDebugHelper.PrintError("EMMenuWindow", "The 'MenuWindowBehaviour' field in 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.MenuWindowBehaviour.gameObject.SetActive(isEnable);
    }
}
