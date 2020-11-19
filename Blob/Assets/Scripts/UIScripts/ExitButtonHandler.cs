using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonHandler : MonoBehaviour
{
    //This script is needed to be able to close the game.

    private GameObject ConfPanel;

    // Start is called before the first frame update
    void Start()
    {
        //get reference to confirmation panel
        ConfPanel = GameObject.Find("ExitConfirmationPanel");
        //set it inactive
        ConfPanel.gameObject.SetActive(false);
        Debug.Log(ConfPanel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void handle()
    {
        //acts when the button is pressed
        //show exit confirmation panel
        ConfPanel.gameObject.SetActive(true);
    }

}
