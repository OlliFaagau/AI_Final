using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public GameObject homeMenu;
    public GameObject sign;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Home")
        {
            homeMenu.SetActive(true);
        }
        
        if (col.gameObject.tag == "Sign")
        {
            sign.SetActive(true);
        }
    }
    void OnCollisionExit2D()
    {
        homeMenu.SetActive(false);
        sign.SetActive(false);
    }

    public void AnswerNo()
    {
        homeMenu.SetActive(false);
    }
}
