using UnityEngine;

public class EMTigerBehaviour : EMObjectBehaviour
{
    [SerializeField] private EMTigerData _data;

    private void OnEnable()
    {
        EMEvents.Tapped += OnTapped;
    }

    private void OnDisable()
    {
        EMEvents.Tapped -= OnTapped;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EMHouseBehaviour houseBehaviour))
        {
            houseBehaviour.CrossedWithTiger();
        }
    }

    private void OnTapped()
    {
    }
}
