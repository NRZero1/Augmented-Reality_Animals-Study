using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileCall : MonoBehaviour
{
    // Start is called before the first frame update
    public void linkCall(string link)
    {
        Application.OpenURL(link);
    }
}
