using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject beachBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Used to activate or deactivate the BeachBall
        if (Input.GetKeyDown(KeyCode.Q))
        {
            beachBall.SetActive(!beachBall.activeInHierarchy);
        }
        //Used to quit the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
