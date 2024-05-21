using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MapMain : MonoBehaviour
{
    [SerializeField] private SettlemetFactory _settlemetFactory;

    [SerializeField] private Transform[] _townsParent;
    [SerializeField] private Transform[] _villagesParent;

    [SerializeField] private List<Town> _towns;
    [SerializeField] private List<Village> _villages;

    public IReadOnlyList<Town> Towns => _towns;
    public IReadOnlyList<Village> Villages => _villages;

    public void GenerateSettlements()
    {
        GenerateTowns();
        GenerateVillages();
    }
    public List<Settlement> LocateAllSettelments()
    {
        List<Settlement> settlements = new List<Settlement>();
        settlements.AddRange(_towns);
        settlements.AddRange(_villages);
        return settlements;
    }

    private void GenerateTowns()
    {
        foreach (var t in _townsParent)
        {
            var town = _settlemetFactory.Get(SettlementType.Town);
            town.Init(t, Random.Range(100, 1000));
            _towns.Add((Town)town);
            Destroy(t.gameObject);
        }
        _townsParent = null;
    }
    private void GenerateVillages()
    {
        foreach (var t in _villagesParent)
        {
            var village = _settlemetFactory.Get(SettlementType.Village);
            village.Init(t, Random.Range(100, 1000));
            _villages.Add((Village)village);
            Destroy(t.gameObject);
        }
        _villagesParent = null;
    }
}
