using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour {

    static int PlayerScore_1 = 0;
    static int PlayerScore_2 = 0;

    public GUISkin TheSkin;

    public GUISkin PlayPause;
    public Texture PlayTexture;
    public Texture PauseTexture;
    public Texture StopTexture;

    public Camera Camera2D;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void Score(string WallName)
    {
        if (WallName == "LeftWall")
        {
            PlayerScore_1 += 1;
        }
        else
        {
            PlayerScore_2 += 1;
        }
    }
    bool ShowHide = true;
    private void OnGUI()
    {
        GUI.skin = TheSkin;
        GUI.Label(new Rect(Screen.width / 2 - 100 - 15, 15, 100, 100), "" + PlayerScore_2);
        GUI.Label(new Rect(Screen.width / 2 + 100 - 15, 15, 100, 100), "" + PlayerScore_1);

        if (ShowHide)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 121 / 2, 20, 121, 53), "RESET"))
            {
                PlayerScore_1 = 0;
                PlayerScore_2 = 0;
            
                FindObjectOfType<BallControl>().ResetBall();

                FindObjectOfType<GameSetup>().PlayerPosition();
            }

            GUI.skin = PlayPause;

            if (GUI.Button(new Rect(Screen.width / 2 - 25, Screen.height - 50, 40, 40), PauseTexture))
            {
                ShowHide = false;
                Time.timeScale = 0;
            }
        }
        else
        {
            GUI.skin = PlayPause;

            if (GUI.Button(new Rect(Screen.width / 2, Screen.height - 50, 40, 40), PlayTexture))
            {
                ShowHide = true;
                Time.timeScale = 1;
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height - 50, 40, 40), StopTexture))
            {
                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
                Time.timeScale = 1;
                PlayerScore_1 = 0;
                PlayerScore_2 = 0;
            }
        }
    }
}
