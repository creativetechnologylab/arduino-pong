using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScore : MonoBehaviour {
    
	public JankyPong jankyPong;
	public int scoringPlayer;

    
	void OnTriggerEnter2D(Collider2D other)
	{
		jankyPong.UpdateScore(scoringPlayer);

	}
}
