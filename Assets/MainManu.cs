using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame()
    {
        if (OptionMenu.DropValue == 0)
        {

        }
        else if (OptionMenu.DropValue == 1)
        {
            SceneManager.LoadScene("TwoPlayer");
        }
        else if (OptionMenu.DropValue == 2)
        {

        }
        else
        {

        }
            //SceneManager.LoadScene("TwoPlayer");
            //float number = FindObjectOfType<OptionMenu>().num();
            Debug.Log(OptionMenu.DropValue);
        
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }

}
