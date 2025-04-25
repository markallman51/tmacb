using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public Vector2 input;
    public float speed = 8f;

    public Transform FireSpot;
    public GameObject FrontBullet;
    public float FrontBulletDelay = .25f;
    public float NextFrontBullet;

    public GameObject BottomBomb;
    public Transform bombSpot;
    public float BombDelay = .25f;
    public float NextBomb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = input * speed;

        if(Input.GetKey(KeyCode.A) && Time.time > NextFrontBullet)
        {
            NextFrontBullet = Time.time + FrontBulletDelay;
            Shoot();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            Bomb();
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
    }

    private void Shoot()
    {
        Instantiate(FrontBullet, FireSpot.position, FireSpot.rotation);
    }

    private void Bomb()
    {
        Instantiate(BottomBomb, bombSpot.position, bombSpot.rotation);
    }
}
