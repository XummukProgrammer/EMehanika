using UnityEngine;

public class EMApplicationBehaviour : MonoBehaviour
{
    [SerializeField] private EMGlobalData _globalData;
    [SerializeField] private EMLinksData _linksData;

    public static EMApplicationBehaviour Instance { get; private set; }

    public EMGlobalData GlobalData => _globalData;
    public EMLinksData LinksData => _linksData;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            EMDebugHelper.PrintError("EMApplicationBehaviour", "You can't recreate the main stage.");
        }
    }

    private void Start()
    {
        var boostrap = new EMBoostrap();
        boostrap.Setup(this);
    }
}
