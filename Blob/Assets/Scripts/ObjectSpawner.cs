using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    //This script manages spawning objects and giving them random properties

    public GameObject prefab;           //prefab that we need to spawn
    private float nextSpawnTime;        //when the next object will be spawned
    public float spawnDelay;            //a pause between two consequent spawns
    private int objectsCount;           //a total number of objects currently present in the scene
    public int threshold;               //max amount of objects present in the scene / near player

    private GameObject parent; //parent object for food to clean up the scene
    private GameObject player; //player object is necessary to know where to spawn new objects

    private Vector3 pos;  //position to spawn to
    private Quaternion rot;  //rotation to spawn

    // Start is called before the first frame update
    void Start()
    {
        //get parent game object for objects to spawn
        parent = GameObject.Find("Objects");
        //get player game object
        player = GameObject.FindWithTag("Player");
        //initialize threshold
        threshold = 5;
        //spawn the needed amount of objects
        for (int i = 0; i < threshold; i++)
        {
            //spawn one object and give it some properties
            Spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //recalculate number of objects present in the scene
        objectsCount = GameObject.FindGameObjectsWithTag("CollObject").Length;
        //spawn new objects if needed
        if (shouldSpawn())
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        //spawns one object somewhere near player
        
        //need to define a law to distribute objects

        //instantiate an object
        var obj = Instantiate(prefab, GeneratePosition(), rot);

        //randomize object properties
        //get script component from prefab
        var scr = obj.GetComponent<ObjectStateController>();

        //randomize mass 
        //get player mass and spawn objects that are 20%-90% of player mass
        float playerMass = player.GetComponent<PlayerStateController>().GetMass();
        float objectMass = Random.Range(0.2f * playerMass, 0.9f * playerMass);
        //set object mass
        scr.changeMass(objectMass);

        //randomize type
        var scr2 = obj.GetComponent<CollObjectType>();
        //various types of food give different bonuses or penalties
        //0 - regular food
        //1 - speed-up food
        //. . .
        scr2.SetType(Random.Range(0, 2));

        //set object tag
        obj.gameObject.tag = "CollObject";
        //put newly spawned object into parent object
        obj.transform.parent = parent.transform;
    }

    private Vector3 GeneratePosition()
    {
        //generates position to spawn object to
        //get current player position
        Vector3 playerPos = player.transform.position;
        //spawn somewhere near the player but not too close
        float newx, newy, newz; //new coordinates to spawn
        newy = playerPos.y;
        newx = playerPos.x + Random.Range(-10, 10);
        newz = playerPos.z + Random.Range(-10, 10);
        return new Vector3(newx, newy, newz);
    }

    private bool shouldSpawn()
    {
        //sets to true is current number of objects is less than threshold
        if(objectsCount < threshold)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
