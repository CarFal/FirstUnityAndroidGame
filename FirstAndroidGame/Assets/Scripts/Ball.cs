using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rbBall;
    public float BounceForce;
    bool gameStarted;

    private void Awake()
    {
        rbBall = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) {
            if(gameStarted == false)
            {
                StartBounce();
                gameStarted = true;
                GameManager.instance.GameStart();
            }
            
        }
    }

    void StartBounce() {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);
        //this segment gives the ball a random direction upon bouncing.
        //The random value is for the x axis, while the 1 is going to be for the y axis as it.

        rbBall.AddForce(randomDirection * BounceForce, ForceMode2D.Impulse);
        //It will add the force that will give the ball a random direction upon bouncing
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "FallCheck")
        {
            GameManager.instance.Restart();
        }
        else if (collision.gameObject.tag == "Paddle") {
            GameManager.instance.ScoreUp();
        }
    }
}
