using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Global Data", menuName = "EMechanika/Global Data", order = 1)]
public class EMGlobalData : ScriptableObject
{
    [SerializeField] private EMShopData[] _shopItems;
    [SerializeField] private EMDialogBehaviour[] _startDialogsPrefabs;

    public List<EMShopData>.Enumerator ShopItems => _shopItems.ToList().GetEnumerator();
    public List<EMDialogBehaviour> StartDialogsPrefabs => _startDialogsPrefabs.ToList();
}
