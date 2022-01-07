using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horf : MonoBehaviour
{
    private int hp = 5;
    void hurt()
    {
        hp--;
        if (hp == 0) Destroy(this.gameObject);
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
