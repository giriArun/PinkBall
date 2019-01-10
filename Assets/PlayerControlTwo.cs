using UnityEngine;

public class PlayerControlTwo : MonoBehaviour {

    public Rigidbody2D PlayerL;
    public Rigidbody2D PlayerR;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved && (OptionMenu.DropValue != 2 || OptionMenu.DropValue != 3))
        {
            Vector2 TouchDetailPosition = Input.GetTouch(0).deltaPosition;
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint( Input.GetTouch(0).position);
            
            if (touchPosition.x < -1f)
            {
                PlayerL.velocity = new Vector2(0, TouchDetailPosition.y);
            }
            else if (touchPosition.x > 1f)
            {
                PlayerR.velocity = new Vector2(0, TouchDetailPosition.y);
            }
        }
        else
        {
            PlayerL.velocity = new Vector2(0, 0);
            PlayerR.velocity = new Vector2(0, 0);
        }
    }
}
