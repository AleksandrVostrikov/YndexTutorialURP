using UnityEngine;

public class PlayerModifer : MonoBehaviour
{
    [SerializeField] private int _width;
    [SerializeField] private int _height;

    [SerializeField] private Renderer _playerRenderer;

    [SerializeField] private Transform _topSpine;
    [SerializeField] private Transform _bottomSpine;

    [SerializeField] private Transform _colliderTransform;

    const float _widthMultiplier = 0.0005f;
    const float _heightMultiplier = 0.01f;

    public void AddWidth(int gateValue)
    {
        _width += gateValue;
        _playerRenderer.material.SetFloat("_PushValue", _width * _widthMultiplier);
    }

    public void AddHeight(int gateValue)
    {
        float offsetY = gateValue * _heightMultiplier + 0.17f;
        //_topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);
        _topSpine.position += new Vector3(0, offsetY, 0);
        _colliderTransform.localScale = new Vector3(1, 2f + _height * _heightMultiplier, 1);
    }


}
