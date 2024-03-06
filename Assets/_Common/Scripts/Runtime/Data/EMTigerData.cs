using UnityEngine;

[CreateAssetMenu(fileName = "Tiger Data", menuName = "EMechanika/Tiger Data", order = 3)]
public class EMTigerData : ScriptableObject
{
    [SerializeField] private float _baseSpeed;
    [SerializeField] private float _additionalSpeed;
    [SerializeField] private float _additionalSpeedTime;

    public float BaseSpeed => _baseSpeed;
    public float AdditionalSpeed => _additionalSpeed;
    public float AdditionalSpeedTime => _additionalSpeedTime;
}
