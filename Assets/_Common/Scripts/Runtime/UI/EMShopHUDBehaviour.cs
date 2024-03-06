using UnityEngine;
using UnityEngine.UI;

public class EMShopHUDBehaviour : MonoBehaviour
{
    [SerializeField] private Button _clickButton;
    [SerializeField] private TMPro.TMP_Text _costText;
    [SerializeField] private string _maxText = "MAX";

    private EMShopType _type;

    public void SetType(EMShopType type)
    {
        _type = type;
    }

    public void SetCost(int cost)
    {
        if (_costText != null)
        {
            _costText.text = cost.ToString();
        }
    }

    public void SetIsMaxed(bool isMaxed)
    {
        if (_costText != null && isMaxed)
        {
            _costText.text = _maxText;
        }
    }

    private void OnEnable()
    {
        if (_clickButton != null)
        {
            _clickButton.onClick.AddListener(OnClicked);
        }
    }

    private void OnDisable()
    {
        if (_clickButton != null)
        {
            _clickButton.onClick.RemoveListener(OnClicked);
        }
    }

    private void OnClicked()
    {
        EMEvents.ShopHUDClicked?.Invoke(_type);
    }
}
