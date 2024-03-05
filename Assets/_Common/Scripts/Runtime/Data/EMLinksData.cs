using UnityEngine;

[System.Serializable]
public class EMLinksData
{
    [SerializeField] private EMLevelSpawnerBehaviour _levelSpawnerBehaviour;

    public EMLevelSpawnerBehaviour LevelSpawnerBehaviour => _levelSpawnerBehaviour;
}
