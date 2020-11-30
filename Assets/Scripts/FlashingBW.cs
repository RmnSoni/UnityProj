using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FlashingBW : MonoBehaviour
{
    float timer = 0;
    float switchColorTime = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
            timer += Time.deltaTime;
            if (timer >= 2 * switchColorTime)
            {
                gameObject.GetComponent<Image>().color = new Color(0, 0, 0);
                timer = 0;
            }
            else
            {
                if (timer >= switchColorTime)
                {
                    gameObject.GetComponent<Image>().color = new Color(1, 1, 1);
                }
            }
    }
   
}
