using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    public Rigidbody2D RBBall;
    public AudioSource audioPlay;

	// Use this for initialization
	void Start () {

        Invoke("GoBall", 3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GoBall()
    {
        float num = Random.Range(0, 10);

        if (num < 5)
        {
            RBBall.AddForce( new Vector2(20, 1));
        }
        else
        {
            RBBall.AddForce(new Vector2(-20, -1));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            float valY = RBBall.velocity.y;

            valY = (valY / 2) + (collision.relativeVelocity.y / 3);

            if (valY <= 1.5f && valY > 0f)
            {
                valY = 1.5f;
            }

            if (valY >= -1.5f && valY < 0f)
            {
                valY = -1.5f;
            }

            if (RBBall.velocity.x > 20)
            {
                RBBall.velocity = new Vector2(20, valY);
            }
            else if (RBBall.velocity.x > 13f && RBBall.velocity.x < 21)
            {
                RBBall.velocity = new Vector2(RBBall.velocity.x * 1.0001f, valY);
            }
            else
            {
                RBBall.velocity = new Vector2(RBBall.velocity.x * 1.1f, valY);
            }

            audioPlay.pitch = Random.Range(0.8f, 1.2f);
            audioPlay.Play();
        }
    }

    public void ResetBall()
    {
        RBBall.velocity = new Vector2(0, 0);
        RBBall.position = new Vector3(0, 0, 0);
        RBBall.velocity = new Vector2(0, 0);

        FindObjectOfType<GameSetup>().PlayerPosition();

        Invoke("GoBall", 1.5f);
    }
}
