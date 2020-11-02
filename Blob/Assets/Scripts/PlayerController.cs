using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;
    private PlayerStateController script;
    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<PlayerStateController>();
    }

    // Update is called once per frame
    void Update()
    {
        //can move 4 different directions
        if(Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            Debug.Log("Eaten " + other.gameObject);
            //increase mass and size
            script.changeMass(other.gameObject.GetComponent<ObjectStateController>().getMass());
            //destroy collected object            
            Destroy(other.gameObject);
        }
    }
}
