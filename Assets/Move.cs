using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public GameManager gameManager;

    public string moveUp;
    public string moveDown;

    public float speed = 150f;
    public Rigidbody2D rb;

    private Vector2 startPosition;
    private Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            move.y = 1;
        }
        else if (Input.GetKey(moveDown))
        {
            move.y = -1;
        }
        else
        {
            move.y = 0;
        }
    }

    private void FixedUpdate()
    {
        //move.Normalize();
        rb.velocity = new Vector2(move.x, move.y * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Projectile":
            case "Finish":
                gameManager.RestartShip(rb, startPosition);
                break;
            default:
                break;
        }
    }

}
