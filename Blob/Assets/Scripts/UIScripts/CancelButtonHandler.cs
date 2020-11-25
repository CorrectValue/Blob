using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButtonHandler : MonoBehaviour
{
    //This script handles all "cancel" buttons in the game

    private GameObject parent; //parent is a panel that hides upon clicking this button

    // Start is called before the first frame update
    void Start()
    {
        //find parent game object
        parent = gameObject.transform.parent.gameObject;
    }

    public void handle()
    {
        //acts when the button is pressed
        parent.gameObject.SetActive(false);
    }
}
