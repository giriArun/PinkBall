using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public KeyCode moveUp;
    public KeyCode moveDown;

    public Rigidbody2D RB2D;

    float Speed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // KeyBoard Input
		if (Input.GetKey(moveUp))
        {
            RB2D.velocity = new Vector2(0, Speed);
        }
        else if (Input.GetKey(moveDown))
        {
            RB2D.velocity = new Vector2(0, -Speed);
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved && (OptionMenu.DropValue == 2 || OptionMenu.DropValue == 3))
        {
            Vector2 TouchDetailPosition = Input.GetTouch(0).deltaPosition;
            RB2D.velocity = new Vector2(0, TouchDetailPosition.y);
        }
        else
        {
            RB2D.velocity = new Vector2(0, 0);
        }

        // Touch Input
        /*if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 TouchDetailPosition = Input.GetTouch(0).deltaPosition;
            RB2D.velocity = new Vector2(0, TouchDetailPosition.y);
        }
        else
        {
            RB2D.velocity = new Vector2(0, 0);
        }*/
	}
}
