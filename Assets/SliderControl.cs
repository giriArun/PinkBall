using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderControl : MonoBehaviour {

    public KeyCode moveUp;
    public KeyCode moveDown;

    public Rigidbody2D RB2D;
    public Rigidbody2D slider;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // KeyBoard Input
        if (Input.GetKey(moveUp))
        {
            slider.position = new Vector2(slider.position.x, RB2D.position.y);
        }
        else if (Input.GetKey(moveDown))
        {
            slider.position = new Vector2(slider.position.x, RB2D.position.y);
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 TouchDetailPosition = Input.GetTouch(0).deltaPosition;
            slider.position = new Vector2(slider.position.x, TouchDetailPosition.y);
        }
        else
        {
            //RB2D.velocity = new Vector2(0, 0);
        }
    }
}
