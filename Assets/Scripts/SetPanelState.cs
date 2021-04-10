using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPanelState : MonoBehaviour
{
    public GameObject aboutPanel;
    public GameObject exitPanel;
    public AudioSource aboutSound;
    public AudioSource exitSound;
    void Start()
    {
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);
        aboutSound.Stop();
        exitSound.Stop();
    }
}
