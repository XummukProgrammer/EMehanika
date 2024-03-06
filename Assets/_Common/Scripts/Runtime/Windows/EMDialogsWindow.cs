using System.Collections.Generic;

public static class EMDialogsWindow
{
    private static List<EMDialogBehaviour> _dialogs;
    private static int _currentDialogIndex;

    public static void Enable()
    {
        SetEnable(true);

        EMEvents.SkipDialog += OnDialogSkipped;

        ShowNewDialog();
    }

    public static void Disable()
    {
        SetEnable(false);

        EMEvents.SkipDialog -= OnDialogSkipped;
    }

    public static void SetDialogs(List<EMDialogBehaviour> dialogs)
    {
        _dialogs = dialogs;
        _currentDialogIndex = -1;
    }

    public static void ShowNewDialog()
    {
        ++_currentDialogIndex;

        if (_currentDialogIndex >= _dialogs.Count)
        {
            _dialogs.Clear();
            EMEvents.DialogsOver?.Invoke();
            return;
        }

        if (EMApplicationBehaviour.Instance.LinksData.DialogsWindowBehaviour == null)
        {
            EMDebugHelper.PrintError("EMDialogsWindow", "The 'DialogsWindowBehaviour' field in 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.DialogsWindowBehaviour.InstantiateNewDialog(_dialogs[_currentDialogIndex]);
    }

    private static void SetEnable(bool isEnable)
    {
        if (EMApplicationBehaviour.Instance.LinksData.DialogsWindowBehaviour == null)
        {
            EMDebugHelper.PrintError("EMDialogsWindow", "The 'DialogsWindowBehaviour' field in 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.DialogsWindowBehaviour.gameObject.SetActive(isEnable);
    }

    private static void OnDialogSkipped()
    {
        ShowNewDialog();
    }
}
