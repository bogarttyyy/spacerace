using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLoader : MonoBehaviour
{
    public string direction;
    public float speed = 100f;

    public float minHeight;
    public float maxHeight;

    public GameObject projectile;

    private List<GameObject> projectiles;

    public float maxTime = 1;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        projectiles = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > maxTime && projectiles.Count < 10)
        {
            GameObject newBullet = Instantiate(projectile);
            newBullet.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);

            projectiles.Add(newBullet);
            Destroy(newBullet, 2);
            timer = Random.Range(0.1f, 0.7f);
        }

        timer += Time.deltaTime;
    }
}
