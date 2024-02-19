using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartOfComputer : OnRaycast
{
    public Item item;

    public override void OnInteract () {
        FindObjectOfType<Raycast>().Pickup(transform);
    }
}