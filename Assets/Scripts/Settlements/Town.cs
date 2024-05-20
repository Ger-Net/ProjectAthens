using Assets.Scripts.Common.Interfaces.Settlements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Town : Settlement
{
    protected override bool IsBuildingAvailable(IBuildable buildable)
    {
        throw new System.NotImplementedException();
    }
}
