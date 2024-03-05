using Dreamteck.Splines;
using UnityEngine;

public class EMTigerSpawnerBehaviour : EMSpawnerBehaviour
{
    [SerializeField] private SplineComputer _spline;

    protected override void InitObject(EMObjectBehaviour objectBehaviour)
    {
        base.InitObject(objectBehaviour);

        if (objectBehaviour is EMTigerBehaviour tigerBehaviour)
        {
            InitTiger(tigerBehaviour);
        }
    }

    private void InitTiger(EMTigerBehaviour tigerBehaviour)
    {
        if (_spline == null)
        {
            EMDebugHelper.PrintError("EMTigerSpawnerBehaviour", "The '_spline' field is empty!");
            return;
        }

        tigerBehaviour.SetSpline(_spline);
    }
}
