using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    public float WitTime = 5.0f;

    Rigidbody rigidbod;
    MeshRenderer rendere;
    // Start is called before the first frame update
    void Start()
    {
        rigidbod = GetComponent<Rigidbody>();
        rendere = GetComponent<MeshRenderer>();
        rendere.enabled = false;
        rigidbod.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time > WitTime)
        {
            
            rendere.enabled = true;
            rigidbod.useGravity = true;
        } 

    }
}
