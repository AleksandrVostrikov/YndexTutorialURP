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
        float offsetX = _topSpine.localPosition.x - gateValue * _heightMultiplier; 
        _topSpine.localPosition = new Vector3(offsetX, _topSpine.localPosition.y, _topSpine.localPosition.z);
        if (gateValue > 0)
        {
            _colliderTransform.localScale = new Vector3(1, _colliderTransform.localScale.y - offsetX, 1);
        }
        else
        {
            _colliderTransform.localScale = new Vector3(1, _colliderTransform.localScale.y + offsetX, 1);
        }
        
    }


}
