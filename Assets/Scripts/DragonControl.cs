using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Walk()
    {
        animator.Play("Walk", -1, 0f);
    }

    public void FlyFlame()
    {
        animator.Play("FlyFlame", -1, 0f);
    }
}
