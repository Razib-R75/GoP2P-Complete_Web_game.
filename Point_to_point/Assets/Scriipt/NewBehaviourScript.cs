using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public int hyt = 0;
    public float tim = 4.0f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hyt++;
            GetComponent<MeshRenderer>().material.color = Color.gray;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(hyt >= 1)
        {
            if (Time.time > 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
        
    }
}
