using UnityEngine;

[System.Serializable]
public class EMLinksData
{
    [SerializeField] private EMLevelSpawnerBehaviour _levelSpawnerBehaviour;

    [SerializeField] private EMMoneyHUDBehaviour _moneyHUDBehaviour;
    [SerializeField] private EMTapObjectBehaviour _tapObjectBehaviour;

    public EMLevelSpawnerBehaviour LevelSpawnerBehaviour => _levelSpawnerBehaviour;

    public EMMoneyHUDBehaviour MoneyHUDBehaviour => _moneyHUDBehaviour;
    public EMTapObjectBehaviour TapObjectBehaviour => _tapObjectBehaviour;
}
