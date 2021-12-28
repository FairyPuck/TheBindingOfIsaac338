using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollision : MonoBehaviour
{
    public int health, maxHealth;
    public int coinCount, keyCount, bombCount = 0;
    private UIManager UIManager;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
        UIManager = GetComponent<UIManager>();
        UIManager.UpdateCoinUI(coinCount);
        UIManager.UpdateKeyUI(keyCount);
        UIManager.UpdateBombUI(bombCount);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            switch (collision.gameObject.tag)
            {
                case "coin":
                    coinCount += 1;
                    //UIManager.UpdateCoinUI(coinCount);
                    Destroy(collision.gameObject);
                    break;

                case "heart":
                    if (health < maxHealth)
                    {
                        if (health < maxHealth - 1)
                        {
                            health++;
                            //UIManager.UpdateHeartUI(health);
                            Destroy(collision.gameObject);
                        }
                        health++;
                        //UIManager.UpdateHeartUI(health);
                        Destroy(collision.gameObject);
                    }

                    break;

                case "key":
                    keyCount += 1;
                    //UIManager.UpdateKeyUI(keyCount);
                    Destroy(collision.gameObject);
                    break;

                case "bomb":
                    bombCount += 1;
                    //UIManager.UpdateBombUI(bombCount);
                    Destroy(collision.gameObject);
                    break;
            }

        }
    }
}
