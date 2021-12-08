using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    Item item;

    public Image icon;
    public Text itemDescription;
    public GameObject itemDescriptionPanel;

    public void Start()
    {
        itemDescriptionPanel.SetActive(false);
    }

    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
    }

    public void ItemName()
    {
        StartCoroutine(PauseText());
        itemDescriptionPanel.SetActive(true);

        itemDescription.text = "THAT'S A " + item.name + ". DUH.";

        Debug.Log("That's a " + item.name + ". Duh.");
    }

    IEnumerator PauseText()
    {
        yield return new WaitForSeconds(3);

        itemDescription.text = " ";
        itemDescriptionPanel.SetActive(false);
    }
}
