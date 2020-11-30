using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Orb2prop : MonoBehaviour
{
    public static bool lost = false;
    float radius;
    public float increment = 5f;
    public float decrement = 2.5f;
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
            radius += increment * Time.deltaTime; 
        }
        else
        {
            radius -= decrement * Time.deltaTime;
        }

       
          timeCounter += Time.deltaTime;
       


        float x = (radius*Mathf.Cos((timeCounter*2))) - 4f;
        float y = (radius*Mathf.Sin(timeCounter*2));
        
        transform.position = new Vector3(x, y,0);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "the2s")
        {
            AudioManager.PlaySound("collect");
            Destroy(other.gameObject);

            GameController.score += 5;
        }

        if (other.gameObject.tag == "the1s")
        {
            this.gameObject.SetActive(false);
            lost = true;
            Destroy(other.gameObject);
           
        }
    }

    
    
}
