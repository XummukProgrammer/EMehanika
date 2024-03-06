using UnityEngine;

public class EMMeatHUDBehaviour : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _text;

    public void SetMeat(int meat)
    {
        if (_text == null)
        {
            EMDebugHelper.PrintError("EMMeatHUDBehaviour", "The '_text' field is empty!");
            return;
        }

        _text.text = meat.ToString();
    }
}
