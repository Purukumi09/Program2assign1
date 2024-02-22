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
