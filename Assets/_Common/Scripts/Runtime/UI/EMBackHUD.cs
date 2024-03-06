public static class EMBackHUD
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
        if (EMApplicationBehaviour.Instance.LinksData.BackHUDBehaviour == null)
        {
            EMDebugHelper.PrintError("EMBackHUD", "The 'BackHUDBehaviour' field of 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.BackHUDBehaviour.gameObject.SetActive(isEnable);
    }
}
