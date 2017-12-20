using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneHit : MonoBehaviour {

    private int timesHit = 0;
    private LevelManager levelManager;
    private BrickTracker brickTracker;
    public Sprite[] hitSprites;
    public ScoreTracker scoreTracker;

    private void Start()
    {
        this.levelManager = GameObject.FindObjectOfType<LevelManager>();
        this.brickTracker = GameObject.FindObjectOfType<BrickTracker>();
        this.brickTracker.AddBrick();
        this.scoreTracker = ScoreTracker.getInstance();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        timesHit++;
        this.Destruct();
    }

    private void Update()
    {
        if(scoreTracker == null)
        {
            this.scoreTracker = ScoreTracker.getInstance();
        }
    }


    private void Destruct()
    {
        if (timesHit >= hitSprites.Length + 1)
        {
            Destroy(gameObject);
            this.brickTracker.DestroyBrick();
            scoreTracker.updateScore(hitSprites.Length + 1);

        }
        else
        {
            LoadSprites();
        }
        
    }

    private void LoadSprites()
    {
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[timesHit - 1];
    }
}
