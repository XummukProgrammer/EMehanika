using UnityEngine;

public class EMLevelBehaviour : EMObjectBehaviour
{
    [SerializeField] private EMHouseSpawnerBehaviour _bankSpawnerBehaviour;
    [SerializeField] private EMHouseSpawnerBehaviour _butcherShopSpawnerBehaviour;
    [SerializeField] private EMTigerSpawnerBehaviour _tigerSpawnerBehaviour;

    public void SpawnOneHouse()
    {
        if (_bankSpawnerBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevelBehaviour", "Fill in the '_bankSpawnerBehaviour' field.");
            return;
        }

        _bankSpawnerBehaviour.InstantiateObject();
    }

    public void SpawnOneButcherShop()
    {
        if (_butcherShopSpawnerBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevelBehaviour", "Fill in the '_butcherShopSpawnerBehaviour' field.");
            return;
        }

        _butcherShopSpawnerBehaviour.InstantiateObject();
    }

    public void SpawnOneTiger()
    {
        if (_tigerSpawnerBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevelBehaviour", "Fill in the '_tigerSpawnerBehaviour' field.");
            return;
        }

        _tigerSpawnerBehaviour.InstantiateObject();
    }
}
