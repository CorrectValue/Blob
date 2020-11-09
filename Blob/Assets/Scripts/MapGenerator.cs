using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    //This script is needed to perform tile-based map generation

    public GameObject prefab;   //a tile
    private GameObject player;  //player game object to create map around him
    private GameObject parent;  //parent game object for tiles
    public int renderDistance;  //a distance at which tiles emerge

    private Vector3 pos;  //position to place tile
    private Quaternion rot;  //rotation to place tile

    // Start is called before the first frame update
    void Start()
    {
        //find player game object
        player = GameObject.FindWithTag("Player");
        //find parent game object
        parent = GameObject.Find("Map");

        //create random map starting from the 0 point
        for(int i = 0; i < renderDistance * renderDistance; i++)
        {
            //place some tile
            var obj = Instantiate(prefab, GeneratePosition(i, renderDistance, prefab.GetComponent<TileController>().GetSize()), rot);
            //set tile properties
            var scr = obj.GetComponent<TileController>();
            //set tile type
            scr.SetType(Random.Range(0, 3)); //correct and set total amount of tile types when it will be ready
            //set tag for object
            obj.gameObject.tag = "Tile";
            //put object into parent game object
            obj.transform.parent = parent.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //place new tiles as player walks further
    }

    Vector3 GeneratePosition(int index, int rDistance, Vector3 size)
    {
        //generates position for a tile
        float newx, newy, newz;
        newy = 0.0f;
        //from index and rDistance we can get row and column to spawn a tile
        int col = index % rDistance - rDistance / 2;
        int row = index / rDistance - rDistance / 2;
        newx = col * size.x;
        newz = row * size.z;
        return new Vector3(newx, newy, newz);
    }
}
