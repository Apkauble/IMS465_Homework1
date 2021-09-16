using UnityEngine;

using System.Collections.Generic;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody = null;

    public bool isStuck = true;
    private GameObject paddle = null;
    private static float speed = 15.0f;
    private Vector3 currentDirection = Vector3.zero;

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one
    //Ball should only move once its been launched

    void Start()
    {
        paddle = GameObject.Find("BallLauncher");
        currentDirection = Vector3.up * Time.deltaTime * speed;
        isStuck = true;
    }

    void FixedUpdate()
    {
        if (isStuck)
        {
            transform.position = paddle.transform.position;
        }
        else
        {
            var newDelta = currentDirection * Time.deltaTime * speed;
            rigidBody.MovePosition(transform.position + newDelta);
        }
    }

    void Update()
    {
        //Launching the ball
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStuck = false;
        }
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);

        if(collision.gameObject.name == "Piece(Clone)")
        {
            Destroy(collision.gameObject);
        }
    }

    
    /*
    
     //Collision check
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Collision!");
        currentDirection = Vector3.Reflect(currentDirection, Vector2.up);
        // Look to see if the colliding object is a piece
        if (collider.CompareTag("Piece"))
        {
            // if it is a piece then destroy it, thus removing it from the scene
            Destroy(collider.gameObject);
        }

    }
    
    */


}
