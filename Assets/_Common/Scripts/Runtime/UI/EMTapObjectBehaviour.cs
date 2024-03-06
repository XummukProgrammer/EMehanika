using UnityEngine;
using UnityEngine.UI;

public class EMTapObjectBehaviour : MonoBehaviour
{
    [SerializeField] private Button _tapButton;

    private void OnEnable()
    {
        if (_tapButton != null)
        {
            _tapButton.onClick.AddListener(OnTapped);
        }
    }

    private void OnDisable()
    {
        if (_tapButton != null)
        {
            _tapButton.onClick.RemoveListener(OnTapped);
        }
    }

    private void OnTapped()
    {
        EMEvents.Tapped?.Invoke();
    }
}
