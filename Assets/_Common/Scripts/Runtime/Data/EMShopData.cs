using UnityEngine;

[CreateAssetMenu(fileName = "Shop Data", menuName = "EMechanika/Shop Data", order = 4)]
public class EMShopData : ScriptableObject
{
    [SerializeField] private EMShopType _type;
    [SerializeField] private int _cost;
    [SerializeField] private int _extraCost;
    [SerializeField] private EMCurrencyType _currencyType;
    [SerializeField] private int _maxCount;

    public EMShopType Type => _type;
    public int Cost => _cost;
    public int ExtraCost => _extraCost;
    public EMCurrencyType CurrencyType => _currencyType;
    public int MaxCount => _maxCount;
}
