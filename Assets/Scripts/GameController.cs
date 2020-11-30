using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI   ;

public class GameController : MonoBehaviour
{

    public Text ScoreText;

    public float timer;
    public static int score=0;
    
    
    void Start()
    {
        timer=0;
        score = 0;
    }



    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 0.15)
        {

            score += 1;

            //We only need to update the text if the score changed.
            ScoreText.text = "Score : " + score.ToString();

            //Reset the timer to 0.
            timer = 0;
        }
    }
    
}
