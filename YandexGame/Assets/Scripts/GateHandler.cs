using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateHandler : MonoBehaviour
{
    [SerializeField] private PlayerEventHandler _playerMover;
    [SerializeField] private PlayerModifer _modifer;

    public void ModifyPlayer(int value, GateDeformationType gateDeformationType)
    {
        if (gateDeformationType == GateDeformationType.Width)
        {
            _modifer.AddWidth(value);
        }
        else if (gateDeformationType == GateDeformationType.Height)
        {
            _modifer.AddHeight(value);
        }
    }

}
