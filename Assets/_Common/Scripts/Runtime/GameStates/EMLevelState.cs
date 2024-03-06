using UnityEngine;

public class EMLevelState : IEMState
{
    private float _timeToShowHand;

    private float SecondsForShowHand => 2;

    public void OnInit()
    {
        EMEvents.ShopItemPurchased += ShopItemPurchased;
    }

    public void OnDeinit()
    {
        EMEvents.ShopItemPurchased -= ShopItemPurchased;
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

        EMShopHUD.EnableBehaviour(EMShopType.Tiger);
        EMShopHUD.EnableBehaviour(EMShopType.Bank);
        EMShopHUD.EnableBehaviour(EMShopType.MeatButcher);
    }

    public void OnExit()
    {
        EMMoneyHUD.Disable();
        EMMeatHUD.Disable();
        EMTapObject.Disable();
        EMHandWindow.Disable();

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
}
