using UnityEngine;

public class SideWall : MonoBehaviour {

    public AudioSource audioPlay;

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
            audioPlay.Play();
            FindObjectOfType<BallControl>().ResetBall();
        }
    }

}
