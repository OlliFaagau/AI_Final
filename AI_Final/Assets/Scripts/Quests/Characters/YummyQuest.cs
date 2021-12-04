using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YummyQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public SpriteRenderer emote;
    public Sprite updatedEmote;

    public ChompQuest chomp;

    public bool diamond = false;

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

                emote.sprite = updatedEmote;

                chomp.sushi = true;
            }
        }
    }
}
