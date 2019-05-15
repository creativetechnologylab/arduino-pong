using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JankyPong : MonoBehaviour {

	public bool reset = true;

	public Rigidbody2D ball;

	public int p1Score = 0;
	public int p2Score = 0;

	public Text p1ScoreText;
	public Text p2ScoreText;
    
	// Use this for initialization
	void Start () {
		p1ScoreText.text = p1Score.ToString();
		p2ScoreText.text = p2Score.ToString();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonUp("Submit") && reset)
		{
			ball.velocity = Vector2.zero;
            
			ball.transform.position = new Vector3(0, Random.Range(-5.0f, 5.0f), 0);
			ball.AddForce(Random.insideUnitCircle.normalized * 500.0f);
			reset = false;
		}

	}

    public void UpdateScore(int playerNum)
	{
		if (playerNum == 1)
		{
			p1Score++;
			p1ScoreText.text = p1Score.ToString();
		}
		else
		{
			p2Score++;
			p2ScoreText.text = p2Score.ToString();
            
		}

		reset = true;
   	}
}
