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
        EMMeatHUD.Enable();
        EMTapObject.Enable();

        EMShopHUD.EnableBehaviour(EMShopType.Tiger);
        EMShopHUD.EnableBehaviour(EMShopType.Bank);
        EMShopHUD.EnableBehaviour(EMShopType.MeatButcher);
    }

    public void OnExit()
    {
        EMMoneyHUD.Disable();
        EMMeatHUD.Disable();
        EMTapObject.Disable();

        EMShopHUD.DisableBehaviour(EMShopType.Tiger);
        EMShopHUD.DisableBehaviour(EMShopType.Bank);
        EMShopHUD.DisableBehaviour(EMShopType.MeatButcher);
    }

    public void OnUpdate()
    {
    }
}
