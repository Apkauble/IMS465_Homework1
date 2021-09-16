using UnityEngine;

public class OutOfBounds : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle
        // Look to see if the colliding object is our ball
        if (collision.CompareTag("Ball"))
        {
            // if it is the ball then destroy it, thus removing it from the scene
            Instantiate(collision.gameObject, GameObject.Find("BallLauncher").transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }


}

