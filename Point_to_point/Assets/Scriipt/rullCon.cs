using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rullCon : MonoBehaviour
{
    public void RetryGame()
    {

        GameMonetize.Instance.ShowAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
      

    }

    public void GameManu()
    {
        GameMonetize.Instance.ShowAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
      
    }
}
