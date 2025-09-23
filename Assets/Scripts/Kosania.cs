using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kosania : MonoBehaviour
{
    public GameObject explosionPlayer;
    private Transform asterT;
    private float rand;
    

    private void Start()
    {
        asterT = GetComponent<Transform>();
        Scale();
        Rotation();
    }
    
    private void Scale()
    {
        rand = Random.Range(0.3f, 0.7f);
        asterT.localScale = new Vector2(rand,rand);
    }
    private void Rotation()
    {
        rand = Random.Range(0, 180);
        asterT.localEulerAngles = new Vector3(0,0,rand);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerScript player = collision.GetComponent<PlayerScript>();
            GameObject effect = Instantiate(explosionPlayer, transform.position, transform.rotation);
            Destroy(explosionPlayer, 5);
            Destroy(collision.gameObject);
        }
        
    }
}
