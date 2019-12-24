using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
    public GameObject panel;
    public BallView _ballView;
    public PlayerView _playerView;
    public BrickView _brickView;

    public Text _title;
    public Text _score;
    public Text _jogadas;

    public void ActivePanelGameOver(string title, string playerName, int score)
    {
        panel.SetActive(true);
        _title.text = title + " " + playerName;
        _score.text = "Score: " + score;
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("brickgame");
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
