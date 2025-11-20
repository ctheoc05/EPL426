using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    void OnTriggerEnter(Collider other)
    {
        thePlayer.GetComponent<PlayerMovements>().enabled = false;
    }

}
