using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PawPawQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public Player playerScript;

    public GameObject burgerBunch;

    public GameObject timer;
    public Text timerText;
    public float currentTime = 0f;
    public float startingTime = 60f;

    public bool attempt;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        if (giverScript.quest.isActive == true)
        {
            playerScript.q2 = giverScript.quest;

            GameObject[] burgs;
            burgs = GameObject.FindGameObjectsWithTag("Burger");

            if (burgs.Length == 0)
                Instantiate(burgerBunch);
            
            timer.SetActive(true);
            attempt = true;
        }

        if (currentTime <= 0)
        {
            timer.SetActive(false);

            //Remove all burgers from inventory
            
            giverScript.quest.isActive = false;
            currentTime = 60;
            attempt = false;
            Destroy(burgerBunch);
        }
        
        if (attempt == true)
        {
            currentTime -= 1 * Time.deltaTime;
            timerText.text = currentTime.ToString("0");
        }   
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Player.burgers >= 5 && currentTime > 0)
            {
                giverScript.quest.isActive = false;
                giverScript.quest.isComplete = true;
                Player.burgers = 0;
                //Remove all burgers from inventory
                //Add New Item to Inventory
                timer.SetActive(false);
                attempt = false;
                Destroy(burgerBunch);
                Player.coins++;
            }
        }
    }
}
