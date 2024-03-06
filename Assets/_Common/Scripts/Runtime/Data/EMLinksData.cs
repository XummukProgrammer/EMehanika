using UnityEngine;

[System.Serializable]
public class EMLinksData
{
    [SerializeField] private EMLevelSpawnerBehaviour _levelSpawnerBehaviour;

    [SerializeField] private EMMoneyHUDBehaviour _moneyHUDBehaviour;
    [SerializeField] private EMMeatHUDBehaviour _meatHUDBehaviour;
    [SerializeField] private EMTapObjectBehaviour _tapObjectBehaviour;
    [SerializeField] private EMShopHUDBehaviour _tigerShopHUDBehaviour;
    [SerializeField] private EMShopHUDBehaviour _bankShopHUDBehaviour;
    [SerializeField] private EMShopHUDBehaviour _meatButcherShopHUDBehaviour;

    [SerializeField] private EMSplashWindowBehaviour _splashWindowBehaviour;
    [SerializeField] private EMMenuWindowBehaviour _menuWindowBehaviour;
    [SerializeField] private EMDialogsWindowBehaviour _dialogsWindowBehaviour;
    [SerializeField] private EMHandWindowBehaviour _handWindowBehaviour;

    public EMLevelSpawnerBehaviour LevelSpawnerBehaviour => _levelSpawnerBehaviour;

    public EMMoneyHUDBehaviour MoneyHUDBehaviour => _moneyHUDBehaviour;
    public EMMeatHUDBehaviour MeatHUDBehaviour => _meatHUDBehaviour;
    public EMTapObjectBehaviour TapObjectBehaviour => _tapObjectBehaviour;
    public EMShopHUDBehaviour TigerShopHUDBehaviour => _tigerShopHUDBehaviour;
    public EMShopHUDBehaviour BankShopHUDBehaviour => _bankShopHUDBehaviour;
    public EMShopHUDBehaviour MeatButcherShopHUDBehaviour => _meatButcherShopHUDBehaviour;

    public EMSplashWindowBehaviour SplashWindowBehaviour => _splashWindowBehaviour;
    public EMMenuWindowBehaviour MenuWindowBehaviour => _menuWindowBehaviour;
    public EMDialogsWindowBehaviour DialogsWindowBehaviour => _dialogsWindowBehaviour;
    public EMHandWindowBehaviour HandWindowBehaviour => _handWindowBehaviour;
}
