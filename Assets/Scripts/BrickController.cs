using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    private BrickModel _brickModel;

    private void Start()
    {
        _brickModel = GetComponent<BrickModel>();
    }

    public void TakeDamage(float damage)
    {
        _brickModel.Health -= 1;

        if (_brickModel.Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
