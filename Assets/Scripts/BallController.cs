using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private BallModel _ballModel;
    private Rigidbody2D _ballRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        _ballModel = GetComponent<BallModel>();
        _ballRigidBody = GetComponent<Rigidbody2D>();

        //_ballRigidBody.velocity = _ballModel.Direction * _ballModel.Speed;
        AngleChange(_ballModel.Direction);
    }

    // Update is called once per frame
    public void AngleChange(Vector2 dir)
    {
        _ballModel.Direction = dir;
        _ballRigidBody.velocity = _ballModel.Direction * _ballModel.Speed;
    }

    public void PerfectAngleReflect(Collision2D collision)
    {

    }
}
