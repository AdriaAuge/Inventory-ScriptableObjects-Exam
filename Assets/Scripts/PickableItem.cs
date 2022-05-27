using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public Swords sword;
    public Guns gun;

    private void OnTriggerEnter2D(Collider2D item)
    {
        if(item.gameObject.tag == "Player" && this.gameObject.tag == "Swords")
        {
            Inventory.Instance.AddSwords(sword);
            Debug.Log("New Sword");
            Destroy(gameObject);
        }
        else if(item.gameObject.tag == "Player" && this.gameObject.tag == "Guns")
        {
            Inventory.Instance.AddGuns(gun);
            Debug.Log("New Gun");
            Destroy(gameObject);
        }
    }
}
