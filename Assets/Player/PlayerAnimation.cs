using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetJumpTrigger()
    {
        animator.SetTrigger("jumpTrigger");
    }

    public void SetRun(bool value)
    {
        animator.SetBool("isRun", value);
    }
}
