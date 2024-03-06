using System.Collections.Generic;

public static class EMShopManager
{
    private static List<EMShopItem> _items = new();

    public static void AddItem(EMShopItem item)
    {
        _items.Add(item);
    }

    public static void BuyItem(EMShopType type)
    {
        var item = GetItem(type);
        if (item == null)
        {
            EMDebugHelper.PrintError("EMShopManager", $"Item '{type}' is missing.");
            return;
        }

        if (item.IsMaxed)
        {
            return;
        }

        int cost = item.Cost;

        if (GetCurrencyValue(item.Data.CurrencyType) < cost)
        {
            return;
        }

        TakeCurrencyValue(item.Data.CurrencyType, cost);

        item.OnBuy();

        EMEvents.ShopItemPurchased?.Invoke(type);
    }

    public static EMShopItem GetItem(EMShopType type)
    {
        foreach (var item in _items)
        {
            if (item.Data.Type == type)
            {
                return item;
            }
        }
        return null;
    }

    private static int GetCurrencyValue(EMCurrencyType type)
    {
        switch (type)
        {
            case EMCurrencyType.Money:
                return EMResources.Money.Money;
            case EMCurrencyType.Meat:
                return EMResources.Meat.Meat;
        }
        return 0;
    }

    private static void TakeCurrencyValue(EMCurrencyType type, int value)
    {
        switch (type)
        {
            case EMCurrencyType.Money:
                EMResources.Money.TakeMoney(value);
                break;

            case EMCurrencyType.Meat:
                EMResources.Meat.TakeMeat(value);
                break;
        }
    }
}
