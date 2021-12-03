using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Health health;
    private bool onOff = false;
    AudioSource audioFile;

    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        Time.timeScale = 1;
        gameOverPanel.SetActive(false);
        audioFile = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(health == 0)
        {
            GameOverNow();
        }*/
    }

    public void GameOverNow()
    {
        onOff = !onOff;

        if (onOff)
        {
            Time.timeScale = 0f;
            audioFile.Pause();
        }
        else
        {
            Time.timeScale = 1f;
            audioFile.Play();
        }

        gameOverPanel.SetActive(onOff);
    }
}
