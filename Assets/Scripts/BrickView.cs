﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickView : MonoBehaviour
{
    private BrickController _brickController;

    private void Start()
    {
        _brickController = GetComponent<BrickController>();
    }

    public void PerformDamage(float damage)
    {
        _brickController.TakeDamage(damage);
    }
}