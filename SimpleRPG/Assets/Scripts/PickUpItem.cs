﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : Interactable {

    public Item item;

    public override void Interact()
    {
        Debug.Log("Interacting with Item!");

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);
        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
    }
}
