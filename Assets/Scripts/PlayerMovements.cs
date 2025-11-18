using UnityEngine;
using System.Collections;
using System.Collections.Generic;   

public class PlayerMovements : MonoBehaviour    
{
    public float playerSpeed = 2;
    public float horizontalSpeed = 3;
    public float rightLimitt = 5.5f;
    public float leftLimitt = -5.5f;


    void Update()    
    {    
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime, Space.World); 
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))   
        {    
            if(this.gameObject.transform.position.x > leftLimitt)    
            {
                transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime);

            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {    
            if(this.gameObject.transform.position.x < rightLimitt)  
                transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
        }
    }

}
