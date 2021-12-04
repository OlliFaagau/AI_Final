using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugQuest : MonoBehaviour
{
    public QuestGiver giverScript;
    public SpriteRenderer emote;
    public Sprite updatedEmote;

    public bool book = false;

    public GameOver gameOverScript;

    void Update()
    {
        if (giverScript.quest.isActive == true)
            Player.q6 = giverScript.quest;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (book == true)
            {
                giverScript.quest.isActive = false;
                giverScript.quest.isComplete = true;
                emote.sprite = updatedEmote;
            }
        }
    }

    public void HappyEnding()
    {
        if (book == true)
            giverScript.FinalDialogue();
    }
}
