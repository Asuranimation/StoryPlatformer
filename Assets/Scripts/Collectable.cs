using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    enum ItemType
    {
        Coin,
        Health,
        Ammo,
        Inventory
    }
    [SerializeField] private ItemType itemType;
    void Start()
    {
        if (itemType == ItemType.Coin)
        {
            Debug.Log("i'm coin");
        }
        else if (itemType == ItemType.Health)
        {
            Debug.Log("i' health");
        }
        else if (itemType == ItemType.Ammo)
        {
            Debug.Log("i' ammo");
        }
        else if (itemType == ItemType.Inventory)
        {
            Debug.Log("i' inventory");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            player.coinsCollected += 1;
            player.UpdateUI();
            Destroy(gameObject);
        }
    }
}
