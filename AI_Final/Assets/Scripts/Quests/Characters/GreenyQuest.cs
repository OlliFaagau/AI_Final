using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenyQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public Inventory inventoryScript;

    public SpriteRenderer emote;
    public Sprite updatedEmote;

    public BugQuest bug;

    public bool skull = false;

    public Item item;

    void FixedUpdate()
    {
        if (giverScript.quest.isActive == true)
            Player.q5 = giverScript.quest;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (skull == true)
            {
                giverScript.quest.isActive = false;
                giverScript.quest.isComplete = true;

                inventoryScript.RemoveAllItems();

                GetItem();
                bug.book = true;
                emote.sprite = updatedEmote;
            }
        }
    }

    void GetItem()
    {
        Inventory.instance.Add(item);
        Debug.Log("Recieved " + item.name + " from Greeny");
    }
}
