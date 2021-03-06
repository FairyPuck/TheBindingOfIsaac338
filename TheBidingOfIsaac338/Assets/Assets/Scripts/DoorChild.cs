using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorChild : MonoBehaviour
{
    public Transform playerTransform;
    private bool open = true;

    private void Start()
    {
        playerTransform = FindObjectOfType<Player>().gameObject.transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7 && open == true)
        {
            playerTransform.position = transform.parent.gameObject.transform.position + new Vector3(-1, 0, 0);
        }
    }
}
