using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickTracker : MonoBehaviour {

    public int totalBricks = 0;
    private LevelManager levelmanager;

	// Use this for initialization
	void Start () {
        this.levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddBrick()
    {
        this.totalBricks++;
    }


    public void DestroyBrick()
    {
        this.totalBricks--;
        this.WinCondition();
    }

    public void WinCondition()
    {
        if(this.totalBricks <= 0)
        {
            this.levelmanager.LoadNextLevel();
        }
    }
}
