using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerObjact : MonoBehaviour
{
    public static float gameSpeed;

    [Range(0, 10)]

    public float gameSpeedRegulator;
    public float speedRate = 0.5f;
    public float gameSpeedMax = 5;

    void Update()
    {
        if (gameSpeedRegulator <= gameSpeedMax)
        {
            gameSpeedRegulator += speedRate * Time.deltaTime;
        }
        gameSpeed = gameSpeedRegulator;
    }
}
