using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour 
{
    [SerializeField] private PlayerMover playerMover;
    [SerializeField] private TextMeshProUGUI _coinPresenter;

    private int _coinInLevel;
    
    private void Start()
    {
        playerMover.collideWithCoin += AddOneCoin;
    }

    private void AddOneCoin()
    {
        _coinInLevel++;
        CoinInLevel = _coinInLevel;
    }

    public int CoinInLevel
    {
        get { return _coinInLevel; }
        set { _coinPresenter.text = value.ToString(); }
    }

}
