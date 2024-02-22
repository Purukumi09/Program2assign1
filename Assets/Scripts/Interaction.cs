using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Interaction : MonoBehaviour
{

    public Tigerpig tig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D collider)
    {
        if (Input.GetKey(KeyCode.E))
        {
            tig.Noise();
        }
    }
}
