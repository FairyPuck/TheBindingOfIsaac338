using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class LittleFly : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform playerTransform;
    private Vector2 movement;
    private float moveSpeed = 2f;

    private int hp = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerTransform = FindObjectOfType<Player>().gameObject.transform;
    }

    void Update()
    {
        if (playerTransform != null)
        {
            Vector3 direction = playerTransform.position - transform.position;
            direction.Normalize();
            movement = direction;
        }
    }
    void FixedUpdate()
    {
        move(movement);
    }

    void move(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    void hurt()
    {
        hp--;
        if(hp==0) Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            hurt();
            Destroy(collision.gameObject);
        }
    }
}
