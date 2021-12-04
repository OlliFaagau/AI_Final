using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Play()
    {
        SceneManager.LoadScene("Play");
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
