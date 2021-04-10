using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerControl : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Run()
    {
        animator.Play("run", -1, 0f);
    }

    public void Walk()
    {
        animator.Play("Walk", -1, 0f);
    }
}
