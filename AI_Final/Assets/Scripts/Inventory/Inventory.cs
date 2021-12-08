using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public InventoryUI inventoryScript;

    #region Singleton
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 8;

    public List<Item> items = new List<Item>();

    public void Add (Item item)
    {
        if(items.Count >= space)
        {
            Debug.Log("Not enough room in inventory.");
            return;
        }
        
        items.Add(item);

        if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
    
    public void Remove(Item item)
    {
        items.Remove(item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }

    public void RemoveAllItems()
    {
        items.Clear();
        inventoryScript.ClearAllSlots();
    }
}
