using Dreamteck.Splines;
using UnityEngine;

public class EMTigerBehaviour : EMObjectBehaviour
{
    [SerializeField] private EMTigerData _data;
    [SerializeField] private SplineFollower _splineFollower;

    private EMTigerSpeedModificator _speedModificator;

    public void SetSpline(SplineComputer spline)
    {
        if (_splineFollower == null)
        {
            EMDebugHelper.PrintError("EMTigerBehaviour", "The '_splineFollower' field is empty!");
            return;
        }

        _splineFollower.spline = spline;

        if (_data == null)
        {
            EMDebugHelper.PrintError("EMTigerBehaviour", "The '_data' field is empty!");
            return;
        }

        SetSpeed(_data.BaseSpeed);
    }

    public void SetSpeed(float speed)
    {
        if (_splineFollower == null)
        {
            EMDebugHelper.PrintError("EMTigerBehaviour", "The '_splineFollower' field is empty!");
            return;
        }

        _splineFollower.followSpeed = speed;
    }

    private void Start()
    {
        if (_data == null)
        {
            EMDebugHelper.PrintError("EMTigerBehaviour", "The '_data' field is empty!");
            return;
        }

        _speedModificator = new EMTigerSpeedModificator(this, _data.BaseSpeed, _data.AdditionalSpeed, _data.AdditionalSpeedTime);
    }

    private void OnEnable()
    {
        EMEvents.Tapped += OnTapped;
    }

    private void OnDisable()
    {
        EMEvents.Tapped -= OnTapped;
    }

    private void Update()
    {
        if (_speedModificator != null)
        {
            _speedModificator.OnUpdate();
        }
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
        if (_speedModificator != null)
        {
            _speedModificator.Activate();
        }
    }
}
