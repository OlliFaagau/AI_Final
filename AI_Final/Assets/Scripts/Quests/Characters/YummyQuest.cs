using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YummyQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public Inventory inventoryScript;

    public SpriteRenderer emote;
    public Sprite updatedEmote;

    public ChompQuest chomp;

    public bool diamond = false;

    public Item item;

    void Update()
    {
        if (giverScript.quest.isActive == true)
            Player.q3 = giverScript.quest;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (diamond == true)
            {
                giverScript.quest.isActive = false;
                giverScript.quest.isComplete = true;

                inventoryScript.RemoveAllItems();

                GetItem();
                chomp.pepper = true;
                emote.sprite = updatedEmote;
            }
        }
    }

    void GetItem()
    {
        Inventory.instance.Add(item);
        Debug.Log("Recieved " + item.name + " from Yummy");
    }
}
