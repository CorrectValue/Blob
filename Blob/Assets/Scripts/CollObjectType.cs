using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollObjectType : MonoBehaviour
{

    //This script is needed to define properties of a specific object
    //there are properties: mass, material, bonus

    private ObjectStateController scr; //script that handles all of the properties
    public int type; //type of the object itself


    // Start is called before the first frame update
    void Start()
    {
        //get reference to this script
        scr = gameObject.GetComponent<ObjectStateController>();
        //get renderer component of an object
        var renderer = gameObject.GetComponent<Renderer>();

        //change object color based on its type
        switch (type)
        {
            case 0:
                //a regular object
                renderer.material.SetColor("_Color", Color.yellow);
                break;
            case 1:
                //a speed-up object
                renderer.material.SetColor("_Color", Color.cyan);
                break;
        }
        Debug.Log("Color has been set");

    }
    public void SetType(int value)
    {
        //sets object type
        type = value;
    }
}
