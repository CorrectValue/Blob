using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInGameMenu : MonoBehaviour
{
    //This script is needed to show player the in-game menu
    GameObject menuPanel; // panel we need to show
    // Start is called before the first frame update
    void Start()
    {
        //find the panel
        menuPanel = GameObject.Find("MenuPanel");
        //hide the panel
        menuPanel.SetActive(false);
    }

    public void handle()
    {
        //acts when the button is pressed
        menuPanel.SetActive(true);
    }
}
