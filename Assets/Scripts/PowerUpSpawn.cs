using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public float respawnTime = 10.0f;
    public GameObject squarePwr;
    public GameObject triPwr;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void Spawntri()
    {

        GameObject b = Instantiate(triPwr) as GameObject;
     
        float pos2 = UnityEngine.Random.Range(-4f, 4.5f);
       
        b.transform.position = new Vector2(10, pos2);
    }
    private void SpawnSqr()
    {
        GameObject a = Instantiate(squarePwr) as GameObject;
   
        float pos1 = UnityEngine.Random.Range(-4.5f, 4f);
    
       
        a.transform.position = new Vector2(10, pos1);
   
    }

    IEnumerator asteroidWave()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(respawnTime);
            SpawnSqr();
            yield return new WaitForSeconds(respawnTime);
            Spawntri();
        }
    }


}