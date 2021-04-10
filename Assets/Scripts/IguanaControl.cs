using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IguanaControl : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void WalkAttack()
    {
        animator.Play("WalkAttack", -1, 0f);
    }

    public void WalkHit()
    {
        animator.Play("WalkHit", -1, 0f);
    }
}
