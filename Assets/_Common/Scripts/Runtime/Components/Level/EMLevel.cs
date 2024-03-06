public static class EMLevel
{
    public static void SpawnLevelBehaviour()
    {
        if (EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevel", "The 'LevelSpawnerBehaviour' field of 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.InstantiateObject();
    }

    public static void SpawnOneTiger()
    {
        if (EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevel", "The 'LevelSpawnerBehaviour' field of 'LinksData' is empty!");
            return;
        }

        if (EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.LevelBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevel", "The 'LevelBehaviour' field of 'LevelSpawnerBehaviour' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.LevelBehaviour.SpawnOneTiger();
    }

    public static void SpawnOneHouse()
    {
        if (EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevel", "The 'LevelSpawnerBehaviour' field of 'LinksData' is empty!");
            return;
        }

        if (EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.LevelBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevel", "The 'LevelBehaviour' field of 'LevelSpawnerBehaviour' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.LevelBehaviour.SpawnOneHouse();
    }

    public static void SpawnOneButcherShop()
    {
        if (EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevel", "The 'LevelSpawnerBehaviour' field of 'LinksData' is empty!");
            return;
        }

        if (EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.LevelBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevel", "The 'LevelBehaviour' field of 'LevelSpawnerBehaviour' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.LevelBehaviour.SpawnOneButcherShop();
    }
}
