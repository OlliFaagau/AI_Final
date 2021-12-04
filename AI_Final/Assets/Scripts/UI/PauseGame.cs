using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pausePanel;
    private bool onOff = false;
    AudioSource audioFile;

    void Start()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        audioFile = FindObjectOfType<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseNow();
        }
    }

    public void PauseNow()
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

        pausePanel.SetActive(onOff);
    }
}
