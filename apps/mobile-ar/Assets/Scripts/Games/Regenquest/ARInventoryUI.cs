using UnityEngine;
using UnityEngine.UI;

public class ARInventoryUI : MonoBehaviour
{
    public GameObject itemTemplate; // Template for new items
    public Transform inventoryContainer; // Container to hold all inventory items

    private void Start()
    {
        // Example items for AR Event 3
        string[] eventItems = { "Item1", "Item2", "Item3" };

        foreach (string itemName in eventItems)
        {
            GameObject newItem = Instantiate(itemTemplate, inventoryContainer);
            newItem.transform.Find("ItemName").GetComponent<Text>().text = itemName;
            // Add any other necessary setup for the item
        }
    }

    public void UpdateInventory(string[] newItems)
    {
        // Clear existing items from the inventory container
        foreach (Transform child in inventoryContainer)
        {
            Destroy(child.gameObject);
        }

        // Add new items to the inventory
        foreach (string itemName in newItems)
        {
            GameObject newItem = Instantiate(itemTemplate, inventoryContainer);
            newItem.transform.Find("ItemName").GetComponent<Text>().text = itemName;
            // Add any other necessary setup for the item
        }
    }
}
