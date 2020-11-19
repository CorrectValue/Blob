using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonHandler : MonoBehaviour
{
    //This script allows setting initial options and then proceeding to the game itself

    private GameObject ConfPanel; //a confirmation panel shall be displayed upon pressing the button

    // Start is called before the first frame update
    void Start()
    {
        //get reference to confirmation panel
        ConfPanel = GameObject.Find("StartConfirmationPanel");
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
        //show start confirmation panel
        ConfPanel.gameObject.SetActive(true);
    }
}
