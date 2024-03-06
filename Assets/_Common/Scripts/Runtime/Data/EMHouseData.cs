using UnityEngine;

[CreateAssetMenu(fileName = "House Data", menuName = "EMechanika/House Data", order = 2)]
public class EMHouseData : ScriptableObject
{
    [SerializeField] private EMHouseType _type;
    [SerializeField] private int _additionalMoney;

    public EMHouseType Type => _type;
    public int AdditionalMoney => _additionalMoney;
}
