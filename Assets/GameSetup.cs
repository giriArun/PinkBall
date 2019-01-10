using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour {

    public Camera camera2D;

    public BoxCollider2D LeftWall;
    public BoxCollider2D RightWall;
    public BoxCollider2D TopWall;
    public BoxCollider2D ButtonWall;

    public Transform TFP1;
    public Transform TFP2;

    public Transform TFSlider;
    public Transform TFSlider2;

    public Transform foulLeft;
    public Transform foulRight;

	// Use this for initialization
	void Start () {

        WallPosition();
        PlayerPosition();
        FoulPosition();
		
	}
	
	// Update is called once per frame
	void Update () {

        WallPosition();
        FoulPosition();
    }

    void WallPosition()     //Hidden Game Boundary Create
    {
        //Top Boundary create
        TopWall.offset = new Vector2(0f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);
        TopWall.size = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        //Button Boundary Create
        ButtonWall.offset = new Vector2(0f, camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
        ButtonWall.size = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width * 2, 0f, 0f)).x, 1f);
        //Left Boundary Create
        LeftWall.size = new Vector2(1f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        //Right Boundary Create
        RightWall.size = new Vector2(1f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        if (OptionMenu.DropValue == 1)
        {
            LeftWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 0f);
            RightWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);
        }
        else if (OptionMenu.DropValue == 2)
        {
            LeftWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 0f);
            RightWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);
        }
        else if (OptionMenu.DropValue == 3)
        {
            LeftWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
            RightWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);
        }
        else
        {
            LeftWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 0f);
            RightWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);
        }
    }

    public void PlayerPosition()       // Player fixed position on start
    {
        if (OptionMenu.DropValue == 1)      //Left and Right Hand
        {
            TFP1.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(85f, 0f, 0f)).x, 0f);
            TFP2.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width - 85f, 0f, 0f)).x, 0f);
            TFSlider.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 0f);
            TFSlider2.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);
        }
        else if (OptionMenu.DropValue == 2)     //Left Hand
        {
            TFP1.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(85f, 0f, 0f)).x, 0f);
            TFP2.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width - 40f, 0f, 0f)).x, 0f);
            TFSlider.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 0f);
            TFSlider2.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 1f, 0f);
        }
        else if (OptionMenu.DropValue == 3)     //Right Hand
        {
            TFP1.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(40f, 0f, 0f)).x, 0f);
            TFP2.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width - 85f, 0f, 0f)).x, 0f);
            TFSlider.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 1f, 0f);
            TFSlider2.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);
        }
        else        //By default condition
        {
            TFP1.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(85f, 0f, 0f)).x, 0f);
            TFP2.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width - 85f, 0f, 0f)).x, 0f);
            TFSlider.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 0.5f, 0f);
            TFSlider2.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);
        }

        TFSlider.localScale = new Vector2(0.48f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y / 6f);
        TFSlider2.localScale = new Vector2(0.48f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y / 6f);
    }

    void FoulPosition()
    {
        if (OptionMenu.DropValue == 1)
        {
            foulLeft.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 1f, 0f);
            foulRight.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 1f, 0f);
        }
        else if (OptionMenu.DropValue == 2)
        {
            foulLeft.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 1f, 0f);
            foulRight.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.01f, 0f);
        }
        else if (OptionMenu.DropValue == 3)
        {
            foulLeft.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x, 0f);
            foulRight.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 1f, 0f);
        }
        else
        {
            foulLeft.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x + 1f, 0f);
            foulRight.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 1f, 0f);
        }

        foulLeft.localScale = new Vector2(1f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y);
        foulRight.localScale = new Vector2(0.5f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y);
    }
}
