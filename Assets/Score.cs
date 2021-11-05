using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private int score = 0;

    public Text textScore;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        textScore.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score++;
        textScore.text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Finish")
        {
            AddPoint();
        }
    }
}
