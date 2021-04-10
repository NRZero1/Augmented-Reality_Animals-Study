using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSound : MonoBehaviour
{
    public AudioSource bgmSound;
    bool toggleSound;

    public void Toggle()
    {
        toggleSound = !toggleSound;

        if(toggleSound)
        {
            bgmSound.Play();
        }
        else {
            bgmSound.Stop();
        }
    }
}
