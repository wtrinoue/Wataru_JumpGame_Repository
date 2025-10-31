using UnityEngine;
using TMPro;
using System.Collections;

public class AutoHideText : MonoBehaviour
{
    private TextMeshProUGUI textUI;

    void Start()
    {
        // アタッチされたオブジェクトの TextMeshProUGUI コンポーネントを取得
        textUI = GetComponent<TextMeshProUGUI>();

        // 1秒後に非表示にするコルーチンを開始
        StartCoroutine(HideAfterSeconds(1f));
    }

    IEnumerator HideAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        textUI.enabled = false; // テキストを非表示に
    }
}
