using Assets.Scripts.Common.Interfaces.Settlements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Settlement : MonoBehaviour
{
    [SerializeField] private string _name;

    [SerializeField] private int _maxPopulation;
    [SerializeField] private int _population;

    [SerializeField] protected List<IBuildable> _buildings;

    public void Init(Transform transform, int pop = 100, int maxPop = 10000)
    {
        _buildings = new List<IBuildable>();
        _maxPopulation = maxPop;
        _population = pop;
        this.transform.position = transform.position;
    }
    protected abstract bool IsBuildingAvailable(IBuildable buildable);
}
