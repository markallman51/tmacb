using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontBullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
