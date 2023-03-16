using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_co : MonoBehaviour
{

    public float xval;
    public float Zval;
    [SerializeField] float MoveSpeeed = 10f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        playerMove();

    }

    void playerMove()
    {
        xval = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeeed;
        Zval = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeeed;

        transform.Translate(xval, 0, Zval);
    }

    
        
}
