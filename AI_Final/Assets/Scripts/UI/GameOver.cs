using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool GAMEOVER = false;

    public GameObject gameOverPanel;
    public GameObject winnerPanel;

    public GameObject aiEnemy;

    public Health healthScript;
    public QuestGiver q1, q2, q3, q4, q5, q6;

    public CharacterController moveScript;

    public GameObject healthUI;

    AudioSource audioFile;

    void Start()
    {
        gameOverPanel.SetActive(false);
        audioFile = FindObjectOfType<AudioSource>();
    }

    void Update()
    {
        if(healthScript.curHealth == 0)
            GameOverNow();

        if (GAMEOVER == true)
            Winner();
    }

    public void GameOverNow()
    {
        Time.timeScale = 0f;
        audioFile.Pause();
        gameOverPanel.SetActive(true);
    }

    public void Winner()
    {
        healthUI.SetActive(false);
        aiEnemy.SetActive(false);
        moveScript.Movementenabled = false;
        winnerPanel.SetActive(true);
    }

    public void ResetGame()
    {
        Player.coins = 0;
        Player.burgers = 0;
        Player.q1 = null;
        Player.q2 = null;
        Player.q3 = null;
        Player.q4 = null;
        Player.q5 = null;
        Player.q6 = null;
    }
}
