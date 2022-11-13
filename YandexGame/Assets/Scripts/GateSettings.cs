using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GateSettings : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _gateText;

    [SerializeField] private Image _topImage;
    [SerializeField] private Image _glassImage;

    [SerializeField] private Color _positiveColor;
    [SerializeField] private Color _negativeColor;

    [SerializeField] private GateDeformationType _deformationType;

    [SerializeField] private GameObject _expandLable;
    [SerializeField] private GameObject _shrinkLable;
    [SerializeField] private GameObject _upLable;
    [SerializeField] private GameObject _downLable;

    [SerializeField] private PlayerMover _playerMover;


    [SerializeField] private int _value;

    private List<Transform> _gateType;

    const float _alpha = 0.5f;

    private void OnValidate()
    {
        SetFalseTopObjects();
        ChangeGate();
    }

    private void ChangeGate()
    {
        _gateText.text = _value.ToString();
        if (_value >= 0)
        {
            SetColor(_positiveColor);
        }
        else
        {
            SetColor(_negativeColor);
        }
        if (_deformationType == GateDeformationType.Height)
        {
            if (_value >= 0)
            {
                _expandLable.SetActive(true);
            }
            else
            {
                _shrinkLable.SetActive(true);
            }
        }
        else
        {
            if (_value >= 0)
            {
                _upLable.SetActive(true);
            }
            else
            {
                _downLable.SetActive(true);
            }
        }
    }

    private void SetFalseTopObjects()
    {
        _expandLable.SetActive(false);
        _shrinkLable.SetActive(false);
        _upLable.SetActive(false);
        _downLable.SetActive(false);
    }

    private void SetColor(Color color)
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, _alpha);
    }

}
