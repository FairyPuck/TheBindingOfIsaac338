using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;
    public Image[] heartContainers;
    public TextMeshProUGUI[] UICount;
    public itemCollision itemCollision; 

    private int health, previousHealth;


    // Start is called before the first frame update
    void Start()
    {
        itemCollision = GetComponent<itemCollision>();
        health = itemCollision.health;
        previousHealth = health + 1;
        
    }
    public void UpdateHeartUI(int health)
    {
        int indexHeartToChange = (health / 2);
        int halfVal = health % 2;

        if (previousHealth < health)
        {
            if (halfVal > 0)
            {
                heartContainers[indexHeartToChange].sprite = halfHeart;
            }
            else
            {
                heartContainers[indexHeartToChange - 1].sprite = fullHeart;
            }
        }
        else
        {
            if (halfVal > 0)
            {
                heartContainers[indexHeartToChange].sprite = halfHeart;
            }
            else
            {
                heartContainers[indexHeartToChange].sprite = emptyHeart;
            }
        }

        previousHealth = health;

    }

    public void UpdateCoinUI(int coinCount)
    {
        UICount[0].text = coinCount.ToString("00");
    }
    public void UpdateKeyUI(int keyCount)
    {
        UICount[1].text = keyCount.ToString("00");
    }
    public void UpdateBombUI(int bombCount)
    {
        UICount[2].text = bombCount.ToString("00");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
