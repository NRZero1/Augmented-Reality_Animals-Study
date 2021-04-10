using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTargetTracker : MonoBehaviour
{
    public GameObject ImageTarget;
    
    public string Tracker()
    {
        return ImageTarget.name;
    }
}
