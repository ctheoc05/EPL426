using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionDetect : Monobehaviour

{
	[SerializeField] GameObject thePlayer;
	void onTriggerEnter(Collider other)
	{
		thePlayer.GetComponent<PlayerMovements>().enabled = false;
	}
}