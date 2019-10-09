using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{

    [SerializeField] private int _lifes;
    [SerializeField] private float _scaleX;
    [SerializeField] private float _speed;

    [SerializeField] private string _name;
    private int _jogadasEfetuadas;
    private int _score;
    private int _qtyBrick = 16;

    public int Lifes { get => _lifes; set => _lifes = value;}
    public float ScaleX { get => _scaleX; set => _scaleX = value; }
    public float Speed { get => _speed; set => _speed = value; }
    public string Name { get => _name; set => _name = value; }
    public int JogadasEfetuadas { get => _jogadasEfetuadas; set => _jogadasEfetuadas = value; }
    public int Score { get => _score; set => _score = value; }
    public int QtyBrick { get => _qtyBrick; set => _qtyBrick = value; }
}
