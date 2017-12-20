using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour {

	private static int currentScore = 0;
	private static ScoreTracker self = null;

	// Use this for initialization
	void Start () {
		ScoreTracker.self = this;
		if(SceneManager.GetActiveScene().name == "Level01")
		{
			ScoreTracker.currentScore = 0;
			
		}
		this.GetComponent<Text>().text = "Score: " + ScoreTracker.currentScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static ScoreTracker getInstance()
	{
		return ScoreTracker.self;
	}

	//Responsibility lies with block.
	public void updateScore(int points)
	{
		ScoreTracker.currentScore += points;
		this.GetComponent<Text>().text = "Score: " + ScoreTracker.currentScore;
	}
}
