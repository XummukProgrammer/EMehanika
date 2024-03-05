public class EMLevelSpawnerBehaviour : EMSpawnerBehaviour
{
    public EMLevelBehaviour LevelBehaviour { get; private set; }

    protected override void InitObject(EMObjectBehaviour objectBehaviour)
    {
        base.InitObject(objectBehaviour);

        if (objectBehaviour is EMLevelBehaviour levelBehaviour)
        {
            InitLevel(levelBehaviour);
        }
    }

    private void InitLevel(EMLevelBehaviour levelBehaviour)
    {
        LevelBehaviour = levelBehaviour;
    }
}
