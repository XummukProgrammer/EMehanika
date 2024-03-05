using UnityEngine;

[System.Serializable]
public class EMLinksData
{
    [SerializeField] private EMLevelSpawnerBehaviour _levelSpawnerBehaviour;

    [SerializeField] private EMMoneyHUDBehaviour _moneyHUDBehaviour;

    public EMLevelSpawnerBehaviour LevelSpawnerBehaviour => _levelSpawnerBehaviour;

    public EMMoneyHUDBehaviour MoneyHUDBehaviour => _moneyHUDBehaviour;
}
