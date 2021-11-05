using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D player1;
    private Rigidbody2D player2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartShip(Rigidbody2D ship, Vector2 startPosition)
    {
        ship.position = startPosition;
    }
}
