using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public GameObject inventoryPanel;
    private bool onOff = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.B))
        {
            OpenClose();
        }
    }

    void OpenClose()
    {
        onOff = !onOff;

        inventoryPanel.SetActive(onOff);
    }
}
