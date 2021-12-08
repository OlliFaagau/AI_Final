using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public SpriteRenderer emote;
    public Sprite updatedEmote;

    public YummyQuest yummy;
    
    public Item item;

    void Update()
    {
        if (giverScript.quest.isActive == true)
            Player.q1 = giverScript.quest;
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

                GetItem();
                yummy.diamond = true;
                emote.sprite = updatedEmote;
            }
        }
    }

    void GetItem()
    {
        Inventory.instance.Add(item);
        Debug.Log("Recieved " + item.name + " from Mr. World");
    }
}
