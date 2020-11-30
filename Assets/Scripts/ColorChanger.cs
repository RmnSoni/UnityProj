using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update

    int counter;
    float rval;
    float gval ;
    float bval; 
    public float timer;



    void Start()
    {
      
        counter = 0;
        timer = 0;
        rval = 140f;
        gval = 220f;
        bval = 140f;
    }



    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 0.03)
        {
            if (counter == 0)
            {
                rval += 1;
                if (rval >= 210)
                {
                    counter += 1;
                }
            }


            if (counter == 1)
            {
                gval -= 1;
                if (gval <= 140)
                {
                    counter += 1;
                }
            }


            if (counter == 2)
            {
                bval += 1;
                if (bval >= 220)
                {
                    counter += 1;
                }
            }


            if (counter == 3)
            {
                rval -= 1;
                if (rval <= 140)
                {
                    counter += 1;
                }
            }


            if (counter == 4)
            {
                gval += 1;
                if (gval >= 220)
                {
                    counter += 1;
                }
            }
            if (counter == 5)
            {
                bval -= 1;
                if (bval <= 140)
                {
                    counter = 0;
                }
            }

            gameObject.GetComponent<SpriteRenderer>().color = new Color(rval/255f, gval/255f, bval/255f);

            //Reset the timer to 0.
            timer = 0;
        }
    }
}
