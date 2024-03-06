public class EMDialogState : IEMState
{
    public void OnInit()
    {
        EMEvents.DialogsOver += OnDialogsOver;
    }

    public void OnDeinit()
    {
        EMEvents.DialogsOver -= OnDialogsOver;
    }

    public void OnEnter()
    {
        EMDialogsWindow.SetDialogs(EMApplicationBehaviour.Instance.GlobalData.StartDialogsPrefabs);
        EMDialogsWindow.Enable();
    }

    public void OnExit()
    {
        EMDialogsWindow.Disable();
    }

    public void OnUpdate()
    {
    }

    private void OnDialogsOver()
    {
        EMApplicationBehaviour.Instance.Components.StatesManager.SetState(EMStateType.Level);
    }
}
