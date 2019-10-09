using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform _playerTransform;
    private PlayerModel _playerModel;
    private PlayerView _playerView;

    void Start()
    {
        _playerModel = GetComponent<PlayerModel>();
        _playerTransform = GetComponent<Transform>();
        _playerView = GetComponent<PlayerView>();
    }

    public void Move(float axisX)
    {
        Debug.Log(axisX);
        if ((_playerTransform.position.x < 1.4f && axisX > 0f) || (_playerTransform.position.x > -1.4f && axisX < 0f))
            _playerTransform.Translate(axisX * _playerModel.Speed, 0f, 0f);

    }

    public void hitLive()
    {
        _playerModel.Lifes--;

        Debug.Log(_playerModel.Lifes);

        if (_playerModel.Lifes > 0)
        {
            resetPosition();
        }
        else
        {
            ActivePanelGameOver();
        }
    }

    public void resetPosition()
    {
        _playerView.resetBallPosition();
    }

    public void ActivePanelGameOver()
    {
        _playerView.ActivePanelGameOver("Perdeu", _playerModel.Name, _playerModel.Score, _playerModel.JogadasEfetuadas);
    }

    public void addJogada()
    {
        _playerModel.JogadasEfetuadas++;
    }

    public void addScore()
    {
        _playerModel.Score++;
    }

    public void DestroyBrick()
    {
        _playerModel.QtyBrick--;

        if (_playerModel.QtyBrick <= 0)
        {
            _playerView.ActivePanelGameOver("Ganhou", _playerModel.Name, _playerModel.Score, _playerModel.JogadasEfetuadas);
        }
    }
}
