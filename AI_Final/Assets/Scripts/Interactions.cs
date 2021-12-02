using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    public GameObject homeMenu;
    public GameObject sign;
    public Text coinText;

    void Start()
    {
        if(Variables.coins >= 9)
        {
            GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
            foreach (GameObject coin in coins)
            {
                GameObject.Destroy(coin);
            }
        }
    }

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

        if(col.gameObject.tag == "Coin")
        {
            Variables.coins++;
            coinText.text = Variables.coins.ToString();
            Destroy(col.gameObject);
        }

        if(col.gameObject.tag == "Cave")
        {
            transform.position = new Vector3(-28, 0, 0);
        }

        if (col.gameObject.tag == "CaveExit")
        {
            transform.position = new Vector3(-6.5f, -10, 0);
        }

        if(col.gameObject.tag == "Burger")
        {
            //increment burger counter
            //add item to inventory
            Destroy(col.gameObject);
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
