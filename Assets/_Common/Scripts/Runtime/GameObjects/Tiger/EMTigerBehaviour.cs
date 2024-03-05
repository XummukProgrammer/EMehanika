using Dreamteck.Splines;
using UnityEngine;

public class EMTigerBehaviour : EMObjectBehaviour
{
    [SerializeField] private EMTigerData _data;
    [SerializeField] private SplineFollower _splineFollower;

    public void SetSpline(SplineComputer spline)
    {
        if (_data == null)
        {
            EMDebugHelper.PrintError("EMTigerBehaviour", "The '_data' field is empty!");
            return;
        }

        if (_splineFollower == null)
        {
            EMDebugHelper.PrintError("EMTigerBehaviour", "The '_splineFollower' field is empty!");
            return;
        }

        _splineFollower.spline = spline;
        _splineFollower.followSpeed = _data.BaseSpeed;
    }

    private void OnEnable()
    {
        EMEvents.Tapped += OnTapped;
    }

    private void OnDisable()
    {
        EMEvents.Tapped -= OnTapped;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EMHouseBehaviour houseBehaviour))
        {
            houseBehaviour.CrossedWithTiger();
        }
    }

    private void OnTapped()
    {
    }
}
