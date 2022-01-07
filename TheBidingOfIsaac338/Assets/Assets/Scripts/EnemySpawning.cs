using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject flyPrefab;
    public GameObject horfPrefab;
    public GameObject wormPrefab;
    private bool alreadySpawn1 =  false;
    private bool alreadySpawn2 = false;
    private bool alreadySpawn3 = false;
    private bool alreadySpawn4 = false;
    private bool alreadySpawn5 = false;
    private bool alreadySpawn6 = false;

    public int enemyNumber;

    private void Start()
    {
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (gameObject.name)
        {
            case "EnemySpawning1":
                if(alreadySpawn1 == false)
                {
                    enemyNumber = 6;
                    GameObject fly1 = Instantiate(flyPrefab, gameObject.transform.position + new Vector3(-5, -1, 0), gameObject.transform.rotation);
                    GameObject fly2 = Instantiate(flyPrefab, gameObject.transform.position + new Vector3(5, -1, 0), gameObject.transform.rotation);
                    GameObject fly3 = Instantiate(flyPrefab, gameObject.transform.position + new Vector3(-5, 1, 0), gameObject.transform.rotation);
                    GameObject fly4 = Instantiate(flyPrefab, gameObject.transform.position + new Vector3(5, 1, 0), gameObject.transform.rotation);
                    GameObject horf1 = Instantiate(horfPrefab, gameObject.transform.position+new Vector3(5,0,0), gameObject.transform.rotation);
                    GameObject horf2 = Instantiate(horfPrefab, gameObject.transform.position+new Vector3(-5, 0, 0), gameObject.transform.rotation);

                    alreadySpawn1 = true;
                }
                break;
            case "EnemySpawning2":
                
                break;
            case "EnemySpawning3":
                if (alreadySpawn2 == false)
                {
                    enemyNumber = 2;
                    GameObject worm1 = Instantiate(wormPrefab, gameObject.transform.position + new Vector3(-3, 0, 0), gameObject.transform.rotation);
                    GameObject worm2 = Instantiate(wormPrefab, gameObject.transform.position + new Vector3(3, 0, 0), gameObject.transform.rotation);

                    alreadySpawn2 = true;
                }
                break;
            case "EnemySpawning4":
                Debug.Log(gameObject.name);
                break;
            case "EnemySpawning5":
                Debug.Log(gameObject.name);
                break;
            case "EnemySpawning6":
                Debug.Log(gameObject.name);
                break;
        }
    }
}
