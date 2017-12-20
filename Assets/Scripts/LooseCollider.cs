using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseCollider : MonoBehaviour {

    private LevelManager levelManager;

    private void Start()
    {
        this.levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        levelManager.LoadLevel("Lose Screen");
    }


}
