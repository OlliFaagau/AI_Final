using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChompQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public SpriteRenderer emote;
    public Sprite updatedEmote;

    public GreenyQuest greeny;

    public bool sushi = false;

    void Update()
    {
        if (giverScript.quest.isActive == true)
            Player.q4 = giverScript.quest;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (sushi == true)
            {
                giverScript.quest.isActive = false;
                giverScript.quest.isComplete = true;

                emote.sprite = updatedEmote;

                greeny.skull = true;
            }
        }
    }
}
