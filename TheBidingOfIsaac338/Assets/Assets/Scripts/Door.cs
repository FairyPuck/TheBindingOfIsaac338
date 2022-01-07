using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform playerTransform;
    private Transform child;

    private void Start()
    {
        playerTransform = FindObjectOfType<Player>().gameObject.transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            Transform[] allChildren = GetComponentsInChildren<Transform>();
            foreach (Transform child in allChildren)
            {
                playerTransform.position = child.gameObject.transform.position + new Vector3(1, 0, 0);

            }
        }
    }
}
