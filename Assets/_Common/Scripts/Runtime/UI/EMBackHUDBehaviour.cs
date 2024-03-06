using UnityEngine;
using UnityEngine.UI;

public class EMBackHUDBehaviour : MonoBehaviour
{
    [SerializeField] private Button _clickButton;

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
        EMEvents.ToMenuClicked?.Invoke();
    }
}
