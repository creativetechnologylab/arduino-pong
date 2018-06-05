using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour {

	public string joystickAxis;

	public Transform topLimit;
	public Transform bottomLimit;

	// Use this for initialization
	void Start () {
		SetPosFromInput();
	}
	
	// Update is called once per frame
	void Update () {

		SetPosFromInput();
		//Debug.Log(Input.GetAxis(joystickAxis));
		
	}

	void SetPosFromInput()
	{
		Vector3 newPos = transform.position;

        newPos.y = MathJunk.map(Input.GetAxis(joystickAxis), -1.0f, 1.0f, bottomLimit.position.y, topLimit.position.y);

        transform.position = newPos;
	}
}
