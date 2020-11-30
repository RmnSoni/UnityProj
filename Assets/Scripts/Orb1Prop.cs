using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Orb1Prop : MonoBehaviour
{
    public static bool lost = false;
    public float increment = 1f;
    public float decrement = 0.5f;
    float radius;
  
    float timeCounter = 0;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        lost = false;
        radius = 2f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            radius += increment*Time.deltaTime;
        }else        {
            radius -= decrement*Time.deltaTime;
        }


        timeCounter += Time.deltaTime;
        


        float x = (radius * Mathf.Cos((timeCounter*2)+ Mathf.PI)) - 4f;
        float y = (radius * Mathf.Sin((timeCounter*2)+ Mathf.PI));
        transform.position = new Vector3(x, y,0);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "the1s")
        {
            Destroy(other.gameObject);
            
            AudioManager.PlaySound("collect");
            GameController.score += 5;
        }

        if (other.gameObject.tag == "the2s")
        {
            this.gameObject.SetActive(false);
            lost = true;
            Destroy(other.gameObject);
           
        }
    }



}

