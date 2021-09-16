using UnityEngine;

public class Paddle : MonoBehaviour
{
    //TODO
    // Move paddle left and right using keyboard keys, mapping is up to you
    // Paddle should be able to launch the ball upon space bar being pressed
    // A launched ball will then bounce around, changing its direction upon any collision

    //Variables
    [SerializeField]
    private Ball ballPrefab;
    private float speed = 6.0f;


    void Awake()
    {
        Instantiate(ballPrefab, GameObject.Find("BallLauncher").transform.position, Quaternion.identity);
    }

    void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }

        //Clamping
        var xPosition = Mathf.Clamp(transform.position.x, -6.4f, 6.4f);
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);

    }

    


}
