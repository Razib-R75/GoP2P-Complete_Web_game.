using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] float Xangle = 0;
    [SerializeField] float Yangle = 0;
    [SerializeField] float Zangle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Xangle, Yangle, Zangle);
    }
}
