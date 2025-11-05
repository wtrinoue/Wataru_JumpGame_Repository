using UnityEngine;
using System.Collections;

public class DeleteStep3 : MonoBehaviour
{
    public GameObject panel;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Step (3)のオブジェクトが消えます");
        // step(3)に触れたとき
        if (other.gameObject.name == "Step (3)")
        {
            StartCoroutine(DeleteAfterDelay());
        }
    }


    private IEnumerator DeleteAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        bool isActive = panel.activeSelf;
        panel.SetActive(!isActive);
    }
}
