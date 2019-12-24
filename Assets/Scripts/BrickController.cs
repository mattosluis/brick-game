using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    private BrickModel _brickModel;
    public GameObject explosion;
    private GameObject ex;

    private void Start()
    {
        _brickModel = GetComponent<BrickModel>();
    }

    public void TakeDamage(float damage)
    {
        _brickModel.Health -= 1;

        if (_brickModel.Health <= 0)
        {
            SoundController.PlayExplosion();
            ex = Instantiate(explosion);
            ex.transform.position = _brickModel.transform.position;
            ex.SetActive(true);
            Destroy(gameObject);
        }
    }

    public string getColor()
    {
        return _brickModel.Color;
    }
}
