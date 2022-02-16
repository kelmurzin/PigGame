using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private float _leftLimit, _rightLimit, _bottomLimit, _topLimit;    
    [SerializeField] private Transform _player;

    private void LateUpdate()
    {
        transform.position = new Vector3(_player.position.x, _player.position.y, transform.position.z);
        transform.position = new Vector3(
        Mathf.Clamp(transform.position.x, _leftLimit, _rightLimit),
        Mathf.Clamp(transform.position.y, _bottomLimit, _topLimit),
        transform.localPosition.z);
    }
}
