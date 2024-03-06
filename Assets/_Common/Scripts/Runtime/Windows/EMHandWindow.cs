public static class EMHandWindow
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
        if (EMApplicationBehaviour.Instance.LinksData.HandWindowBehaviour == null)
        {
            EMDebugHelper.PrintError("EMHandWindow", "The 'HandWindowBehaviour' field in 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.HandWindowBehaviour.gameObject.SetActive(isEnable);
    }
}
