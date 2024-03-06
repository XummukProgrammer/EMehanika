public class EMMenuState : IEMState
{
    public void OnInit()
    {
        EMEvents.PlayClicked += OnPlayClicked;
    }

    public void OnDeinit()
    {
        EMEvents.PlayClicked -= OnPlayClicked;
    }

    public void OnEnter()
    {
        EMMenuWindow.Enable();
    }

    public void OnExit()
    {
        EMMenuWindow.Disable();
    }

    public void OnUpdate()
    {
    }

    private void OnPlayClicked()
    {
        EMApplicationBehaviour.Instance.Components.StatesManager.SetState(EMStateType.Level);
    }
}
