using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip menuSelect, powerPick, collectiblePick, death;
 
    static AudioSource audioSrc;
    void Start()
    {
        menuSelect = Resources.Load<AudioClip>("SwitchActivated");
        powerPick = Resources.Load<AudioClip>("HealthPickup");
        collectiblePick = Resources.Load<AudioClip>("GenericPickup");
        death = Resources.Load<AudioClip>("SpaceShotgun");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "menu":
                audioSrc.PlayOneShot(menuSelect);
                break;
            case "death":
                audioSrc.PlayOneShot(death);
                break;
            case "power":
                audioSrc.PlayOneShot(powerPick);
                break;
            case "collect":
                audioSrc.PlayOneShot(collectiblePick);
                break;

        }
    }
}
