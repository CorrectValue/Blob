using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{

    //This script is needed to store information about a single tile in order to place them using map generator
    public int tileType; //a type of a tile: for now there will be grass, concrete and water tiles

    public Texture grass;       //grass texture is 0
    public Texture concrete;    //concrete texture is 1
    public Texture water;       //water texture is 2

    Renderer rnd;               //Renderer component

    public Vector3 objectSize;

    // Start is called before the first frame update
    void OnEnable()
    {
        //get Renderer
        rnd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeMaterial(int type)
    {
        //changes material of a tile when its type changed
        //set texture
        Debug.Log(rnd);
        switch(type)
        {
            case 0:
                rnd.material.SetTexture("_MainTex", grass);
                break;
            case 1:
                rnd.material.SetTexture("_MainTex", concrete);
                break;
            case 2:
                rnd.material.SetTexture("_MainTex", water);
                break;
            default:
                break;
        }
    }

    public void SetType(int type)
    {
        //sets type of a tile
        tileType = type;
        //change mat
        ChangeMaterial(type);
    }

    public Vector3 GetSize()
    {
        //return size of an object
        Mesh mesh = GetComponent<MeshFilter>().sharedMesh;
        Bounds bounds = mesh.bounds;
        return Vector3.Scale(transform.localScale, mesh.bounds.size); 
    }
}
