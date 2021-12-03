using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public Player playerScript;

    void Update()
    {
        if (giverScript.quest.isActive == true)
            playerScript.q1 = giverScript.quest;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Player.coins >= 10)
            {
                giverScript.quest.isActive = false;
                giverScript.quest.isComplete = true;
                Player.coins = 0;
                //Add Item to Inventory
            }
        }
    }
}
