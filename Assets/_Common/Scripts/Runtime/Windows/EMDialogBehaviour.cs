using UnityEngine;
using UnityEngine.UI;

public class EMDialogBehaviour : MonoBehaviour
{
    [SerializeField] private Button _skipButton;

    private void OnEnable()
    {
        if (_skipButton != null)
        {
            _skipButton.onClick.AddListener(OnSkipClicked);
        }
    }

    private void OnDisable()
    {
        if (_skipButton != null)
        {
            _skipButton.onClick.RemoveListener(OnSkipClicked);
        }
    }

    private void OnSkipClicked()
    {
        EMEvents.SkipDialog?.Invoke();
    }
}
