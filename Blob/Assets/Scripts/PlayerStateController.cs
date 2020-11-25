using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : MonoBehaviour
{

    public float mass = 1.0f;
    public float size = 1.0f;
    public string name = "Blobbie";
    public int level;
    private int experience;
    private float hungerRate = 0.1f; //rate at which blob loses its mass 

    // Start is called before the first frame update
    void Start()
    {
        //at the beginning, everyone's level equals 1
        level = 1;
        experience = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //blob slowly loses mass
        changeMass(-Time.deltaTime * hungerRate);
    }

    public void consume(float value)
    {
        //consumes an object
        changeMass(value);
        //get experience from consumed object
        gainExp((int)(value * 10));
    }

    void changeMass(float value)
    {
        //changes player's mass by value 
        mass += value;
        size += value * 0.1f;
        changeSize();
    }

    void changeSize()
    {
        //changes blob size respectively to its mass
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

    void gainExp(int value)
    {
        //gives some experience towards new level
        experience += value;
    }

    public int GetExp()
    {
        //returns current experience value
        return experience;
    }

    public int GetLevel()
    {
        //returns current level
        return level;
    }

    void levelUp()
    {
        //increases player's level
        level++;
    }
}
