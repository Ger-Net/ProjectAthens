using UnityEngine;

namespace Assets.Scripts.Settlements.Buildings
{
    [CreateAssetMenu()]
    public abstract class BuildingBase : ScriptableObject
    {
        [SerializeField] protected int _cost;
    }
}
