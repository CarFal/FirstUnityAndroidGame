using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    Rigidbody2D rigid;
    public float moveSpeed;

    void Awake() {
        rigid = GetComponent<Rigidbody2D>();
        //this instantiates the rigidbody from the paddle
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        TouchMove();
    }

    // Update is called once per frame
    void Update()
    {
        //TouchMove();
    }

    void TouchMove() {
        if (Input.GetMouseButton(0))
        {//This function is what detects if the screen was clicked
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //This variable retrieves the location where the touch happens to identify which side the paddle will move towards.
            if (touchPos.x < 0)
            {
                //Less than 0 then it moves to the left
                rigid.velocity = Vector2.left * moveSpeed;
            }
            else
            {
                //More than 0 moves to the right 
                rigid.velocity = Vector2.right * moveSpeed;
            }
        }
        else
        {
            //If nothing is being touched on then the velocity becomes zero
            rigid.velocity = Vector2.zero;
        }
    }
}
