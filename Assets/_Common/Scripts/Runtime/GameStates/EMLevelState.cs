using UnityEngine;

public class EMLevelState : IEMState
{
    private float _timeToShowHand;

    private float SecondsForShowHand => 2;

    public void OnInit()
    {
        EMEvents.ShopItemPurchased += ShopItemPurchased;
        EMEvents.ToMenuClicked += ToMenuClicked;
    }

    public void OnDeinit()
    {
        EMEvents.ShopItemPurchased -= ShopItemPurchased;
        EMEvents.ToMenuClicked -= ToMenuClicked;
    }

    public void OnEnter()
    {
        _timeToShowHand = 0;

        EMLevel.SpawnLevelBehaviour();
        EMLevel.SpawnOneTiger();
        EMLevel.SpawnOneHouse();
        EMLevel.SpawnOneButcherShop();

        EMMoneyHUD.Enable();
        EMMeatHUD.Enable();
        EMTapObject.Enable();
        EMBackHUD.Enable();

        EMShopHUD.EnableBehaviour(EMShopType.Tiger);
        EMShopHUD.EnableBehaviour(EMShopType.Bank);
        EMShopHUD.EnableBehaviour(EMShopType.MeatButcher);
    }

    public void OnExit()
    {
        EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.DestroyLevel();

        EMResources.Reset();

        EMMoneyHUD.Disable();
        EMMeatHUD.Disable();
        EMTapObject.Disable();
        EMHandWindow.Disable();
        EMBackHUD.Disable();

        EMShopHUD.DisableBehaviour(EMShopType.Tiger);
        EMShopHUD.DisableBehaviour(EMShopType.Bank);
        EMShopHUD.DisableBehaviour(EMShopType.MeatButcher);
    }

    public void OnUpdate()
    {
        if (EMTigerSpeedModificator.CanActivate)
        {
            _timeToShowHand += Time.deltaTime;

            if (_timeToShowHand >= SecondsForShowHand)
            {
                EMHandWindow.Enable();
            }
        }
        else
        {
            EMHandWindow.Disable();
            _timeToShowHand = 0;
        }
    }

    private void ShopItemPurchased(EMShopType type)
    {
        switch (type)
        {
            case EMShopType.Tiger:
                EMLevel.SpawnOneTiger();
                break;

            case EMShopType.MeatButcher:
                EMLevel.SpawnOneButcherShop();
                break;

            case EMShopType.Bank:
                EMLevel.SpawnOneHouse();
                break;
        }
    }

    private void ToMenuClicked()
    {
        EMApplicationBehaviour.Instance.Components.StatesManager.SetState(EMStateType.Splash);
    }
}
