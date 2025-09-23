using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UiScript : MonoBehaviour
{
    public GameObject playerB;
    public PlayerScript playerS;
    public TextMeshProUGUI textPoint;
    public GameObject buttons;
    private string TestScene = "SampleScene";

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        textPoint.text = playerS.points.ToString("0");
        if (playerB == null)
        {
            buttons.SetActive(true);
        }
    }
    public void RestartGame() 
    {
        SceneManager.LoadScene(TestScene);
    }
    public void Exit() 
    {
        Application.Quit();
        print("Вали");
    }
    public void StartaGame() 
    {
        SceneManager.LoadScene(TestScene);
    }
}
