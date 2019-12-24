using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickView : MonoBehaviour
{
    private BrickController _brickController;
    public PlayerView _playerView;

    private void Start()
    {
        _brickController = GetComponent<BrickController>();
    }

    public void PerformDamage(float damage)
    {
        _brickController.TakeDamage(damage);
    }

    public void addScore(string color)
    {
        _playerView.addScore(color);
    }

    public void DestroyBrick()
    {
        _playerView.DestroyBrick();
    }

    public string getColor()
    {
        return _brickController.getColor();
    }
}
