using UnityEngine;
public class AnimatonScript : MonoBehaviour
{
    public Animator animator;

    public void BottonClickFun()
    {
        animator.SetTrigger("TestTrigger");
    }
}