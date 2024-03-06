public static class EMTapObject
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
        if (EMApplicationBehaviour.Instance.LinksData.TapObjectBehaviour == null)
        {
            EMDebugHelper.PrintError("EMTapObject", "The 'TapObjectBehaviour' field of 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.TapObjectBehaviour.gameObject.SetActive(isEnable);
    }
}
