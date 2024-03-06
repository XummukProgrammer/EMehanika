using UnityEngine;

[System.Serializable]
public class EMLinksData
{
    [SerializeField] private EMLevelSpawnerBehaviour _levelSpawnerBehaviour;

    [SerializeField] private EMMoneyHUDBehaviour _moneyHUDBehaviour;
    [SerializeField] private EMMeatHUDBehaviour _meatHUDBehaviour;
    [SerializeField] private EMTapObjectBehaviour _tapObjectBehaviour;

    public EMLevelSpawnerBehaviour LevelSpawnerBehaviour => _levelSpawnerBehaviour;

    public EMMoneyHUDBehaviour MoneyHUDBehaviour => _moneyHUDBehaviour;
    public EMMeatHUDBehaviour MeatHUDBehaviour => _meatHUDBehaviour;
    public EMTapObjectBehaviour TapObjectBehaviour => _tapObjectBehaviour;
}
