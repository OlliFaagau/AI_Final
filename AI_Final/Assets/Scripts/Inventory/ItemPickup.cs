using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
            PickUp();
    }
    
    void PickUp()
    {
        Debug.Log("Picked up a " + item.name);
        Inventory.instance.Add(item);
        Destroy(gameObject);
    }
}
