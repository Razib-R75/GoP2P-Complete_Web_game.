using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winn : MonoBehaviour
{
    public void ReGame()
    {

        GameMonetize.Instance.ShowAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        
    }

    public void GameManuQ()
    {
        GameMonetize.Instance.ShowAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        
    }
}
