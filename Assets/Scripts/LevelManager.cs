using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Application.LoadLevel (name);
        if(name.Equals("Level01") || name.Equals("Level02") || name.Equals("Level03"))
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
	}

	public void QuitRequest(){
		Application.Quit ();
	}

    //Loads win screen when total scenes - 3 is cleared, so assumes only 2 scenes (win and lose screens)
    //follow on from levels in build order.
    public void LoadNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex != SceneManager.sceneCountInBuildSettings - 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Win Screen");
        }
    }
}
