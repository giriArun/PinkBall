using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "ball3d")
        {
            string WallName = transform.name;
            GameManeger.Score(WallName);
            Debug.Log(WallName);
            FindObjectOfType<BallControl>().ResetBall();
        }
    }

}
