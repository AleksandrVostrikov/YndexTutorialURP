using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour 
{
    [SerializeField] private PlayerEventHandler _playerEventHandler;
    [SerializeField] private TextMeshProUGUI _coinPresenter;

    private int _coinInLevel;

    public void AddOneCoin()
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
