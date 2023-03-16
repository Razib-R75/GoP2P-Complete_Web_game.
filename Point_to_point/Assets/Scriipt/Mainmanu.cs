using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmanu : MonoBehaviour
{
   public void PlayGame()
    {
        GameMonetize.Instance.ShowAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   public void ENdGame()
    {
        GameMonetize.Instance.ShowAd();
        Application.Quit();
    }
}
