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
            }
            else if (itemAquired == true)
                dialogueText.text = quest.response4;
        }
    }

    public void TriggerQuest()
    {
        quest.isActive = true;
        acceptButton.SetActive(false);
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
}
