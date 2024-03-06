public static class EMSplashWindow
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
        if (EMApplicationBehaviour.Instance.LinksData.SplashWindowBehaviour == null)
        {
            EMDebugHelper.PrintError("EMMeatHUD", "The 'SplashWindowBehaviour' field in 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.SplashWindowBehaviour.gameObject.SetActive(isEnable);
    }
}
