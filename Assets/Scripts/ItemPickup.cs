using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private void OntriggerEnter2D(Collider2D collision){
        Debug.Log("pickup");
        Inventory manager = collision.GetComponent<Inventory>();
        if(manager){
            manager.PickupItem(gameObject);
            Destroy(gameObject);
            
        }
    }
}
