using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public void nextGame() {
        SceneManager.LoadScene("level1");
    }
    public void doExitGame() {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
