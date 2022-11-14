using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateHandler : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private PlayerModifer _modifer;

    private void OnEnable()
    {
        _playerMover.collideWithGate += ModifyPlayer;
    }

    private void OnDisable()
    {
        _playerMover.collideWithGate -= ModifyPlayer;
    }

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
