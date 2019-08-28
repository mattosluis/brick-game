using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{

    [SerializeField] private int _lifes;
    [SerializeField] private float _scaleX;
    [SerializeField] private float _speed;

    public int Lifes { get => _lifes; set => _lifes = value;}
    public float ScaleX { get => _scaleX; set => _scaleX = value; }
    public float Speed { get => _speed; set => _speed = value; }
}
