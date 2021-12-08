using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChompQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public Inventory inventoryScript;

    public SpriteRenderer emote;
    public Sprite updatedEmote;

    public GreenyQuest greeny;

    public bool pepper = false;

    public Item item;

    void Update()
    {
        if (giverScript.quest.isActive == true)
            Player.q4 = giverScript.quest;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (pepper == true)
            {
                giverScript.quest.isActive = false;
                giverScript.quest.isComplete = true;

                inventoryScript.RemoveAllItems();

                GetItem();
                greeny.skull = true;
                emote.sprite = updatedEmote;
            }
        }
    }

    void GetItem()
    {
        Inventory.instance.Add(item);
        Debug.Log("Recieved " + item.name + " from Chomp");
    }
}
