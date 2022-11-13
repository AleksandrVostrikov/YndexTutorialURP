using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] Transform _player;

    private void LateUpdate()
    {
        transform.position = _player.position;
    }
}
