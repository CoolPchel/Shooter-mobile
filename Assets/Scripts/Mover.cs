using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 2f;
    public float ditinet = 5f; 

    void Start()
    {
        Destroy(gameObject, ditinet); //обьект уничтожеться указаном времени
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.down * (speed + ControlerObjact.gameSpeed) * Time.deltaTime; // Плавное падение обьекта
    }
}
