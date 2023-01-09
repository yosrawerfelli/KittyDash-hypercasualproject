using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float limitValue ;
    [SerializeField] public bool canmove = true;
    
    static float t = 0.0f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (canmove == true){
                MovePlayer();
            }
        }
        
    }
    private void MovePlayer()
    {
        t += 0.01f * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 1.0f)
        {
            t = 0.0f;
        }
        //Calculate x position and modify it
        float halfScreen = Screen.width / 2;
        float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
        float fnXpos= Mathf.Lerp(playerTransform.position.x, xPos, t);
        float finalXPos = Mathf.Clamp(fnXpos *limitValue, -limitValue, limitValue);
        playerTransform.localPosition = new Vector3(finalXPos, 0, 0);
    }
}
