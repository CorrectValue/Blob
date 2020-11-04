using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : MonoBehaviour
{

    public float mass = 1.0f;

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
        transform.localScale = new Vector3(mass, mass, mass);
    }

    public float GetMass()
    {
        //returns current mass value
        return mass;
    }

}
