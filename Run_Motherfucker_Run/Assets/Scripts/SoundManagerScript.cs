using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour { 

    public static AudioClip playerHitSound, confusionSound, normalisedSound, playerHealSound, playerDeathSound;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        playerHitSound = Resources.Load<AudioClip> ("takeDamage");
        playerHealSound = Resources.Load<AudioClip> ("healthPickup");
        playerDeathSound = Resources.Load<AudioClip> ("playerDeath");
        confusionSound = Resources.Load<AudioClip>("confusion");
        normalisedSound = Resources.Load<AudioClip>("normalise");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "takeDamage":
                audioSrc.PlayOneShot (playerHitSound);
                break;
            case "healthPickup":
                audioSrc.PlayOneShot(playerHealSound);
                break;
            case "playerDeath":
                audioSrc.PlayOneShot(playerDeathSound);
                break;
            case "confusion":
                audioSrc.PlayOneShot(confusionSound);
                break;
            case "normalise":
                audioSrc.PlayOneShot(normalisedSound);
                break;
        }
    }
}
