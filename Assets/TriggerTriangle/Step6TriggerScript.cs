using UnityEngine;

public class Step6TriggerScript : MonoBehaviour
{
    public Animator step6Animator;

    // トリガーに他のオブジェクトが入った時に呼ばれる
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("トリガーに触れたよ");
        // Playerタグを持つオブジェクトに触れたら
        if (other.CompareTag("Player"))
        {
            step6Animator.SetTrigger("ElevateTrigger"); // Animatorにトリガーを送る
        }
    }
}
