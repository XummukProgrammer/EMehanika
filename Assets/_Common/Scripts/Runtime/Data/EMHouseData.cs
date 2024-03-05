using UnityEngine;

[CreateAssetMenu(fileName = "House Data", menuName = "EMechanika/House Data", order = 2)]
public class EMHouseData : ScriptableObject
{
    [SerializeField] private int _additionalMoney;

    public int AdditionalMoney => _additionalMoney;
}
