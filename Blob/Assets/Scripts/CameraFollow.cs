using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //This script is needed to make the camera follow player
    //set player game object
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //find player game object
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //update own position to follow player
        float newx = player.transform.position.x;
        float newy = transform.position.y;
        float newz = player.transform.position.z;
        transform.position = new Vector3(newx, newy, newz);
    }
}
