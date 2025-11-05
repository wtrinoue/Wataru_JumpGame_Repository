using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Animator stepAnimator;

    // トリガーに他のオブジェクトが入った時に呼ばれる
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("トリガーに触れたよ");
        // Playerタグを持つオブジェクトに触れたら
        if (other.CompareTag("Player"))
        {
            stepAnimator.SetTrigger("TestTrigger"); // Animatorにトリガーを送る
        }
    }
}
