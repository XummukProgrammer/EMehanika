public class EMLevelState : IEMState
{
    public void OnInit()
    {
    }

    public void OnDeinit()
    {
    }

    public void OnEnter()
    {
        if (EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour == null)
        {
            EMDebugHelper.PrintError("EMLevelState", "The 'LevelSpawnerBehaviour' field of 'LinksData' is empty!");
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.InstantiateObject();

        if (EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.LevelBehaviour == null)
        {
            return;
        }

        EMApplicationBehaviour.Instance.LinksData.LevelSpawnerBehaviour.LevelBehaviour.SpawnOneTiger();
    }

    public void OnExit()
    {
    }

    public void OnUpdate()
    {
    }
}
