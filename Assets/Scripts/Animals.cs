using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Animals : MonoBehaviour
{
    // Start is called before the first frame update
    public Animals()
    {

    }

    public abstract void Noise();


    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Tigerpig : Animals
{
    public override void Noise()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Oink");
        }
    }
}

public class Fox : Animals
{
    public override void Noise()
    {
        if (Input.GetKey(KeyCode.E)) 
        {
            Debug.Log("Nyah");
        }
    }
}


public class Jellyfish : Animals
{
    public override void Noise()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Ooohwooooh");
        }
    }
}


public class Parrot : Animals
{
    public override void Noise()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Hello-o!");
        }
    }
}
