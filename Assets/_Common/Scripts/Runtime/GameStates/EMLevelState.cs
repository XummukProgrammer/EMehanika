public class EMLevelState : IEMState
{
    public void OnInit()
    {
    }

    public void OnDeinit()
    {
    }

    public void OnEnter()
    {
        EMLevel.SpawnLevelBehaviour();
        EMLevel.SpawnOneTiger();
        EMLevel.SpawnOneHouse();
        EMLevel.SpawnOneButcherShop();

        EMMoneyHUD.Enable();
        EMTapObject.Enable();
    }

    public void OnExit()
    {
        EMMoneyHUD.Disable();
        EMTapObject.Disable();
    }

    public void OnUpdate()
    {
    }
}
