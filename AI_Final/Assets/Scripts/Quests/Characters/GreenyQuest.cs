using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenyQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public SpriteRenderer emote;
    public Sprite updatedEmote;

    public BugQuest bug;

    public bool skull = false;

    void Update()
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

                emote.sprite = updatedEmote;

                bug.book = true;
            }
        }
    }
}
