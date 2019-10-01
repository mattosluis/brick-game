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
        _ballModel.Direction = Vector2.Reflect(_ballModel.Direction, collision.contacts[0].normal);

        _ballRigidBody.velocity = _ballModel.Direction * _ballModel.Speed;
    }

    public Vector2 CalcBallAngleReflect(Collision2D collision)
    {
        float playerPixels = 120f;
        float unityScaled = playerPixels / 2f / 100f;
        float scaleFactor = 1.5f;

        float angledegunityScale = (collision.transform.position.x - transform.position.x + unityScaled) * scaleFactor;

        float angleDeg = angledegunityScale * 100f;
        float angleRad = angleDeg * Mathf.PI / 180f;

        return new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
    }

}
