using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using PathCreation.Examples;

public class energy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bar;
    [SerializeField] private GameObject panel;
    PathFollower PFollower;
    PlayerMovement pmove;

    static public float t = 1.0f;
    void Start()
    {
        PFollower = GetComponent<PathFollower>();
        pmove = GetComponent<PlayerMovement>();
    }
    
    // Update is called once per frame
    void Update()
    {

        t -= (0.01f * Time.deltaTime)*10;
        t = Mathf.Clamp(t,0f,1f);
        bar.GetComponent<Image>().fillAmount = t;
        
        if (t <= 0){
            sleep();
        }

    }
    
    void sleep()
    {
        PFollower.speed = 0;
        pmove.canmove = false;
        panel.SetActive(true);
    }
    public void RestartGame() {
        t= 1.0f;
        PFollower.speed = 5;
        pmove.canmove = true;
        panel.SetActive (false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void doExitGame() {
        Application.Quit();
        Debug.Log("Game is exiting");
 }
}
