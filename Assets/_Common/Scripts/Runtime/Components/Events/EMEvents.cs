public static class EMEvents
{
    public static System.Action Tapped;
    public static System.Action<int, EMHouseType> HouseCrossed;

    public static System.Action<int, int> MoneyResourceChanged;
    public static System.Action<int, int> MeatResourceChanged;

    public static System.Action<EMShopType> ShopHUDClicked;
    public static System.Action<EMShopType> ShopItemPurchased;

    public static System.Action PlayClicked;

    public static System.Action SkipDialog;
    public static System.Action DialogsOver;
}
