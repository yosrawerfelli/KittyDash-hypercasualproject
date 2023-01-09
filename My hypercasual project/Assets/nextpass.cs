using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextpass : MonoBehaviour
{
    [SerializeField] private GameObject panel2;
    [SerializeField] private GameObject player;
    energy energy;
    void Start(){
        energy = player.GetComponent<energy>();
    }
    void OnTriggerEnter (Collider targetObj) {
        energy.t =1.0f;
        if(targetObj.gameObject.tag == "Player")
        {
            panel2.SetActive (true);
        }
}
    public void nextlevel() {
        SceneManager.LoadScene("level2");
        energy.t =1.0f;
    }
    public void doExitGame() {
        Application.Quit();
        Debug.Log("Game is exiting");
 }
}
