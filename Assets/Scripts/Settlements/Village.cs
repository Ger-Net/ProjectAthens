using Assets.Scripts.Common.Interfaces.Settlements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : Settlement
{
    protected override bool IsBuildingAvailable(IBuildable buildable)
    {
        return buildable is ITownBuildable;
    }
}
