using UnityEngine;
using System.Collections;
using System.Collections.Generic;   

public class PlayerMovements : MonoBehaviour    
{
    float playerSpeed = 2;
    void Update()    
    {    
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime, Space.World);    
    }

}
