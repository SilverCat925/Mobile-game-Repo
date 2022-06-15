using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 2;


    private Rigidbody2D physicsBody = null;


    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();

        //physicsBody.velocity = new Vector2(2, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
        float axisValx = Input.GetAxis("Horizontal");
        float axisValy = Input.GetAxis("Vertical");

        //physicsBody.velocity = new Vector2(axisValx * Speed, axisValy *Speed);

        
    }

    public void MoveLeft()
    {
        physicsBody.velocity = new Vector2(-Speed, 0);

    }

    public void MoveRight()
    {
        physicsBody.velocity = new Vector2(Speed, 0);

    }

    public void MoveUp()
    {
        physicsBody.velocity = new Vector2(0, Speed);

    }

    public void MoveDown()
    {
        physicsBody.velocity = new Vector2(0, -Speed);

    }
}
