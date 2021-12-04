using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryPanel;
    private bool onOff = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
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
