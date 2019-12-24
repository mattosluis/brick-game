using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerController _playerController;
    public BallView _ballView;
    public UIView _uiView;

    private void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        _playerController.Move(h);
    }

    public void hitLive()
    {
        _playerController.hitLive();
    }

    public void resetBallPosition()
    {
        _ballView.resetBallPosition();
    }

    public void ActivePanelGameOver(string title, string playerName, int score)
    {
        _uiView.ActivePanelGameOver(title, playerName, score);
    }

    public void addJogada()
    {
        _playerController.addJogada();
    }

    public void addScore(string color)
    {
        _playerController.addScore(color);
    }

    public void DestroyBrick()
    {
        _playerController.DestroyBrick();
    }
}
