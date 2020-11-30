using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqrPwr : MonoBehaviour
{
    float switchColorTime = 0.15f;
    private Rigidbody2D rb;
    float timer = 0;
    float zRot;
    public float rotationMul = 1f;





    void Start()
    {
        timer = 0;
        zRot = 0;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(-8f, 0, 0);

    }


    void Update()
    {
        timer += Time.deltaTime;
        zRot = Time.deltaTime * rotationMul;
        transform.Rotate(0, 0, zRot, Space.Self);
        if (timer >= 2 * switchColorTime)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            timer = 0;
        }
        else
        {
            if (timer >= switchColorTime)
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);

            }



            if (transform.position.x <= -10)
            {
                Destroy(gameObject);
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {

        AudioManager.PlaySound("power");
        Debug.Log("Detected");
        SquareTest.destflag = true;
        
        Destroy(gameObject);
    }

}
