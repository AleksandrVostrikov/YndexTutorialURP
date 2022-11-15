using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerEventHandler : MonoBehaviour
{
    public delegate void CoinPicked();
    public delegate void GatePicked(int value, GateDeformationType gateDeformationType);

    public event CoinPicked collideWithCoin;
    public event GatePicked collideWithGate;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag(GameNames.Coin.ToString()))
        {
            collideWithCoin?.Invoke();
        }
        else if (other.gameObject.CompareTag(GameNames.Gate.ToString()))
        {
            int val = int.Parse(other.gameObject.GetComponentInChildren<TextMeshProUGUI>().text);
            GateDeformationType gate = other.gameObject.GetComponent<GateSettings>().CurrentGateType;
            collideWithGate?.Invoke(val, gate);
        }
       
    }
}
