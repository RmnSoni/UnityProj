using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;
    static int mera = 0;
    public static int highScore=0;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        mera = GameController.score;
        ScoreText.text = "Score : " + mera.ToString();
        if (mera > highScore)
        {
            PlayerPrefs.SetInt("HighScore", mera);

            HighScoreText.text = "HighScore : " + mera.ToString();

        }else
        {

            HighScoreText.text = "HighScore : " + highScore.ToString();
        }



    }
    public void ResetHS()
    {
        AudioManager.PlaySound("menu");
        PlayerPrefs.DeleteKey("HighScore");
        highScore = 0;
    }
}
