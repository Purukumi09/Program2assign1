using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Interaction : MonoBehaviour, IInteractable
{

    public Tigerpig tig;
    public Fox fox;
    public Parrot par;
    public Jellyfish jelly;

    public void Interact()
    {
        if (tig != null)
        {
            tig.Noise();
        }

        if (fox != null)
        {
            fox.Noise();
        }

        if (jelly != null)
        {
            jelly.Noise();
        }

        if (par != null)
        {
            par.Noise();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void OnTriggerStay2D(Collider2D collider)
    //{
       //if (Input.GetKey(KeyCode.E))
       //{
           //tig.Noise();
       //}
    //}

}
