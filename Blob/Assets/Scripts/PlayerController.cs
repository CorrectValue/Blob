using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float nominalSpeed = 1.0f, speed;
    private PlayerStateController script;
    private Vector3 jump;
    private float jumpForce;
    public bool isGrounded;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<PlayerStateController>();
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 2.0f, 0f);
        speed = nominalSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //can move 4 different directions
        if(Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey("space") && isGrounded)
        {
            Debug.Log("Jump?");
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetKeyDown("left shift"))
        {
            speed = nominalSpeed * 1.5f;
        }
        if (Input.GetKeyUp("left shift"))
        {
            speed = nominalSpeed;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CollObject")
        {
            //consume an object 
            script.consume(other.gameObject.GetComponent<ObjectStateController>().getMass());
            //destroy collected object            
            Destroy(other.gameObject);
        }
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }

}
