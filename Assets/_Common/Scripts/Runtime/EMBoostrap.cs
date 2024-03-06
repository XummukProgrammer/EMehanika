public class EMBoostrap
{
    public void Setup(EMComponents components, EMGlobalData globalData, EMLinksData linksData)
    {
        components.StatesManager.AddState(EMStateType.Splash, new EMSplashState());
        components.StatesManager.AddState(EMStateType.Menu, new EMMenuState());
        components.StatesManager.AddState(EMStateType.Level, new EMLevelState());
        components.StatesManager.SetState(EMStateType.Splash);

        var shopItems = globalData.ShopItems;
        while (shopItems.MoveNext())
        {
            EMShopManager.AddItem(new EMShopItem(shopItems.Current));
        }

        EMMoneyHUD.OnInit();
        EMMeatHUD.OnInit();

        EMShopHUD.AddItem(new EMShopItemHUD(linksData.BankShopHUDBehaviour, EMShopType.Bank));
        EMShopHUD.AddItem(new EMShopItemHUD(linksData.TigerShopHUDBehaviour, EMShopType.Tiger));
        EMShopHUD.AddItem(new EMShopItemHUD(linksData.MeatButcherShopHUDBehaviour, EMShopType.MeatButcher));
        EMShopHUD.OnInit();
    }

    public void Destroy(EMComponents components)
    {
        EMMoneyHUD.OnDeinit();
        EMMeatHUD.OnDeinit();
        EMShopHUD.OnDeinit();
    }
}
