using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public Player player;

    public GameObject dialogueBubble;
    public GameObject acceptButton;
    public Image imageHolder;
    public Text nameSpace;
    public Text dialogueText;

    public bool itemAquired = false;

    public GameOver gameOverScript;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            dialogueBubble.SetActive(true);
            imageHolder.sprite = quest.beastie;
            nameSpace.text = quest.beastieName;

            if (quest.isActive == false && quest.isComplete == false)
            {
                dialogueText.text = quest.response1;
                acceptButton.SetActive(true);
            }
            else if (quest.isActive == true)
            {
                dialogueText.text = quest.response2;
            }
            else if (quest.isActive == false && quest.isComplete == true && itemAquired == false)
            {
                dialogueText.text = quest.response3;
                itemAquired = true;

                if (gameObject.name == "Beastie6")
                    acceptButton.SetActive(true);
            }
            else if (itemAquired == true)
            {
                FinalDialogue();
            }
        }
    }

    public void FinalDialogue()
    {
        dialogueText.text = quest.response4;
        
        if (gameObject.name == "Beastie6")
        {
            StartCoroutine(TheEnd());
        }
    }

    public void TriggerQuest()
    {
        quest.isActive = true;
        acceptButton.SetActive(false);
        if (gameObject.name == "Beastie6" && itemAquired == true)
        {
            // Do not clear
        }
        else
            ClearDialogue();
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            ClearDialogue();
        }
    }
        
    void ClearDialogue()
    {
         dialogueBubble.SetActive(false);
         acceptButton.SetActive(false);
         imageHolder.sprite = null;
         nameSpace.text = null;
         dialogueText.text = null;
    }

    IEnumerator TheEnd()
    {
        yield return new WaitForSeconds(5);
        gameOverScript.GAMEOVER = true;
    }
}
