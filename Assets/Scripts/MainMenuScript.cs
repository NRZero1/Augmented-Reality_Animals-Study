using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject exitPanel;
    public GameObject aboutPanel;
    public AudioSource aboutSound;
    public AudioSource exitSound;

    public void ExitConfirm()
    {
        Application.Quit();
        Debug.Log("Keluar!");
    }

    public void About()
    {
        aboutPanel.SetActive(true);
        exitPanel.SetActive(false);
    }

    public void Exit()
    {
        exitPanel.SetActive(true);
        aboutPanel.SetActive(false);
    }

    public void Back()
    {
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);
        aboutSound.Stop();
        exitSound.Stop();
    }
}
