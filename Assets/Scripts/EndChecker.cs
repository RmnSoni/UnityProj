using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndChecker : MonoBehaviour
{
    private static bool dest1;
    private static bool dest2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dest1 = Orb1Prop.lost;
        dest2 = Orb2prop.lost;

        if (dest1)
        {
            StartCoroutine(wait());
        }
        if (dest2)
        {
            StartCoroutine(wait());

        }

    }
    IEnumerator wait()
    {
        while (true)
        {
            AudioManager.PlaySound("death");
            yield return new WaitForSeconds(0.35f);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
