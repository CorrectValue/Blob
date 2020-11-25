using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerInfo : MonoBehaviour
{
    //This script takes player info from the player game object and puts it in a box of the UI
    GameObject player; //a reference to the player game object
    GameObject parent; //parent game object (txt box)

    // Start is called before the first frame update
    void Start()
    {
        //get reference to the player go
        player = GameObject.FindWithTag("Player");
        parent = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //get stats script from the player
        var scr = player.GetComponent<PlayerStateController>();

        //set stats into text
        parent.GetComponent<UnityEngine.UI.Text>().text = "Name: " + scr.GetName() + "\n" + "Mass: " + scr.GetMass() + "\n" + "Level: " + scr.GetLevel()
            + " (" + scr.GetExp() + " exp)";
    }
}
