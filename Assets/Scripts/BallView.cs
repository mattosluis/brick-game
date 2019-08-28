using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallView : MonoBehaviour
{
    private BallController _ballController;


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
        } 

        if (collision.gameObject.tag == "player")
        {
            //collision.gameObject
        } 
        else
        {
            //_brickView.PerformDamage(1);
        }
    }
}
