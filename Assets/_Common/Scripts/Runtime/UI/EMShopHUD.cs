using System.Collections.Generic;

public static class EMShopHUD
{
    private static List<EMShopItemHUD> _items = new();

    public static void AddItem(EMShopItemHUD item)
    {
        _items.Add(item);
    }

    public static EMShopItemHUD GetItem(EMShopType type)
    {
        foreach (var item in _items)
        {
            if (item.ItemType == type)
            {
                return item;
            }
        }
        return null;
    }

    public static void EnableBehaviour(EMShopType type)
    {
        var item = GetItem(type);
        if (item != null)
        {
            item.Enable();
        }
    }

    public static void DisableBehaviour(EMShopType type)
    {
        var item = GetItem(type);
        if (item != null)
        {
            item.Disable();
        }
    }

    public static void OnInit()
    {
        foreach (var item in _items)
        {
            item.OnInit();
        }

        EMEvents.ShopHUDClicked += OnShopHUDClicked;
    }

    public static void OnDeinit()
    {
        foreach (var item in _items)
        {
            item.OnDeinit();
        }

        EMEvents.ShopHUDClicked -= OnShopHUDClicked;
    }

    private static void OnShopHUDClicked(EMShopType type)
    {
        EMShopManager.BuyItem(type);

        foreach (var item in _items)
        {
            item.Reinit();
        }
    }
}
