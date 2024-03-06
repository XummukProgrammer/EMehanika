using UnityEngine;
using UnityEngine.UI;

public class EMMenuWindowBehaviour : MonoBehaviour
{
    [SerializeField] private Button _playButton;

    private void OnEnable()
    {
        if (_playButton != null)
        {
            _playButton.onClick.AddListener(OnPlayClicked);
        }
    }

    private void OnDisable()
    {
        if (_playButton != null)
        {
            _playButton.onClick.RemoveListener(OnPlayClicked);
        }
    }

    private void OnPlayClicked()
    {
        EMEvents.PlayClicked?.Invoke();
    }
}
