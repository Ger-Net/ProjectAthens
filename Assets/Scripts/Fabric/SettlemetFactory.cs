using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SettlemetFactory : GameObjectFactory
{
    [SerializeField] private Settlement _townPrefab, _villagePrefab;

    public Settlement Get(SettlementType type)
    {
        switch (type)
        {
            case SettlementType.Town:
                return Get(_townPrefab);
            case SettlementType.Village:
                return Get(_villagePrefab);
        }

        return null;
    }

    private T Get<T>(T prefab) where T : Settlement
    {
        T instance = CreateGameObjectInstance(prefab);
        return instance;
    }
}
