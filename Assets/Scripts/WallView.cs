using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallView : MonoBehaviour
{
    public PlayerView _playerView;

    public void hitLive()
    {
        _playerView.hitLive();
    }
}
