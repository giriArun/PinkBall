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
        LeftWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
        LeftWall.size = new Vector2(1f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        //Right Boundary Create
        RightWall.offset = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);
        RightWall.size = new Vector2(1f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
    }

    void PlayerPosition()       // Player fixed position on start
    {
        TFP1.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(40f, 0f, 0f)).x, 0f);
        TFP2.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width - 85f, 0f, 0f)).x, 0f);

        TFSlider.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);
    }

    void FoulPosition()
    {
        foulLeft.localScale = new Vector2(1f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y);
        foulLeft.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x, 0f);

        foulRight.localScale = new Vector2(0.5f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y);
        foulRight.position = new Vector2(camera2D.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x -1f, 0f);

        TFSlider.localScale = new Vector2(0.48f, camera2D.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y / 6f);
    }
}
