using UnityEngine;

public class EMTigerSpeedModificator
{
    private EMTigerBehaviour _tigerBehaviour;
    private float _baseSpeed;
    private float _modificatedSpeed;
    private float _seconds;

    private float _time;

    public bool CanActivate => _time <= 0;

    public EMTigerSpeedModificator(EMTigerBehaviour tigerBehaviour, float baseSpeed, float additionalSpeed, float seconds)
    {
        _tigerBehaviour = tigerBehaviour;
        _baseSpeed = baseSpeed;
        _modificatedSpeed = baseSpeed + additionalSpeed;
        _seconds = seconds;

        _time = 0;
    }

    public void Activate()
    {
        if (!CanActivate)
        {
            return;
        }

        _time = _seconds;

        if (_tigerBehaviour != null )
        {
            _tigerBehaviour.SetSpeed(_modificatedSpeed);
        }
    }

    public void Deactivate()
    {
        _time = 0;

        if (_tigerBehaviour != null)
        {
            _tigerBehaviour.SetSpeed(_baseSpeed);
        }
    }

    public void OnUpdate()
    {
        if (_time > 0)
        {
            _time -= Time.deltaTime;

            if (_time <= 0)
            {
                Deactivate();
            }
        }
    }
}
