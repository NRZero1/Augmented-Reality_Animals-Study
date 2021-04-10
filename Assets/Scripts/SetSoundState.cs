using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSoundState : MonoBehaviour
{
    public AudioSource bgmSound;
    public AudioSource iguanaSound;
    public AudioSource dragonSound;
    public AudioSource tigerSound;

    void Start()
    {
        bgmSound.Stop();
        iguanaSound.Stop();
        dragonSound.Stop();
        tigerSound.Stop();
    }
}
