using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heath : MonoBehaviour
{
    [SerializeField] private GameObject player;
    energy energy;
    void Start(){
        energy = player.GetComponent<energy>();
    }
    
    void OnTriggerEnter (Collider targetObj) {
        if(targetObj.gameObject.tag == "Health")
        {
            energy.t += 0.3f;
            Destroy(targetObj.gameObject);
        }
}
}
