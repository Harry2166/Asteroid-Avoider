using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Setup(){
        gameObject.SetActive(true);
    }

    public void RestartButton(){
        SceneManager.LoadScene("stage");
        Time.timeScale = 1f;
    }

    public void ExitButton(){
        Debug.Log("QUIT GAME!");
        Application.Quit();
    }

}
