using UnityEngine;

public class EMSplashState : IEMState
{
    private float _time;

    private float Seconds => 1;

    public void OnInit()
    {
    }

    public void OnDeinit()
    {
    }

    public void OnEnter()
    {
        EMSplashWindow.Enable();

        _time = Seconds;
    }

    public void OnExit()
    {
        EMSplashWindow.Disable();
    }

    public void OnUpdate()
    {
        _time -= Time.deltaTime;

        if (_time <= 0)
        {
            EMApplicationBehaviour.Instance.Components.StatesManager.SetState(EMStateType.Level);
        }
    }
}
