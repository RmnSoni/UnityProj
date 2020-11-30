using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revpwr : MonoBehaviour
{
    float switchColorTime = 0.15f;
    public static int flagrev;
    float zRot;
    public float rotationMul = 1f;
    private Rigidbody2D rb;
    float timer = 0;
    
    
    
    
    
    
    void Start()
    {
        timer = 0;
        flagrev = 0;
        zRot = 0;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(-8f, 0, 0);
       
    }


    void Update()
    {
        timer += Time.deltaTime;
        zRot = Time.deltaTime * rotationMul;
        transform.Rotate(0, 0, zRot, Space.Self);
        if (timer >= 2*switchColorTime)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            timer = 0;
        }
        else { if (timer >= switchColorTime)
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            }
        }



        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Detected");
        AudioManager.PlaySound("power");
        GameController.score += 50;
        Destroy(gameObject);
    }

}
