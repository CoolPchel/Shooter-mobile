using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public float speed = 10f;
    public GameObject explosionPlayer;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ice")
        {
            GameObject effect = Instantiate(explosionPlayer, transform.position, transform.rotation);
            Destroy(explosionPlayer, 5);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
