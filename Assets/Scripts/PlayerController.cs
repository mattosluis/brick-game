using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform _playerTransform;
    private PlayerModel _playerModel;

    void Start()
    {
        _playerModel = GetComponent<PlayerModel>();
        _playerTransform = GetComponent<Transform>();
    }

    public void Move(float axisX)
    {
        Debug.Log(axisX);
        if ((_playerTransform.position.x < 1.4f && axisX > 0f) || (_playerTransform.position.x > -1.4f && axisX < 0f))
            _playerTransform.Translate(axisX * _playerModel.Speed, 0f, 0f);

    }
}
