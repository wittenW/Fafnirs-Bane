using UnityEngine;
using System.Collections;

public class DKControllerScript : MonoBehaviour
{

    public float moveSpeed = 3.0f;
    public float moveDistance = 1.0f;
    bool moving = false;
    Vector2 startPosition = new Vector2(0, 0);
    Vector2 endPosition = new Vector2(0, 0);
    float horizontalChange = 0.0f;
    float verticalChange = 0.0f;
    //bool facingRight = false;

    // Use this for initialization
    void Start()
    {
	    
    }
	
    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalChange = Input.GetAxis("Horizontal");
        verticalChange = Input.GetAxis("Vertical");

        if (moving == false)
        {
            if (horizontalChange != 0)
            {
                startPosition = rigidbody2D.position;
                endPosition = new Vector2(startPosition.x + (moveDistance * (Mathf.Abs(horizontalChange) / horizontalChange)), startPosition.y);
                moving = true;
                rigidbody2D.velocity = new Vector2(moveSpeed * (Mathf.Abs(horizontalChange) / horizontalChange), rigidbody2D.velocity.y);
            } else if (verticalChange != 0)
            {
                startPosition = rigidbody2D.position;
                endPosition = new Vector2(startPosition.x, startPosition.y + (moveDistance * (Mathf.Abs(verticalChange) / verticalChange)));
                moving = true;
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, moveSpeed * (Mathf.Abs(verticalChange) / verticalChange));
            }
        } else if (moving == true)
        {
            if (Vector2.Distance(rigidbody2D.position, startPosition) >= moveDistance)
            {
                rigidbody2D.velocity = new Vector2(0, 0);
                rigidbody2D.position = endPosition;
                moving = false;
            } 

        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("hit the collision box");
        if (col.gameObject.CompareTag("walls"))
        {
            Debug.Log("hit the collision box again");
            rigidbody2D.velocity = new Vector2(0, 0);
            rigidbody2D.position = startPosition;
            moving = false;	
        }
       
    }
}
