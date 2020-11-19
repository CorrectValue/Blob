using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitConfHandler : MonoBehaviour
{
    //This script handles exit confirmation and closes the game
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void handle()
    {
        //acts when the button is pressed
        Application.Quit();
    }
}
