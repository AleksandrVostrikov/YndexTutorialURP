using TMPro;
using UnityEngine;


public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animator;
    

    private float _previousMousPosition;
    private float _eulerAngleY;

    public delegate void CoinPicked();
    public event CoinPicked collideWithCoin;

    public delegate void GatePicked(int value, GateDeformationType gateDeformationType);
    public event GatePicked collideWithGate;

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (Input.GetMouseButton(0))
        {
            SetPosition();
            SetAngle();
        }
        SetAnimation();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(GameNames.Coin.ToString()))
        {
            collideWithCoin?.Invoke();
        }
        else if (other.gameObject.CompareTag(GameNames.Gate.ToString()))
        {
            int val = int.Parse(other.gameObject.GetComponentInChildren<TextMeshProUGUI>().text);
            Debug.Log(val);
            GateDeformationType gate = other.gameObject.GetComponent<GateSettings>().CurrentGateType;
            collideWithGate?.Invoke(val, gate);
        }
    }

    private void SetPosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _previousMousPosition = Input.mousePosition.x;
        }

        Vector3 position = transform.position += transform.forward * _speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.5f, 2.5f);
        transform.position = position;
    }
    private void SetAngle()
    {
        float deltaX = Input.mousePosition.x - _previousMousPosition;
        _previousMousPosition = Input.mousePosition.x;
        _eulerAngleY += deltaX;
        _eulerAngleY = Mathf.Clamp(_eulerAngleY, -70, 70);
        transform.eulerAngles = new Vector3(0, _eulerAngleY, 0);
    }
    private void SetAnimation()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetBool("IsRunning", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool("IsRunning", false);
        }
    }
}
