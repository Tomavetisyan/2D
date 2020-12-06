using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int InventorySize;
    private int openSlots;
    public int coinAmount = 0;

    public bool PickupItem(GameObject obj){
        Debug.Log("Hello");
        switch(obj.tag){
            case "Coin":
                coinAmount++;
                break;
            default:
                break;
        }
        return true;
    }
}
