using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    public GameObject homeMenu;
    public GameObject sign;
    public Text coinText;
    public GameObject caveFade, fadeIn;

    public CharacterController playerScript;

    void Start()
    {
        fadeIn.SetActive(true);

        if(Player.coins >= 9)
        {
            GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
            foreach (GameObject coin in coins)
            {
                GameObject.Destroy(coin);
            }
        }
    }

    void Update()
    {
        coinText.text = Player.coins.ToString();
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
            Player.coins++;
            Destroy(col.gameObject);
        }

        if(col.gameObject.tag == "Cave")
        {
            playerScript.Movementenabled = false;

            if (caveFade.activeSelf)
                caveFade.GetComponent<Animation>().Play("Fade");
            else
                caveFade.SetActive(true);
            
            transform.position = new Vector3(-28, 0, 0);

            StartCoroutine(TimeDelay());
        }

        if (col.gameObject.tag == "CaveExit")
        {
            
            playerScript.Movementenabled = false;

            fadeIn.GetComponent<Animation>().Play("Fade");
            
            transform.position = new Vector3(-6.5f, -10, 0);

            StartCoroutine(timeDelay());
        }

        if(col.gameObject.tag == "Burger")
        {
            Player.burgers++;
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

    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(2);

        playerScript.Movementenabled = true;
    }

    IEnumerator timeDelay()
    {
        yield return new WaitForSeconds(2);

        playerScript.Movementenabled = true;
    }
}
