using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStateController : MonoBehaviour
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
    public float getMass()
    {
        return mass;
    }
    public void changeMass(float value)
    {
        //changes mass & size of an object to match its mass
        mass = value;
        transform.localScale = new Vector3(mass, mass, mass);
    }

}
