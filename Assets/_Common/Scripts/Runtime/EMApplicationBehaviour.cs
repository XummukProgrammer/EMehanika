using UnityEngine;

public class EMApplicationBehaviour : MonoBehaviour
{
    [SerializeField] private EMGlobalData _globalData;
    [SerializeField] private EMLinksData _linksData;

    private EMComponents _components = new();

    public static EMApplicationBehaviour Instance { get; private set; }

    public EMGlobalData GlobalData => _globalData;
    public EMLinksData LinksData => _linksData;
    public EMComponents Components => _components;

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
        boostrap.Setup(_components, _globalData);

        _components.StatesManager.OnInit();
        EMResources.OnInit();
    }

    private void OnDestroy()
    {
        var boostrap = new EMBoostrap();
        boostrap.Destroy(_components);

        _components.StatesManager.OnDeinit();
        EMResources.OnDeinit();
    }

    private void Update()
    {
        _components.StatesManager.OnUpdate();
    }
}
