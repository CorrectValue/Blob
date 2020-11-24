using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : MonoBehaviour
{

    public float mass = 1.0f;
    public float size = 1.0f;
    public string name = "Blobbie";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeMass(float value)
    {
        //changes player's mass by value 
        mass += value;
        size += value * 0.1f;
        transform.localScale = new Vector3(size, size, size);
    }

    public float GetMass()
    {
        //returns current mass value
        return mass;
    }

    public string GetName()
    {
        //returns blob's name
        return name;
    }
}
