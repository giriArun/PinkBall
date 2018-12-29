using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour {

    static int PlayerScore_1 = 0;
    static int PlayerScore_2 = 0;

    public GUISkin TheSkin;


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

    private void OnGUI()
    {
        GUI.skin = TheSkin;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 15, 22, 100, 100), "" + PlayerScore_2);
        GUI.Label(new Rect(Screen.width / 2 + 150 - 15, 22, 100, 100), "" + PlayerScore_1);
    }
}
