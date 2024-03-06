using UnityEngine;

public class EMTigerSpeedModificator
{
    private EMTigerBehaviour _tigerBehaviour;
    private float _baseSpeed;
    private float _modificatedSpeed;
    private float _seconds;

    public static float Time { get; private set; }

    public static bool CanActivate => Time <= 0;

    public EMTigerSpeedModificator(EMTigerBehaviour tigerBehaviour, float baseSpeed, float additionalSpeed, float seconds)
    {
        _tigerBehaviour = tigerBehaviour;
        _baseSpeed = baseSpeed;
        _modificatedSpeed = baseSpeed + additionalSpeed;
        _seconds = seconds;

        Time = 0;
    }

    public void Activate()
    {
        if (!CanActivate)
        {
            return;
        }

        Time = _seconds;

        if (_tigerBehaviour != null )
        {
            _tigerBehaviour.SetSpeed(_modificatedSpeed);
        }
    }

    public void Deactivate()
    {
        Time = 0;

        if (_tigerBehaviour != null)
        {
            _tigerBehaviour.SetSpeed(_baseSpeed);
        }
    }

    public void OnUpdate()
    {
        if (Time > 0)
        {
            Time -= UnityEngine.Time.deltaTime;

            if (Time <= 0)
            {
                Deactivate();
            }
        }
    }
}
