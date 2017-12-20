using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatInput : MonoBehaviour {
	public ball ball; 
	private bool autoplay = true;

	// Use this for initialization
	void Start () {
		this.ball = GameObject.FindObjectOfType<ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!this.autoplay)
		{
			this.MoveWithMouse();
		}
		else
		{
			if(!this.ball.IsStarted()) this.ball.SetStarted(true);
			this.MoveWithBall();
		}
	}

	//Player input.
	private void MoveWithMouse()
	{
		float mousePositionInBlocks = Mathf.Clamp((Input.mousePosition.x / Screen.width * 16),0, 14);
        	this.transform.position = new Vector3(mousePositionInBlocks, this.transform.position.y, 0);
	}

	//Automated playtesting
	private void MoveWithBall()
	{
		this.transform.position = new Vector3(this.ball.transform.position.x, this.transform.position.y, 0);
	}
}
