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
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            switch (itemType)
            {
                case ItemType.Coin:
                    player.coinsCollected += 1;
                    break;
                case ItemType.Health:
                    if (player.health < 100f)
                    {
                        player.health += 20;
                    }
                    break;
            }
            
            player.UpdateUI();
            Destroy(gameObject);
        }
    }
}
