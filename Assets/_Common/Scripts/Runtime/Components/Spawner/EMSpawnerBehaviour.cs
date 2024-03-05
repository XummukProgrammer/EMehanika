using System.Collections.Generic;
using UnityEngine;

public class EMSpawnerBehaviour : MonoBehaviour
{
    [SerializeField] private EMObjectBehaviour _prefab;
    [SerializeField] private Transform[] _spawnPoints;

    private List<EMObjectBehaviour> _objects = new();

    public void InstantiateObject()
    {
        if (_prefab == null)
        {
            EMDebugHelper.PrintError("EMSpawnerBehaviour", "The prefab is not specified.");
            return;
        }

        if (_objects.Count >= _spawnPoints.Length)
        {
            EMDebugHelper.PrintError("EMSpawnerBehaviour", "There are no spawn points.");
            return;
        }

        var container = _spawnPoints[_objects.Count];

        var objectBehaviour = Instantiate(_prefab, container);
        InitObject(objectBehaviour);

        _objects.Add(objectBehaviour);
    }

    public void ClearObjects()
    {
        _objects.Clear();
    }

    protected virtual void InitObject(EMObjectBehaviour objectBehaviour) { }
}
