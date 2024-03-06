public class EMShopItemHUD
{
    private EMShopHUDBehaviour _behaviour;

    public EMShopType ItemType { get; private set; }

    public EMShopItemHUD(EMShopHUDBehaviour behaviour, EMShopType itemType)
    {
        _behaviour = behaviour;
        ItemType = itemType;
    }

    public void Enable()
    {
        if (_behaviour != null)
        {
            _behaviour.gameObject.SetActive(true);
        }
    }

    public void Disable()
    {
        if (_behaviour != null)
        {
            _behaviour.gameObject.SetActive(false);
        }
    }

    public void Reinit()
    {
        if (_behaviour == null)
        {
            return;
        }

        var item = EMShopManager.GetItem(ItemType);
        if (item == null)
        {
            return;
        }

        _behaviour.SetType(ItemType);
        _behaviour.SetCost(item.Cost);
        _behaviour.SetIsMaxed(item.IsMaxed);
    }

    public void OnInit()
    {
        Reinit();
    }

    public void OnDeinit()
    {
    }
}
