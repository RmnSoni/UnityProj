using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclespawnner : MonoBehaviour
{
    public float respawnTime = 1.0f;
    public GameObject obstacle1;
    public GameObject obstacle2;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void SpawnEnemy()
    {
        GameObject a = Instantiate(obstacle1) as GameObject;
        GameObject b = Instantiate(obstacle2) as GameObject;
        float pos1 = UnityEngine.Random.Range(-4.5f, 4f);
        float pos2 = UnityEngine.Random.Range(-4f, 4.5f);
        while (Math.Abs(pos1- pos2)<0.8)
        {
            pos2 = UnityEngine.Random.Range(-4f, 4.5f);
        }
        a.transform.position = new Vector2(10, pos1);
        b.transform.position = new Vector2(10, pos2);
    }

    IEnumerator asteroidWave()
    {
        while (true)
        {   
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
    }

 
}
