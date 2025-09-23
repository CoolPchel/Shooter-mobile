using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int points = 0;

    public Lazer lazer;

    public float shootInterval;
    public float shootTimer;

    public Transform shootPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();

        shootTimer -= Time.deltaTime;

        Shoot();
    }
    
    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition; //Мышка будет на крсоре
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos); //узнать кардинат нажатия
            transform.position = realPos; //это тоже
        }
    }
    public void Shoot()
    {
        if (shootTimer <= 0)
        {
            Instantiate(lazer, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;
        }
    }
}
