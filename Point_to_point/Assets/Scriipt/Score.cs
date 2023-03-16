using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public float witr = 3.0f;
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        

    }

    void Update()
    {


        if (hits >= 5)
        {
            if (Time.time > witr)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}

