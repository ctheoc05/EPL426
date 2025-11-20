using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionDetect : Monobehaviour

{
	[SerializeField] GameObject thePlayer;
	[SerializeFiled] GameObject playerAnim;
	void onTriggerEnter(Collider other)
	{
		thePlayer.GetComponent<PlayerMovements>().enabled = false;
		playerAnim.GetComponent<Animator>().Play("Stuble Backwards");
	}
}