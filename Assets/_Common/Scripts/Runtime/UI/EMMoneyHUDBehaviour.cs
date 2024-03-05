using UnityEngine;

public class EMMoneyHUDBehaviour : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _text;

    public void SetMoney(int money)
    {
        if (_text == null)
        {
            EMDebugHelper.PrintError("EMMoneyHUDBehaviour", "The '_text' field is empty!");
            return;
        }

        _text.text = money.ToString();
    }
}
