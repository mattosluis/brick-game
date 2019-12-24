using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickModel : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private string _color;

    public float Health { get => _health; set => _health = value; }
    public string Color { get => _color; set => _color = value; }
}
