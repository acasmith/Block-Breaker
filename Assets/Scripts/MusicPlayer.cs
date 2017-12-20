using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

	// Use this for initialization
	void Start () {
        if(MusicPlayer.instance == null)
        {
            MusicPlayer.instance = this;
            GameObject.DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name.Equals("Lose Screen"))
        {
            SceneManager.sceneLoaded -= OnLevelLoaded;
            Destroy(gameObject);
        }
    }
}
