using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{    
    public void StartGame()
    {

        AudioManager.PlaySound("menu"); 
        SceneManager.LoadScene("SampleScene");
    }
    public void Menu()
    {

        AudioManager.PlaySound("menu");
        SceneManager.LoadScene("StartGameScene");
    }
    public void Instruction()
    {

        AudioManager.PlaySound("menu");
        SceneManager.LoadScene("HowToPlay");
    }

    public void QuitGame()
    {

        AudioManager.PlaySound("menu");
        Application.Quit();
    }
}
    