using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerScript player = collision.GetComponent<PlayerScript>();
            player.points++;
            GameObject effet = Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(effet, 5);
            Destroy(this.gameObject);
        }
    }
}
