using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{

    [SerializeField] [Range(0, 15)] int snakeSpeed;
    float delta;
    float xDir;
    float yDir;
    string direction;

    // Start is called before the first frame update
    void Start()
    {
        xDir = 0;
        yDir = transform.position.y + delta;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        // Determine Move Speed
        delta = Time.deltaTime * snakeSpeed;

        // Direction Listener
        if (Input.GetKeyDown("left"))
        {
            direction = "left";
        }
        else if (Input.GetKeyDown("right"))
        {
            direction = "right";
        }
        else if (Input.GetKeyDown("up"))
        {
            direction = "up";
        }
        else if (Input.GetKeyDown("down"))
        {
            direction = "down";
        }

        // Direction State
        if (direction == "left")
        {
            xDir = transform.position.x - delta;
        }
        else if (direction == "right")
        {
            xDir = transform.position.x + delta;
        }
        else if (direction == "up")
        {
            yDir = transform.position.y + delta;
        }
        else if (direction == "down")
        {
            yDir = transform.position.y - delta;
        }

        // Transform every frame
        transform.position = new Vector2(xDir, yDir);
    }

        void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Handle Death Boundary Triggered");
        SceneManager.LoadScene(2);
    }
}