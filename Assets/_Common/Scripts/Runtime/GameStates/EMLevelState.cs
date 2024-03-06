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
    }

    public void OnExit()
    {
        EMMoneyHUD.Disable();
    }

    public void OnUpdate()
    {
    }
}
