using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
   private HashSet<string> collection = new HashSet<string>();

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Berries"))
        {
            CollectionItem(other.gameObject);

        }
    }

    public void CollectionItem(GameObject obj)
    {
        string itemName = obj.name;

        if (!collection.Contains(itemName))
        {
            if (!collection.Contains(itemName))
            {
                collection.Add(itemName);
                Debug.Log($"Collected: {itemName}");

                Destroy(obj);

            }
            else
            {
                Debug.Log($"Already collected: {itemName}");

            }
        }
    }
    public void DisplayCollectedItems()
    {
        foreach (var item in collection)
        {
            Debug.Log($"Collected Item: {item}");
        }
    }
}
