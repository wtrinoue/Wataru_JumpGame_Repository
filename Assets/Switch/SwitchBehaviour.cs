using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehaviour : MonoBehaviour
{
    private Animator switchAnimator;
    public Animator stepAnimator;
    public Animator step6Animator;

    // Start is called before the first frame update
    void Start()
    {
        switchAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            switchAnimator.SetBool("isSwitching", true);
            stepAnimator.SetTrigger("TestTrigger");
            step6Animator.SetTrigger("ElevateTrigger");
        }
    }
}
