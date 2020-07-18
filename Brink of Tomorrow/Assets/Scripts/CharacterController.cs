using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    //variables
    public float GasVolume = 100;
    public float speed = 5;
    public float jetpackForce = 50;
    public Vector2 velocity = Vector2.zero;
    public Vector2 force = Vector2.zero;
    public bool inSpace;
    public bool inInteractive = false;
    public bool hasJetpack = false;
    //references
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!inSpace) Move();
        if (inSpace && hasJetpack && GasVolume > 0) MoveInSpace();
    }

    public void Move()
    {
        velocity = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            velocity += Vector2.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector2.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector2.right;
        }

        if (Input.GetKey(KeyCode.S))
        {
            velocity += Vector2.down;
        }

        rb.velocity = velocity.normalized * speed;
    }

    public void MoveInSpace()
    {
        force = Vector2.zero;
        GasVolume -= 1;

        if (Input.GetKey(KeyCode.W))
        {
            force += Vector2.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            force += Vector2.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            force += Vector2.right;
        }

        if (Input.GetKey(KeyCode.S))
        {
            force += Vector2.down;
        }

        Vector2 temp = force.normalized * jetpackForce;
        rb.AddForce(temp);

    }
}
