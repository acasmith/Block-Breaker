using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    private BatInput bat;
    private Vector3 paddleToBallVector;
    private bool started = false;

	// Use this for initialization
	void Start () {
        this.bat = GameObject.FindObjectOfType<BatInput>();
        this.paddleToBallVector = this.transform.position - bat.transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {
        if(!started)
        {
            this.transform.position = bat.transform.position + paddleToBallVector;
            if (Input.GetMouseButtonDown(0))
            {
                this.LaunchBall();
                this.started = true;
            }
        }
        
	}

    private void LaunchBall()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 12);
    }

    private void OnCollisionEnter2D()
    {
        Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
        if(started)
        {
            this.GetComponent<AudioSource>().Play();
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }

    public bool IsStarted()
    {
        return this.started;
    }

    public void SetStarted(bool started)
    {
        this.started = started;
        this.LaunchBall();
    }
}
