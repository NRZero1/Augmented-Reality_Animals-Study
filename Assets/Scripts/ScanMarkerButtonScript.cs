using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ScanMarkerButtonScript : MonoBehaviour
{
    public GameObject backPanel;
    public GameObject scanMarkerPanel;
    public AudioSource iguanaSound;
    public AudioSource dragonSound;
    public AudioSource tigerSound;
    public AudioSource ScanMarker;
    
    public void Back()
    {
        backPanel.SetActive(true);
    }

    public void BackNo()
    {
        backPanel.SetActive(false);
    }

    public void Found()
    {
        scanMarkerPanel.SetActive(false);
    }

    public void Lost()
    {
        scanMarkerPanel.SetActive(true);
        iguanaSound.Stop();
        dragonSound.Stop();
        tigerSound.Stop();
    }

    void Start()
    {
        scanMarkerPanel.SetActive(true);
        backPanel.SetActive(false);
    }
}
