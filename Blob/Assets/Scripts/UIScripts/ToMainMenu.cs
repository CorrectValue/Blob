using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMainMenu : MonoBehaviour
{
    //This script is needed to hide and show in-game menu
    GameObject confPanel;
    // Start is called before the first frame update
    void Start()
    {
        //find panel
        confPanel = GameObject.Find("ToMainMenuConfirmationPanel");
        //set it inactive first
        confPanel.SetActive(false);
    }

    public void handle()
    {
        //acts when the button is pressed
        confPanel.SetActive(true);
    }
}
