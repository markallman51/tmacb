using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    public Transform StarSpawner;
    public Transform star;
    public float spawndelay = 1f;
    public float nextstar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextstar)
        {
            nextstar = Time.time + spawndelay;
            Star();
        }
    }

    void Star()
    {
        float yPos = StarSpawner.transform.position.y + Random.Range(-5f, 5f);
        Vector2 spawnPos = new Vector2(StarSpawner.transform.position.x, yPos);

        Instantiate(star, spawnPos, Quaternion.identity);
        
    }
}
