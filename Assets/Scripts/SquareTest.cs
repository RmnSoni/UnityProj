using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;


public class SquareTest : MonoBehaviour
{
    public static bool destflag=false;
    private Rigidbody2D rb;
    public float rotationMul = 1f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(-8f,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        timer  = Time.deltaTime * rotationMul;
        //        if (Input.GetKeyDown(KeyCode.Space))
        //        {
        //           Destroy(gameObject);
        //        }
        transform.Rotate(0, 0, timer ,Space.Self);

        if (destflag ==true )
        {
            StartCoroutine ( powerup());
        }
        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
 
    IEnumerator powerup()
    {
       
        yield return new WaitForSeconds(0.1f);
        GameController.score += 5;
        destflag = false;
        Destroy(gameObject);
    }

    
}
