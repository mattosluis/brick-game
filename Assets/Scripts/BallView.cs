using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallView : MonoBehaviour
{
    private BallController _ballController;
    public PlayerView _playerView;
    public WallView _wallView;


    private void Start()
    {
        _ballController = GetComponent<BallController>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "brick")
        {
            BrickView _brickView;
            _brickView = collision.gameObject.GetComponent<BrickView>();
            _brickView.PerformDamage(1f);
            _brickView.addScore(_brickView.getColor());
            _brickView.DestroyBrick();
        } 

        if (collision.gameObject.tag == "Player")
        {
            //collision.gameObject
            _ballController.AngleChange(_ballController.CalcBallAngleReflect(collision));
            _playerView = collision.gameObject.GetComponent<PlayerView>();
            _playerView.addJogada();
        } 
        else
        {
            //_brickView.PerformDamage(1);
            _ballController.PerfectAngleReflect(collision);
        }
        if (collision.gameObject.tag == "Wall")
        {
            _wallView = collision.gameObject.GetComponent<WallView>();
            SoundController.PlayhitGround();
            _wallView.hitLive();
        }
    }

    public void resetBallPosition()
    {
        _ballController.resetPosition();
    }
}
