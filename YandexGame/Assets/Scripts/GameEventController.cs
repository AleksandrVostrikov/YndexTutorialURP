using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventController : MonoBehaviour
{
    [SerializeField] private PlayerEventHandler _playerEventHandler;
    [SerializeField] private CoinCounter _coinCounter;
    [SerializeField] private GateHandler _gateHandler;

    private void OnEnable()
    {
        _playerEventHandler.collideWithCoin += _coinCounter.AddOneCoin;
        _playerEventHandler.collideWithGate += _gateHandler.ModifyPlayer;
    }
    private void OnDisable()
    {
        _playerEventHandler.collideWithCoin -= _coinCounter.AddOneCoin;
        _playerEventHandler.collideWithGate -= _gateHandler.ModifyPlayer;
    }
}
