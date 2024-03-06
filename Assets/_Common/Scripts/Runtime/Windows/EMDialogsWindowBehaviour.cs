using UnityEngine;

public class EMDialogsWindowBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _dialogContainer;

    private EMDialogBehaviour _dialogBehaviour;

    public void InstantiateNewDialog(EMDialogBehaviour prefab)
    {
        if (prefab == null || _dialogContainer == null)
        {
            return;
        }

        if (_dialogBehaviour != null)
        {
            Destroy(_dialogBehaviour.gameObject);
        }

        _dialogBehaviour = Instantiate(prefab, _dialogContainer);
    }
}
