using UnityEngine;

public class EMHouseBehaviour : EMObjectBehaviour
{
    [SerializeField] private EMHouseData _data;

    public void CrossedWithTiger()
    {
        if (_data == null)
        {
            EMDebugHelper.PrintError("EMHouseBehaviour", "The '_data' field is empty!");
            return;
        }

        EMEvents.HouseCrossed?.Invoke(_data.AdditionalMoney, _data.Type);
    }
}
